   M S B A M L   `   `   `  ����M  IAnnuaireEntreprise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:AnnuaireEntreprise.Pages.SalarieViews%AnnuaireEntreprise.Pages.SalarieViews  5   	   6    0AnnuaireEntreprise.Pages.SalarieViews.AddSalarie   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:AnnuaireEntreprise.Pages.SalarieViews     5   	     � Title$  
AddSalarie��5   	   $	��450��6   $	��400��6)   $	��450��65   $	��400��6E   $	��450��6T   $	��400��6d   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   $��Center=�6I   .+�5      �� $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5      �� $��Nom: ��6   $��	0,10,0,10q�6)   �� 5      -   5         ��Name$
 Inom��5      $	��266��6(   $��	0,10,0,10q�64   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5      �� $��	Prénom: ��6   $��	0,10,0,10q�6,   �� 5      -   5        $ Iprenom��5      $	��252��6+   $��	0,10,0,10q�67   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5      �� $��Email: ��6   $��	0,10,0,10q�6+   �� 5      -   5        $ Iemail��5      $	��264��6*   $��	0,10,0,10q�66   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5      �� $��Téléphone Portable: ��6   $��	0,10,0,10q�68   �� 5      -   5        $ ItelPort��5      $	��191��6,   $��	0,10,0,10q�68   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5      �� $��Téléphone Fixe: ��6   $��	0,10,0,10q�64   �� 5      -   5        $ ItelFixe��5      $	��214��6,   $��	0,10,0,10q�68   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5       �� $��	Service: ��6   $��	0,10,0,10q�6-   �� 5!      -   5         ��Name$ serviceChoice��5!      $	��257��62   $��	0,10,0,10q�6>    �� DisplayMemberPath$	 Nom��6Q    �� SelectedValuePath$ Id��6i   5"      �� 5#      $ 
Horizontal=�6   $��Center=�62   $	��300��6O   .+�5$      �� $��Site: ��6   $��	0,10,0,10q�6*   �� 5%      -   5        $ 
siteChoice��5%      $	��274��6/   $��	0,10,0,10q�6;   $ Ville��6N   $ Id��6h   5&      5'      �� 5(   
   $ 
Horizontal=�6   $��Right=�6.   $��0,329,50,21q�6J   $	��158��6_   .+�5)      �� -   5         ��Name$ btn_Valider��5)   @   
�������$��Valider��6.   $��30��6U   $��5,1,5,1q�6{    � IsSharedSizeScope$
 True��6�   �� 5*      -	   5        $ btn_Annuler��5*   @   
�������$��Annuler��6.   $��30��6U   $��20,0,0,0q�6{   $��5,1,5,1q�6�   $
 True��6�   5+      5,      5-      