   M S B A M L   `   `   `  ����A  =Albums, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Albums.ViewsAlbums.Views  5   	   -clr-namespace:Albums.ModelsAlbums.Models  5	   	       Albums.Views.PhotoView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Albums.Views     5   	   $mwViews\MainWindow.xaml     5   	   .modelsclr-namespace:Albums.Models     5	   	     � Title$  	PhotoView��5
   	   $	��450��6   $	��800��6(   
���   � � 	Resources 5       �� 
TargetType   UsersElement �� BasedOn �� Property �� Value �� Triggers :� RoutedEvent �� TargetProperty		 W� To��%�  '��       7   �� 5      " ��6   8   .�5      ��  � ��
 �����6+   �� 5       �@J�Opacity$  0.03Q�6(    5   
   :� 5      $ 
MouseEnter��6   [�5      �� 5      .��5      �� .��5   "   W� $ Opacity�63   $		 0.3X�6W   5      5      5      :� 5      $ 
MouseLeave��6   [�5      �� 5      .��5       �� .��5!   "   W� $ Opacity�62   $
	 0.03X�6W   5"      5#      5%      5'      5(      .��5)      � .+�5,   
   �� $��1��6   $��0,0,0,10q�6L   $��2��6^   ��6!   �� 
 �� Path$
 SelectedPhoto.Path�6^   �� 5-   
   -   5         ��Name$
 Prev��5-      $��80��6   $
��Left=�6>   $��50��6Y   ��5.      � 50      $��2q�51      $��Center=�52      $��Center=�53      
���   � � Points �    -1���  -1���55      58      �� 59   
   -   5        $
 Next��59      $��Right=�6   $��80��6>   $��50��6J   ��5:      � 5<      $��2q�5=      $��Center=�5>      $��Center=�5?      
���   � �    -1��� ���5A      5D      5E      5F      