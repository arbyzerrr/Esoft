   M S B A M L   `   `   `  ????@  <esoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:esoftesoft  5          esoft.supplies   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:esoft     5        N? Title$  supplies??5	      .??5      ? ???#fafafa ? RowDefinitions 5   
   ?? 5      $
??199* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridSupplier??5         AutoGenerateColumns .     
IsReadOnly . $??0??6[   $??Verdana)?6h   $??14(?6}      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Цена??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 180* 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *Price+6\     5      $ 
Агент??6%   $	 80* 6P    64   ?? *	AgentId+6^     5      $ Клиент??6%   $	 80* 6R    65   ?? *
ClientId+6`     5      $ Номер района??6%   $
 100* 6Z    6;   ?? *
IdDIstrict+6i   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        DataGridCollumnEdit??$
 auto 5   F   	   CellTemplate	 5      ?? 5      .R?5      ?? $??
buttonEdit??6=   -   5        $ ??Редактировать??5   %   6j   5      5      5       ?? 5!   
   -   5        $??Добавить??5!      $
??Left=?6$   $??8q?6@   $??1??6K   $??Center=?6X   6s   ?? 5"   
   -   5        $??buttonDelete??5"   w   $??Удалить??6   $??Right=?6#   $??8q?6?   $??1??6J   $??Center=?6W   6?   ?? 5#   
   -   5        
 ??Name$
 ComboboxFilter??5#      $??Center=?6+   $??Center=?6F   
???   ?$??40??6x   $	??196??6?   $??1??6?   5$      5%      