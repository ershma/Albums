   M S B A M L   `   `   `  ����A  =Albums, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AlbumsAlbums  5   	   P LVirtualizingWrapPanel, Version=1.4.2.0, Culture=neutral, PublicKeyToken=nullX@clr-namespace:WpfToolkit.Controls;assembly=VirtualizingWrapPanelWpfToolkit.Controls 5   	   5clr-namespace:Albums.ViewModelsAlbums.ViewModels  5   	   -clr-namespace:Albums.ModelsAlbums.Models  5	   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   
       Albums.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Albums     5   	   Owp@clr-namespace:WpfToolkit.Controls;assembly=VirtualizingWrapPanel     5   	   .vmclr-namespace:Albums.ViewModels     5   	   -modelclr-namespace:Albums.Models     5	   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   
   -   5          � Title$  Albums��5   	   $	��450��6   $	��800��6%      	BackColor#��[  6J    � 	Resources 5        OverlayService S� 
MethodName S� 
ObjectType"   Albums.Models.OverlayService��%A   &	       S� 5   
   $ GetInstance��5      "  5      5       � DataContext 5      &    Albums.ViewModels.AlbumViewModel  5   
   -   5        main��5      .��5      �  � ColumnDefinitions 5   
   �� 5   
   $
��AUTO �6   �� 5   
   $��* �6    � RowDefinitions 5      �� 5    
   $
��Auto �6   �� 5!   
   $��* �6   .+�5$      �� .+�5&      �� ��6   �� *AddAlbumCmd+.��6:   Создать альбом6J   �� 5'      ��6   �� *	RenameCmd+��63   �� *SelectedAlbum+.��6^   Переименовать6m   �� 5(      $"��Экспортировать��5+      ��5(      �� *ExportAlbumCmd+��5)      �� *SelectedAlbum+5+   2   �� 5,      ��6   �� *RemoveAlbumCmd+��5-      �� *SelectedAlbum+.��69   Удалить альбом6I   � 5.       5/      �� 50      $
��auto �6'   �� 51      $��* �6'   .+�53      ��   UsersElement#��[ 6"   $��0q�6H     
SearchIcon#��[ 6S   $��35��6y   $��35��6�   �� 55       �� MaxLines$ 10��6   $��80��6(   $��1��66   $��0,0,4,0q�6F   
 � Tag$ Поиск...��6W   	 �� TextWrapping$
	 Wrap=�6f   ��6z   �� *
SearchText+
 �� UpdateSourceTrigger$
 PropertyChanged=�.��6�   6�   57      58      �� 5:   
   -   5        $��	AlbumList��5;      $��0��5:      $��1��5<      #��[  5?      #��[  5@      ��5=      �� *
AlbumsView+ �� SelectedItem 5>      �� *SelectedAlbum+ �� Mode$ TwoWay=���5B      �� 5C       �� 
TargetType" ��6    �� BasedOn# [ 63   .�5D      ��  �� Property � �� �� Value# [  63   �� 5E       � �� 
 LBItem# [ 61    �� Triggers 5H      P� 5K       P� Property �@J�IsMouseOver P� Value . . �5L      ��  � �� �#f7baa26;   �� 5M       � ��# [  6;   5N      P� 5O       �@��
IsSelected . . �5P      ��  � �� �#f7baa26;   �� 5Q       � ��# [  6;   5R      5V      ��5X      �� 5Y      .R�5Z      $� 5[      5]      �� 5_      $��1��6    �� CornerRadius$ 	15,15,0,0��5`        	Workspace#��[ 5a      $��2��5b      ._�5c      �  5d      �� 5e      $
��auto �6%   �� 5f      $��* �6$   �� 5g      $��3 �6$   �� 5h      .+�5j      ��  �� Orientation$ 
Horizontal=�6   $��2q�66   .+�5l      �� ��6   ��  �� Path$ AddPhotoCmd���6D   �� *SelectedAlbum+.��6o   Добавить фото6~   �� 5m      ��6   �� *RemovePhotoCmd+��6B   ��  �� ElementName$ 	PhotoList��$ SelectedItems�.��6�   Удалить фото6�   �� 5n      ��6   �� $ 
OpenDirCmd���6A   �� $! SelectedAlbum.SelectedPhoto�.��6   Открыть пакаку6�   �� 5o      ��6   �� *ExportPhotoCmd+��6@   �� $ SelectedAlbum�.��6q   '%Экспортировать фото6�   5q      �� 5r      $��1��6   ��6&   �� *" SelectedAlbum.SelectedPhoto.Path+5s      �� 5t      #��[  6   $��2��6G   $��3��6T   $
��auto��6_   $��Stretch=�6l   $��Center=�6�   �� 5v      -   5         ��Name$ 	PhotoList��5v      $��3��5x      $��Disabled=�5y      #��[ 5|      #��[ 5}       �� SelectionMode$ Extended=�5~      ��5z      �� $ SelectedAlbum.Photos� 5{      �� $! SelectedAlbum.SelectedPhoto�.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5�   &      	EventName$ MouseDoubleClick��65   .  (System.Windows.Interactivity.TriggerBase   Actions. 5�   *   6  0System.Windows.Interactivity.InvokeCommandAction     Command 5�   *   �� $ ShowPhotoCmd�   CommandParameter 5�   +   �� $! SelectedAlbum.SelectedPhoto�5�   '   ��5�      �� 5�      .R�5�      �� $	��100��6$   $	��100��60   ��6=   �� $ TemplateImage� � ToolTip 5�   "   �� 5�   &   .+�5�   *   �� $ 
Horizontal=�65   .+�5�   *   �� Название:6@   �� 5�   .   ��68   �� $
 Name�5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� 	Путь:6@   �� 5�   .   ��68   �� $	 Dir�5�   +   �� 5�   *   $ 
Horizontal=�65   .+�5�   .   �� Дата создания:6I   �� 5�   .   ��68   �� $ 
DateCreate�5�   +   5�   '   5�      5�      ��5�      �� 5�      .R�5�   "   /  )WpfToolkit.Controls.VirtualizingWrapPanel  5�      5�      5�      5�      � 5�   
   -   5        $��overlay��5�      $��2��5�      $��2��5�      ���	#7F302E31��5�      �� 5�      " �6    5�      �� 5�        �� Binding  6&   �� $ overlayText��$
 Text�! �� Value!  6]   .a�5�      ��  � y�$ Hidden=�6;   5�      5�      .+�5�      �� $	��500��5�      $	��300��5�      $��Center=�5�      $��Center=�5�      ���#cd6272$ 7��5�      ._�5�      � .+�5�      �� $��Center=�6!   .+�5�      �� -   5        $��overlayText��5�      $��30(�5�      " �� TextAlignment$" Center=�5�      ��5�      �� # �� Source## [ $
 Text�5�      � 5�      $��20��5�      $��20q�5�      #��[  5�      $��0q�5�      
�������$ � IsIndeterminate$ . 5�      5�      5�      5�      5�      5�      5�      