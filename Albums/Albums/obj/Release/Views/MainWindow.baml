   M S B A M L   `   `   `  ���� A  =Albums, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AlbumsAlbums  P LVirtualizingWrapPanel, Version=1.4.2.0, Culture=neutral, PublicKeyToken=nullX@clr-namespace:WpfToolkit.Controls;assembly=VirtualizingWrapPanelWpfToolkit.Controls 5clr-namespace:Albums.ViewModelsAlbums.ViewModels  -clr-namespace:Albums.ModelsAlbums.Models  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity     Albums.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:Albums     Owp@clr-namespace:WpfToolkit.Controls;assembly=VirtualizingWrapPanel     .vmclr-namespace:Albums.ViewModels     -modelclr-namespace:Albums.Models     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     -     � Title$  Albums��$	��450��$	��800��   	BackColor#��[   � 	Resources   OverlayService S� 
MethodName S� 
ObjectType"   Albums.Models.OverlayService��%&   &	       S� $ GetInstance��"   � DataContext &    Albums.ViewModels.AlbumViewModel  -   main��.���  � ColumnDefinitions �� $
��AUTO ��� $��* � � RowDefinitions �� $
��Auto ��� $��* �.+��� .+��� ���� *AddAlbumCmd+.��Создать альбом�� ���� *	RenameCmd+���� *SelectedAlbum+.��Переименовать�� $"��Экспортировать������ *ExportAlbumCmd+���� *SelectedAlbum+�� ���� *RemoveAlbumCmd+���� *SelectedAlbum+.��Удалить альбом�  �� $
��auto ��� $��* �.+���   UsersElement#��[ $��0q�  
SearchIcon#��[ $��35��$��35����  �� MaxLines$ 10��$��80��$��1��$��0,0,4,0q�
 � Tag$ Поиск...��	 �� TextWrapping$
	 Wrap=����� *
SearchText+
 �� UpdateSourceTrigger$
 PropertyChanged=�.���� -   $��	AlbumList��$��0��$��1��#��[  #��[  ���� *
AlbumsView+ �� SelectedItem �� *SelectedAlbum+ �� Mode$ TwoWay=�����  �� 
TargetType" �� �� BasedOn# [ .���  �� Property � �� �� Value# [  ��  � �� 
 LBItem# [  �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � �� �#f7baa2��  � ��# [  P�  �@��
IsSelected . . ���  � �� �#f7baa2��  � ��# [  ���� .R�$� �� $��1�� �� CornerRadius$ 	15,15,0,0��  	Workspace#��[ $��2��._��  �� $
��auto ��� $��* ��� $��3 ��� .+���  �� Orientation$ 
Horizontal=�$��2q�.+��� ����  �� Path$ AddPhotoCmd����� *SelectedAlbum+.��Добавить фото�� ���� *RemovePhotoCmd+����  �� ElementName$ 	PhotoList��$ SelectedItems�.��Удалить фото�� ���� $ 
OpenDirCmd����� $! SelectedAlbum.SelectedPhoto�.��Открыть пакаку�� ���� *ExportPhotoCmd+���� $ SelectedAlbum�.��'%Экспортировать фото�� $��1������ *" SelectedAlbum.SelectedPhoto.Path+�� #��[  $��2��$��3��$
��auto��$��Stretch=�$��Center=��� -    ��Name$ 	PhotoList��$��3��$��Disabled=�#��[ #��[  �� SelectionMode$ Extended=����� $ SelectedAlbum.Photos� �� $! SelectedAlbum.SelectedPhoto�.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ MouseDoubleClick��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� $ ShowPhotoCmd�   CommandParameter �� $! SelectedAlbum.SelectedPhoto����� .R��� $	��100��$	��100������ $ TemplateImage� � ToolTip �� .+��� $ 
Horizontal=�.+��� Название:�� ���� $
 Name��� $ 
Horizontal=�.+��� 	Путь:�� ���� $	 Dir��� $ 
Horizontal=�.+��� Дата создания:�� ���� $ 
DateCreate����� .R�/  )WpfToolkit.Controls.VirtualizingWrapPanel  � -   $��overlay��$��2��$��2�����	#7F302E31���� " � ��   �� Binding  �� $ overlayText��$
 Text�! �� Value!  .a���  � y�$ Hidden=�.+��� $	��500��$	��300��$��Center=�$��Center=����#cd6272$ 7��._�� .+��� $��Center=�.+��� -   $��overlayText��$��30(�" �� TextAlignment$" Center=����� # �� Source## [ $
 Text�� $��20��$��20q�#��[  $��0q�
�������$ � IsIndeterminate$ . 