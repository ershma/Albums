using Albums.Models;
using Albums.Services;
using Albums.Views;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Windows.Data;
using System.Windows.Threading;
using System.Diagnostics;
using System.Collections;
using System.Windows.Controls;

namespace Albums.ViewModels
{
    public class AlbumViewModel:INotifyPropertyChanged
    {   private CommandTemplate addPhotoCmd;
        private Album selectedAlbum;
        private CommandTemplate addAlbumCmd;
        private CommandTemplate removeAlbumCmd;
        private CommandTemplate removePhotoCmd;
        private CommandTemplate showPhotoCmd;
        private CommandTemplate exportAlbumCmd;
        private string searchText;
        private CommandTemplate renameCmd;
        private CommandTemplate openDirCmd;
        private IOFileService<ObservableCollection<Album>> fileService = new IOFileService<ObservableCollection<Album>>("Data.json");
         private CommandTemplate exportPhotoCmd;
      
        public CommandTemplate ExportPhotoCmd
        {
            get => exportPhotoCmd ?? (exportPhotoCmd = new CommandTemplate(async obj =>
            {
                var dir = new System.Windows.Forms.FolderBrowserDialog();
                var result = dir.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                    try
                    {
                        await Task.Factory.StartNew(() =>
                        {
                            Album album = (Album)obj;
                            string extension;
                            string path;
                            int i = 0;
                            Photo photo = album.SelectedPhoto;
                            extension = Path.GetExtension(photo.Path);
                            path = dir.SelectedPath + $@"\{album.Title}_{photo.Name}{extension}";
                            int j = 1;
                            while (File.Exists(path))
                            {
                                path = dir.SelectedPath + $@"\{album.Title}_{photo.Name}({j++}){extension}";
                            }

                            File.Copy(photo.Path, path);
                            OverlayService.GetInstance().Show($"Экспортирование фото... {i++}/1");

                        });
                        OverlayService.GetInstance().Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


            }, obj => (obj is Album)));
        }

        public CommandTemplate OpenDirCmd
        {
            get => openDirCmd ?? (openDirCmd = new CommandTemplate(obj =>
                 {
                     string path = ((Photo)obj).Dir;
                     if (Directory.Exists(path))

                         Process.Start(path);
                 }, obj => (obj is Photo)));
        }

        public CommandTemplate RenameCmd
        {
            get => renameCmd ?? (renameCmd = new CommandTemplate(
                obj =>
                {
                    InputBox rename = new InputBox("Введите новое имя альбома");
                    if (rename.ShowDialog() == true)
                    {
                        string newName = rename.Text;
                        
                        selectedAlbum.Title = newName;
                    }

                },
                obj=>obj is Album));
        }
        public void Save()
        {
            fileService.Save(Albums);
            
            
        }

        public CommandTemplate ExportAlbumCmd
        {
            get => exportAlbumCmd ?? (exportAlbumCmd = new CommandTemplate(async obj =>
                  {
                 
                 


                      var dir = new System.Windows.Forms.FolderBrowserDialog();
                      var result = dir.ShowDialog();
                      if (result == System.Windows.Forms.DialogResult.OK)
                          try
                          {
                              await Task.Factory.StartNew(() =>
                              {
                                  Album album = (Album)obj;
                                  string extension;
                                  string path;
                                  int i = 0;
                                  foreach (Photo photo in album.Photos)
                                  {
                                      extension = Path.GetExtension(photo.Path);
                                      path = dir.SelectedPath + $@"\{album.Title}_{photo.Name}{extension}";
                                      int j = 1;
                                      while (File.Exists(path))
                                      {
                                          path = dir.SelectedPath + $@"\{album.Title}_{photo.Name}({j++}){extension}";
                                      }
                                      
                                      File.Copy(photo.Path, path);
                                      OverlayService.GetInstance().Show($"Экспортирование фото... \n{i++}/{album.Photos.Count}");

                                  }
                              });
                              OverlayService.GetInstance().Close();
                          }
                          catch (Exception ex)
                          {
                              MessageBox.Show(ex.Message);
                          }



                  },
                obj=>obj is Album))
            ;
        }

      

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Album> Albums { get; set; } 
        public ICollectionView AlbumsView { get; set; }
        public string SearchText
        {

            get => searchText;
            set
            {
                searchText = value;
                
                AlbumsView.Filter = obj =>
                {
                    if (obj is Album album)
                    {
                        return album.Title.ToLower().Contains(SearchText.ToLower());
                    }
                    return false;
                };
            }
        }

        public AlbumViewModel()
        {
            OverlayService.GetInstance().Show = (str) =>
            {
                OverlayService.GetInstance().Text = str;
            };
            Albums = fileService.Load();
            BindingOperations.EnableCollectionSynchronization(Albums, new object());
            AlbumsView = CollectionViewSource.GetDefaultView(Albums);
            

        }
        public CommandTemplate ShowPhotoCmd
        {
            get
            {
                return showPhotoCmd ?? (showPhotoCmd = new CommandTemplate(
                    obj =>
                    {
                        if (obj is Photo)
                        {
                            PhotoView photoView = new PhotoView(SelectedAlbum);



                            photoView.ShowDialog();
                        }
                    }));
            }
        }
        public CommandTemplate AddAlbumCmd
        {
            get
            {
                return addAlbumCmd ?? (addAlbumCmd = new CommandTemplate(
                    obj =>
                    {
                        InputBox inputBox = new InputBox("Введите название альбома");
                        
                        if ( inputBox.ShowDialog()== true)
                        {  string result = inputBox.Text;
                               
                                    Albums.Add(new Album(result));
                               
                             
                                AlbumsView.Refresh();
                            
                        }
                        
                    }));
            }
        }
        //  TODO
    

        public CommandTemplate RemoveAlbumCmd
        {
            get => removeAlbumCmd ?? (removeAlbumCmd = new CommandTemplate(
                obj =>
                {
                   
                        MessageBoxResult result;
                        result = MessageBox.Show($"Вы действительно хотите удалить альбом \"{selectedAlbum.Title}\"?", "", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel);
                        if (result == MessageBoxResult.OK)
                        {
                        
                            Albums.Remove(selectedAlbum);
                     
                        }
                   
                },
                obj => obj != null
                ));
        }

        public Album SelectedAlbum
        {
            get => selectedAlbum;
            set
            {
                
                selectedAlbum = value;
                OnPropertyChanged("SelectedAlbum");
            }
        }

   
         public CommandTemplate AddPhotoCmd
         {
            get {
                return addPhotoCmd ?? (addPhotoCmd = new CommandTemplate(
             async obj =>
              {

                  OpenFileDialog openFile = new OpenFileDialog();
                  openFile.Multiselect = true;

                  if (openFile.ShowDialog() == true)
                  {
                      Album album = (Album)obj;
                      BindingOperations.EnableCollectionSynchronization(album.Photos, new object());
                      await Task.Factory.StartNew(() =>
                      {
                          int i = 0;
                          foreach (string path in openFile.FileNames)
                          {
                              FileInfo fileInfo = new FileInfo(path);
                              
                              album.Photos.Add(new Photo(path)
                              {
                                  Name = Path.GetFileNameWithoutExtension(path),
                                  Dir = Path.GetDirectoryName(path),
                                  DateCreate = File.GetCreationTime(path).ToString()
                                  
                              


                              });
                              
                              OverlayService.GetInstance().Show($"Загрузка фото...\n{i++}/{openFile.FileNames.Length}");
                          }
                      });
                      BindingOperations.DisableCollectionSynchronization(album.Photos);
                      OverlayService.GetInstance().Close();
                         
                          
                     
                      
                  }
              },
              obj=>(obj is Album)
              ));
            }

         }

        public CommandTemplate RemovePhotoCmd
        {
            get => removePhotoCmd ?? (removePhotoCmd = new CommandTemplate(
                obj => {
                  
                        MessageBoxResult result;
                        result = MessageBox.Show($"Вы действительно хотите удалить выбранные фото?", "", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel);
                        if (result == MessageBoxResult.OK)
                        {
                        IList list = ((IList)obj);
                         for(int i=0;i<list.Count;i++)
                           
                            SelectedAlbum.Photos.Remove((Photo)list[i]);
                            
                        }
                    
                },
                 
                obj => ((obj is IList)&& (obj!=null))
                ));
            
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
