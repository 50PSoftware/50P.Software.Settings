   M S B A M L   `   `   `  ���� X  T50P.Software.Settings.Dialogs, Version=1.2.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_50P.Software.Settings.Dialogs_50P.Software.Settings.Dialogs  3    -_50P.Software.Settings.Dialogs.SettingsDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:_50P.Software.Settings.Dialogs     -     � Title$  
Nastavení��$	��256��$	��800�� � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ CanMinimize=� � WindowStyle$ 
ToolWindow=�.���  � RowDefinitions �� $
��200* ��� $	��56* � � ColumnDefinitions �� $
��127* ��� $
��270* �.+��� -    ��Name$ gpToS��$ ��Typ datového úložiště��$��	10,10,0,0q�$
��Left=�$	��222��$	��103��$	��Top=�.��� $	��Top=�$
��Left=�.+��� -    ��Name$ label��$	��Typ��$
��Left=�$��	10,10,0,0q�$	��Top=�$��2���� -    ��Name$ comboBox��$
��Left=�$��	10,41,0,0q�$	��Top=�$	��120��$��2��.@��� $��Soubor���� $��	Databáze���� -   	 ��Name$	 btnOk��$��Ok��$��	0,0,10,10q�$��1��$��Right=�$��82��$��26��$��Bottom=�$��1��� -   
 �Name$
 gridFile��$��1��$
��Left=�$	��103��$��	10,10,0,0q�$	��Top=�$	��520��$y�Visible=�.+��� -   $	 	btnBrowse��$��
Procházet��$��	0,13,10,0q�$	��Top=�$��23��$��Right=�$��75���� -   $ label2��$��Cesta k souboru:��$��	10,10,0,0q�$	��Top=�$
��Left=�$	��106��$��26���� -	    ��Name$ tbPath��$��23��$��121,13,90,0q� �� TextWrapping$
 Wrap=�$	��Top=��� -
   $	 btnNew��$��Nový��$
��Left=�$��
435,48,0,0q�$	��Top=�$��75��� -   $
 gridDatabase��$��1��$
��Left=�$	��103��$��	10,10,0,0q�$	��Top=�$	��520��$y�Hidden=� �� $	��52* ��� $	��51* � �� �� .+��� -   $ tbDatabaseName��$��23��$��	0,13,10,0q�$
 Wrap=�$	��Top=�$��Right=�$	��138��4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . �� -   $ label1��$��Název databáze:��$
��Left=�$��	10,10,0,0q�$	��Top=�$��26��$��97���� -   $ label3��$��Název serveru:��$
��Left=�$��	10,10,0,0q�$	��Top=�$��1��$��26��$��87���� -   $ tbServerName��$��23��$��	0,13,10,0q�$
 Wrap=�$	��Top=�$��1��$��Right=�$	��148�� . �� -   $ label4��$��Uživatelské jméno:��$
��Left=�$��	10,10,0,0q�$	��Top=�$��26��$��1��$	��108���� -   $ 
tbUsername��$��23��$��	0,13,10,0q�$��1��$
 Wrap=�$	��Top=�$��Right=�$	��120�� . �� -   $ label5��$��Heslo:��$��1��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�G� -    G�Name$ 
tbPassword��$��1��$��23��$��
57,13,10,0q�$��1��$	��Top=� . �� -   $	 btnOtherOptions��$��Ostatní nastavení��$
��Left=�$��	10,10,0,0q�$��1��$	��Top=�$	��234��$��30���� -   $	 btnResetSettings��$��Resetovat nastavení��$��1��$
��Left=�$��
228,14,0,0q�$��1��$	��184��$��26��$	��Top=�