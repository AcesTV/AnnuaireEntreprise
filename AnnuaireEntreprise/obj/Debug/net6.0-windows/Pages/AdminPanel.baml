   M S B A M L   `   `   `  ����M  IAnnuaireEntreprise, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:AnnuaireEntreprise.PagesAnnuaireEntreprise.Pages  5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466J6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPFFontAwesome.WPF 5   	   )    #AnnuaireEntreprise.Pages.AdminPanel   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:AnnuaireEntreprise.Pages     5   	   Efa6clr-namespace:FontAwesome.WPF;assembly=FontAwesome.WPF     5   	     � Title$  
AdminPanel��5	   	   $	��450��6   $	��800��6)    � WindowState$ 	Maximized=�5
   	   .��5      � ���	#FFDDEEFF.+�5   
   �� -   5        $��Right=�5      $	��Top=�6-   $��25��6Z   $��25��6e   $��	0,10,20,0q�6q   .��5      "  FontAwesome.WPF.ImageAwesome     Icon$ Close=�6   $��20��6+   $��20��66   6D   5      �� 5   
   $	��Top=�6   $��Center=�6-    �� Orientation$ 
Horizontal=�6J   $��0,10,0,0q�6c   .+�5        $ Gears=�6   $��50��6+   68   �� 5      $��Page d'administration��6   $��Center=�65   $��Center=�6R   $��30(�6m   $
��Bold"�6{   $��Italic$�6�   $��15,0,0,0q�6�   6�   5      �� 5   
   $��0,51,0,0q�6   .@�5      �� $��	Employés��6   
�������.��5      � 
�������.+�5      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $��44��6m   .+�5      �� -   5        
�������$��Nouveau��5   :   $
��Left=�6d   $��Center=�6   $��20,0,0,0q�6�   $��	10,1,10,1q�6�    � IsSharedSizeScope$
 True��6�   �� 5      -   5        
�������$��Modifier��5   :   $
��Left=�6f   $��Center=�6�   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   $
 True��6�   �� 5      -   5        
�������$��	Supprimer��5   :   $
��Left=�6f   $��Center=�6�   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   $
 True��6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ salarieList��5          AutoGenerateColumns$ False��65   $��0,44,0,0q�6Q   
������� � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5      "  6$   .�5   "   -   5        5      5       	   Columns	 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��61      
IsReadOnly$
 True��6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Id+6T     5#      $	
 Nom��61   $
 True��6V    6>   �� *Nom+6V     5$      $
 Prénom��61   $
 True��6\    6A   �� *Prenom+6\     5%      $
 Email��61   $
 True��6Z    6@   �� *Email+6Z     5&      $
 Téléphone Fixe��61   $
 True��6e    6I   �� *	TelFixe+6e     5'      $
 Téléphone Portable��61   $
 True��6m    6M   �� *TelPortable+6m     5(      $
 Ville��61   $
 True��6_    6@   �� *
Site.Ville+6_     5)      $
 Service��61   $
 True��6c    6B   �� *Services.Nom+6c   5,      5.      5/      �� 50      $��Villes��6   
�������.��51      � 
������� � ColumnDefinitions 52      �� 53      $	��29* �6+   �� 54      $
��765* �6+   .+�56      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $��44��6m   $��2��6y   .+�57      �� -   5        
�������$��Nouveau��57   :   $
��Left=�6a   $��Center=�6|   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   �� 58      -   5        
�������$��Modifier��58   :   $
��Left=�6c   $��Center=�6~   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   �� 59      -	   5        
�������$��	Supprimer��59   :   $
��Left=�6c   $��Center=�6~   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   5:        5;      -
   5        $ 	sitesList��5;       $ False��63   $��0,44,0,0q�6O   
�������$��2��6x   	 5<        5=      $
 Id��61    6=   �� *Id+  5>      $
 Ville��61    6@   �� *Ville+5@      5B      5C      �� 5D      $��Services��6   
�������.��5E      � 
�������.+�5F      �� $ 
Horizontal=�6!   $
��Left=�6:   $	��Top=�6U   $��44��6m   .+�5G      �� -   5        
�������$��Nouveau��5G   :   $
��Left=�6d   $��Center=�6   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   �� 5H      -   5        
�������$��Modifier��5H   :   $
��Left=�6f   $��Center=�6�   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   �� 5I      -   5        
�������$��	Supprimer��5I   :   $
��Left=�6f   $��Center=�6�   $��20,0,0,0q�6�   $��	10,1,10,1q�6�   5J        5K      -   5        $ servicesList��5K       $ False��66   $��0,44,0,0q�6R   
�������	 5L        5M      $
 Id��61    6=   �� *Id+  5N      $	
 Nom��61    6>   �� *Nom+5P      5R      5S      5T      5V      5W      