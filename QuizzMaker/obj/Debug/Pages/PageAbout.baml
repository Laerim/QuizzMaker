   M S B A M L   `   `   `  ����E  AQuizzMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuizzMaker
QuizzMaker  5          QuizzMaker.PageAbout   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QuizzMaker     5        N� Title$  	PageAbout��5      $	��325��6   $	��400��6%   .��5
      �� .+�5   
   �� $��
0, 10,10,0q�6   $��_Nom de votre jeu :��6%    �� Target 6C   ��  �� ElementName$ txtName���� 5   
   -   5        $��txtNom��5   '   $��10, 10,10,0q�6   $��Italic$�5      
�������.��67   Nom6<   �� 5   
   $��
0, 10,10,0q�6   $��_Date de votre jeu :��6%    6D   �� $ 	dpJourJeu��(  "System.Windows.Controls.DatePicker  5   
   -   5        $��	dpJourJeu��5      $��10, 10,10,10q�6&      SelectedDateFormat$ Short=�6<      IsTodayHighlighted . 6W   �� 5   
   6   �� 5   
   
�������$��Italic$�6&   31Vous n'êtes pas obligé de remplir cette partie.5      �� 5   
   $��Décrivez votre jeu :��6    6/   �� $ txtDescription���� 5   
   -   5        $��txtDescription��5       $��10, 10,10,10q�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6>   $	��104��5      $��Italic$�66   
�������.��6\   Description5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��0, 0,2,0q�6   $%��Ordre des question aléatoire :��6'    6P   �� $ chkChoixReponse���� 5      -   5        $��	chkRandom��5   ,   $��0, 10,10,10q�6   $��RightToLeft=�6=   $��Center=�6Y    � ToolTip$b \Les questions qui seront déroulées lors de la parties seront posées de façon aléatoires��6t   5      5      �� 5   
   -   5        $��SaveQuestionnaire��5      $��Enregistrer��6J   $��30��6`   $	��175��6l   $
��70,0q�6x   6�   5      5       