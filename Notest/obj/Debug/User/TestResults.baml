   M S B A M L   `   `   `  ����A  =Notest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NotestNotest  5   	       Notest.TestResults   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
    localclr-namespace:Notest  5   	     � WindowStyle$
  None=�5	   	    � AllowsTransparency .  � Title$ Notest��5
   	   $	��350��6   $	��620��6%    � Icon$ ../ico/main.ico��61    � 	Resources 5         ds �� 
TargetType �� Property �� Value  OpenDoor �� Triggers��%�   &	        &	 L     �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   5      �� 5   
    5      :� 5      5      5      .��5      (� 	 (� Stretch$
	 Fill=�6   .��5   
   � 
 � RowDefinitions
 5      �� 5      $��25 �6    �� 5      $��50 �6    �� 5      $	��250 �6    .+�5      � $��0��6   ���#373940.+�5      �� -   5        $��45��5      $
��Auto��6$   $��Right=�5      $��0 0 80 0q�5      ��5       Z� ��5!      Z� .��5$      �� $��..\ico\minimize.png��6   $��25��5%   .   $��25��69   $��Center=�5&   .   $��0 -7 0 0q�5'   .   5)      �� 5*      -   5        $��
Fullscreen��5*      $��45��5+      $
��Auto��6$   $��Right=�5,      $��0 0 40 0q�5-      ��5.      Z� ��5/      Z� .��51      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ 
Fullscreen=�6.   $��25��52   .   $��20��69   $��Center=�53   .   54      �� 55      -   5        $��FullscreenExit��55      $��45��56      $
��Auto��6$   $��Right=�57      $��0 0 40 0q�58      $y�Hidden=�59      ��5:      Z� ��5;      Z� .��5=        $ FullscreenExit=�6.   $��25��5>   .   $��20��69   $��Center=�5?   .   5@      �� 5A      -   5        $��43��5A      $
��Auto��6$   $��Right=�5B      ��5C      Z� ��5D      Z� .��5F        $ WindowClose=�6.   $��27��5G   .   $��21��69   $��Center=�5H   .   $��Center=�5I   .   5K      5L      �� 5M      $��1��6    �� Orientation$ 
Horizontal=�6'   ���#373940.+�5N      �� $��../ico/book.ico��6   $��55��5O      $��45��6'   $��15 0 0 0q�5P      �� 5Q      -   5         ��Name$ 	UserLogin��5Q      $��
15,20,0,10q�5R      ���#e3e0de$	��140��5T      $��20(�5U      5V      5W      &   System.Windows.Controls.DataGrid  5X      -   5        $��
ResultGrid��5[      $��2��5X      $	��780��5Y         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5Z         AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     AlternatingRowBackground �#a3a6af"   VerticalScrollBarVisibility$
 Auto=�5_      $   HorizontalScrollBarVisibility$
 Auto=�5`         
IsReadOnly . $��Medium"�5b         SelectionMode$ Single=�5c         FrozenColumnCount$ 5��5d      $��0,0,-1,0q�5e         Columns 5f      0  *System.Windows.Controls.DataGridTextColumn  5g      ,  &System.Windows.Controls.DataGridColumn   Width$ * 6)    	 login   Header# �  5i   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5h   )   �� *	UserLogin+5i   )     5j       	 topic# �  6G    6)   �� *	TestTheme+6G     5k       
 header# �  6F    6)   �� *
TestName+6F     5l      $ * 6)    
 result# �  6N    63   �� *Result+6N     5m      $ * 6)     date# �  6L    63   �� *Date+6L   5o      5p      5q      5r      