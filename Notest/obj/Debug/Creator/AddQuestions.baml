   M S B A M L   `   `   `  ����A  =Notest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NotestNotest  5   	       Notest.AddQuestions   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	    localclr-namespace:Notest  5   	   $	��400��5	   	   $	��300��6     � Icon$  ..\ico\main.ico��6$    � WindowStyle$
 None=�5
   	    � AllowsTransparency . ��5      �� 5   
    �� ImageSource$ ..\picture\6.jpg��6   .��5      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      .+�5   
   � $��0��6   ���#535e66.+�5      �� -   5        $��43��5      $
��Auto��6    $��Right=�5         CloseButton#��[  5      ��5      Z� ��5      Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�6*   $��27��5   .   $��21��69   $��Center=�5   .   $��Center=�5   .   5      5       (� 5!   
    (� Stretch$ Uniform=�6   .��5"      �� -   5        $��QuestionList��5"      $��1��6/   ��5#      �� 5$      .R�5%      ��  ��Name$ Border��6!    �� Padding$ 8q�61   $��0 0 0 1q�5&        MaterialDesignDivider#���  5'      ._�5(      � 	 � ColumnDefinitions	 5)   "   �� 5*   &   $��60 �67   
 z� SharedSizeGroup$
 Checkerz��5+   %   �� 5,   &   $	��190 �68   .+�5.   "   d� -   5        $��Center=�5.   /    ) %MaterialDesignActionLightToggleButton#��[ 5/   3    d� 	IsChecked 5.   J   �� *
IsSelected+��50   3   �� *Code+
 � Tag 51   3   �� 52   3   �� 53   "   $��8 0 0 0q�6-   $��1��6>   .+�54   &   �� $
��Bold"�60   $
��Wrap=�56   ,    55   -   �� ��57   ,   �� *	Question1+58   #   5:      5<       �� Triggers 5>      �� 5@       �� Value$
 True��6I    �� Binding 6*   �� *
IsSelected+.a�5B   "   ��  �� 
TargetName$ Border��6)     MaterialDesignSelection �� Value# �  6S    �� Property � ��5D      5H      5L      5N      �� 5P   
   -   5        $��FindTestButton��5P      $��1��6   $��74��5Q      $��25��6   ���#535e66$��Right=�5S      $��Bottom=�5T      $��	0,0,25,25q�5U      ���#e3e0de 
 select#���  5W      $��10(�5X      5Y      5Z      5[      