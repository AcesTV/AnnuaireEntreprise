   M S B A M L   `   `   `  ����M  IAnnuaireEntreprise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AnnuaireEntrepriseAnnuaireEntreprise  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466J6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPFFontAwesome.WPF 5   	   #    AnnuaireEntreprise.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AnnuaireEntreprise     5   	   Efa6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPF     5   	     � Title$  Annuaire entreprise��5	   	   $	��800��6%   $
��1500��65    � WindowState$ 	Maximized=�6E    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5        #   AnnuaireEntreprise.MainWindow
   cmd   Command# Z 5      6C   .��5      � ���	#FFDDEEFF.+�5   
   �� $��Center=�6   $	��Top=�62    �� Orientation$ 
Horizontal=�6J   $��0,10,0,0q�6c   .+�5      "  FontAwesome.WPF.ImageAwesome     Icon$
 Book=�6   $��50��6*   67   �� 5      $��Annuaire d'entreprise��6   $��Center=�65   $��Center=�6R   $��30(�6m   $
��Bold"�6{   $��Italic$�6�   $��20,0,0,0q�6�   6�   5      �� 5   
   $ 
Horizontal=�6   $	��Top=�6.   $��0,64,0,0q�6F   $��33��6X   .+�5      �� -   5         ��Name$ 
villeChoix��5      $	��200��6+    �� DisplayMemberPath$ Ville��67   	 �� SelectedValuePath$	 Id��6Q   
 �� SelectedValue$
 0��6h   5      �� 5      -   5        $ serviceChoix��5      $	��200��6-   $	 Nom��69   $	 Id��6Q   $
 0��6h   5      �� 5      -   5         ��Name$ searchInput��5   "   $	��250��6   6:   �� 5      -   5        $��50��5   *   
�������.��5        $ Search=�6"   $��15��60   $��15��6;   6I   5      �� 5      -   5        $��20,0,0,0q�5   0   
�������$��	10,1,10,1q�6[   .��5      �� $
��Bold"�6   Reset la recherche6B   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��salariesList��5         AutoGenerateColumns$ False��6'   $��0,97,0,0q�6C   
������� � 	Resources 5       )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5!      "  6   .�5"      -   5        5#      5$         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nom��6%      
IsReadOnly$
 True��6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nom+6J     5'      $ Prénom��6%   $
 True��6P    65   �� *Prenom+6P     5(      $ Email��6%   $
 True��6N    64   �� *Email+6N     5)      $ Téléphone Fixe��6%   $
 True��6Y    6=   �� *	TelFixe+6Y     5*      $ Téléphone Portable��6%   $
 True��6a    6A   �� *TelPortable+6a     5+      $ Ville��6%   $
 True��6S    64   �� *
Site.Ville+6S     5,      $ Service��6%   $
 True��6W    66   �� *Services.Nom+6W   5.      �� 5/   
   50      52      