   M S B A M L   `   `   `  ����A  =Apteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Apteka.Pages.ProdsApteka.Pages.Prods  5      #    Apteka.Pages.Prods.Schet_Fact   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Apteka.Pages.Prods     5      -   5          N� Title$  
Schet_Fact��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��Счет-фактуры��6   $��0��6'   $��30(�5      $��Center=�5      $��Center=�6+   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��70 �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$% счет_фактурыDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $��0��5       ��5   6   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        +'Номер_счетфактурыColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��5"   q   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 1.5* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *$"Номер_счет_фактуры+6�     5#      -   5        Код_клиентаColumn��$ Код клиента��5#   d   $
 5* 6y    6D   �� *Код_клиента+6y     5$      -   5        КлиентColumn��$ Клиент��5$   Z   $
 5* 6j    6?   �� *Клиент+6j     5%      -   5        %!Код_сотрудникаColumn��$! Код сотрудника��5%   j   $
 5* 6�    6G   �� *Код_сотрудника+6�     5&      -   5        ТоварColumn��$ 
Товар��5&   X   $
 5* 6g    6>   �� *
Товар+6g     5'      -   5        КоличествоColumn��$ Количество��5'   b   $
 5* 6v    6C   �� *Количество+6v     5(      -	   5        датаColumn��$ Дата��5(   V   $
 5* 6d    6=   �� *
Дата+6d   5*      �� 5,      -
   5         ��Name$ 	DeleteBtn��5,      $��1��6(   $��Center=�5-      $��Удалить��5.      6'   5/      50      51      