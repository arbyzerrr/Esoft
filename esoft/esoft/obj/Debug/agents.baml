   M S B A M L   `   `   `  ????@  <esoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:esoftesoft  5          esoft.agents   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:esoft     5        N? Title$  agents??5	      .??5      ? ???#fafafa ? RowDefinitions 5   
   ?? 5      $
??199* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridAgent??5         AutoGenerateColumns .     
IsReadOnly . $??0??6X   $??Verdana)?6e   $??14(?6z      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   ?? *	FirstName+6`     5      $ Имя??6%   $	 110 6Q    62   ?? *
MiddleName+6_     5      $ Отчество??6%   $	 150 6T    67   ?? *
LastName+6b     5      $ Доля сделок??6%   $	 130 6X    6:   ?? *	DealShare+6f   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      ?? 5      .R?5      ?? 
 ??Name$
 BtnEdit??6%   -   5        $ ??Редактировать??5   6   6f   5      5      5'      ?? 5(   
   -   5        $
 BtnAdd??5(      $??Добавить??6!   $
??Left=?64   $??1??6O   $??Center=?6\   $??5,0,0,0q?6?   ?? 5)   
   -   5         ??Name$ TextBoxSearch??5)   -   $?? ??6   
???   ?$??Center=?6D   $??Center=?6_   
???   ?$??40??6?   $	??350??6?    ?? TextWrapping$
 Wrap=?6?   $??20(?6?   $??Verdana)?6?   $??1??6o  ?? 5*   
   -   5        $
 	BtnDelete??5*      $??Удалить??6$   $??Right=?66   $??1??6R   $??Center=?6_   $??0,0,5,0q?6?   5+      5,      