   M S B A M L   `   `   `  ????@  <esoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:esoftesoft  5          esoft.demands   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:esoft     5        N? Title$  demands??5	      .??5      ? ???#fafafa ? RowDefinitions 5   
   ?? 5      $
??199* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridSupplier??5         AutoGenerateColumns .     
IsReadOnly . $??0??6[   $??Verdana)?6h   $??14(?6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер клиента??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? *
IdClient+6g     5      $ Номер агента??6%   $	 110 6W    6;   ?? *	IdAgent+6e     5      $ Тип??6%   $	 100 6K    62   ?? *Type+6Y     5      $ 
Адрес??6%   $	 130 6O    64   ?? *Adress+6]     5      $% Минимальная цена??6%   $	 140 6\    6?   ?? *
MinPrice+6j     5      $' !Максимальная цена??6%   $	 140 6]    6@   ?? *
MaxPrice+6k     5      $+ %Минимальная площадь??6%   $	 170 6^    6B   ?? *	MinArea+6l     5      $- 'Максимальная площадь??6%   $	 170 6_    6C   ?? *	MaxArea+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        DataGridCollumnEdit??$
 auto 5   F   	   CellTemplate	 5      ?? 5      .R?5      ?? $??
buttonEdit??6=   -   5        $ ??Редактировать??5   %   6j   5      5"      5$      ?? 5%   
   -   5        $??Добавить??5%      $
??Left=?6$   $??8q?6@   $??1??6K   $??Center=?6X   6s   ?? 5&   
   -   5        $??buttonDelete??5&   w   $??Удалить??6   $??Right=?6#   $??8q?6?   $??1??6J   $??Center=?6W   6?   ?? 5'   
   -   5        
 ??Name$
 TextBoxSearch??5'   -   $?? ??6   
???   ?$??Center=?6D   $??Center=?6_   
???   ?$??40??6?   $	??350??6?    ?? TextWrapping$
 Wrap=?6?   $??20(?6?   $??Verdana)?6?   $??1??6
  5(      5)      