   M S B A M L   `   `   `  ���� A  =Albums, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Albums.ViewsAlbums.Views  -clr-namespace:Albums.ModelsAlbums.Models      Albums.Views.PhotoView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Albums.Views     $mwViews\MainWindow.xaml     .modelsclr-namespace:Albums.Models       � Title$  	PhotoView��$	��450��$	��800��
���   � � 	Resources  �� 
TargetType   UsersElement �� BasedOn �� Property �� Value �� Triggers :� RoutedEvent �� TargetProperty		 W� To��%�   '��       7   �� " ��8   .���  � ��
 �������  �@J�Opacity$  0.03Q� :� $ 
MouseEnter��[��� .���� .��W� $ Opacity�$		 0.3X�:� $ 
MouseLeave��[��� .���� .��W� $ Opacity�$
	 0.03X�.��� .+��� $��1��$��0,0,0,10q�$��2������ 
 �� Path$
 SelectedPhoto.Path��� -    ��Name$
 Prev��$��80��$
��Left=�$��50����� $��2q�$��Center=�$��Center=�
���   � � Points �    -1���  -1����� -   $
 Next��$��Right=�$��80��$��50����� $��2q�$��Center=�$��Center=�
���   � �    -1��� ���