   M S B A M L   `   `   `  ����A  =Apteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Apteka.Pages.ContrApteka.Pages.Contr  5      #    Apteka.Pages.Contr.Spis_Persn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Apteka.Pages.Contr     5      -   5          N� Title$  
Spis_Persn��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $#��Список клиентов��6   $��0��6*   $��30(�5      $��Center=�5      $��Center=�6+   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��70 �6#   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ клиентыDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=�5      $��0��5       ��5   6   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      -   5        код_клиентаColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Код��5"   h   	   
IsReadOnly	 . 
   Width5  /System.Windows.Controls.DataGridLengthConverter$

 1.5* 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Код_клиента+6�     5#      -   5        "наименованиеColumn��$ Наименование��5#   j   $
 5* 6�    6I   �� *Наименование+6�     5$      -   5        адресColumn��$ 
Адрес��5$   \   $
 5* 6k    6B   �� *
Адрес+6k     5%      -   5        телефонColumn��$ Телефон��5%   `   $
 5* 6q    6D   �� *Телефон+6q     5&      -   5        '#контактное_лицоColumn��$# Контактное лицо��5&   p   $
 5* 6�    6L   �� *Контактное_лицо+6�     5'      -   5        emailColumn��$ Email��5'   \   $
 5* 6k    6B   �� *Email+6k   5)      �� 5+      -	   5         ��Name$ 	DeleteBtn��5+      $��1��6(   $��Center=�5,      $��Удалить��5-      6'   5.      5/      50      