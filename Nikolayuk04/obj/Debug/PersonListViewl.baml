   M S B A M L   `   `   `  ����  Nikolayuk04&     Nikolayuk04.Views.PersonListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      
�������.��5      �   � RowDefinitions  5	   
   �� 5
      $��0.85* �6   6-   �� 5      $��0.15* �6   6-    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      $��0.85* �6   6/   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��Persons��5      $��0��6#   $��0��60   $��3��6@      
IsReadOnly .    SelectionMode$ Single=�6�      AutoGenerateColumns .   �� SelectedItem 6T   �� *SelectedItem+��6z   �� *	Persons+ �� Mode$ OneWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *Name+$ TwoWay=�6[     5      $ 	Last name��6%   	 68   �� *
LastName+$ TwoWay=�6d     5      $ Birthday��6%   	 67   �� *
Birthday+
 �� StringFormat$
 
dd/MM/yyyy��$ TwoWay=�6     5      $ E-mail��6%   	 65   �� *Email+$ TwoWay=�6^     5      $ Is adult��6%   	 67   �� *	IsAdult+6U     5      $ Is birthday��6%   	 6:   �� *
IsBirthday+6[     5      $ Sun sign��6%   	 67   �� *	SunSign+6U     5      $ Chinese sign��6%   	 6;   �� *ChineseSign+6]   5      �� 5   
   $��1��6   $��0��6   $��14q�6.   $��Insert��6:   �� 5    
   $��1��6   $��1��6   $��14q�6.   $��Delete��6:   �� 5!   
   $��1��6   $��2��6   $��14q�6.   $��Update��6:   �� 5"   
   $��1��6   $��3��6   $��14q�6.   $��Close��6:   � 5#   
   $��0��6   $��3��6     5$      �� 5%      6"   �� 5&      $
��0.6* �6    60   �� 5'      $
��auto �6    60   �� 5(      $
��0.7* �6    60   �� 5)      $
��0.6* �6    60   �� 5*      $
��0.6* �6    60   .+�5,      �� $��14q�6   $��Center=�6#   $	��Top=�6@   $��0��6�   $	��120��6�   $��30��6�    6X   �� *SelectedProperty+.@�5-      �� $
��Name��6   60   �� 5.      $��	Last name��6   65   �� 5/      $��Birthday��6   64   �� 50      $��Email��6   61   �� 51      $��Is adult��6   64   �� 52      $��Is birthday��6   67   �� 53      $��Sun sign��6   64   �� 54      $��Chinese sign��6   68   55      �� 56      $��1��6   $��14q�6"   $
��Sort��6.   �� 57      $��2��6   $��14, 10q�6%   $��Stretch=�65   $��
Filter by:��6S   �� 58      $��3��6   $��14, 15q�6#   ��63   �� *Query+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 59      $��4��6   $��14q�6"   $��Filter��6.   �� 5:      $��5��6   $��14q�6"   $��Reset filters��6.   5;      5?      5@      