   M S B A M L   `   `   `  ����A  =Notest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NotestNotest  5   	       Notest.MyResults   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Notest     5   	     � Title$  	MyResults��5   	   $	��300��6   $	��600��6(    � WindowStartupLocation$ CenterScreen=�64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��
ResultGrid��5
   0   $��2��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6       AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�6^   $   HorizontalScrollBarVisibility$
 Auto=�5         
IsReadOnly . $��0,0,-0.8,-0.4q�6J   $��2��6a      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       	  topic,  &System.Windows.Controls.DataGridColumn   Header# �   6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� *	TestTheme+6C     5       
 header# �  6B   	 6%   �� *
TestName+6B     5      
   Width$
 84 6%    
 result# �  6K   	 60   �� *Result+6K     5      $	
 120 6%     date# �  6J   	 61   �� *Date+6J   5      5      5      