   M S B A M L   `   `   `  ����E  AQuizzMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuizzMaker
QuizzMaker  5          QuizzMaker.PageQuestions   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QuizzMaker     5        N� Title$  PageQuestions��5	      $	��400��6    � 	Resources 5
      '   !QuizzMaker.ExistReponsesConverter   ExistReponsesConverter��%   &	          5   
   6'   5      .��5      �� $��	0, 0,10,0q�6   .+�5   
   �� $��	0, 10,2,0q�6   $"��La question à enregistrer :��6$    �� Target 6J   ��  �� ElementName$ txtQuestion���� 5   
   -   5         ��Name$ txtQuestion��5      $��10, 10,2,10q�5       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6<   $��55��6P    �� 	UndoLimit$	 150��6\   $$��Intitulé de votre question...��6m   $��Italic$�5      
�������6%   �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� $��0, 0,2,0q�6   $7��1Les réponses possibles s'affichent à l'écran :��6'    6`   �� $ chkChoixReponse���� 5      -   5        $��chkChoixReponse��5      $��RightToLeft=�6/   $��Center=�6K   5      5      �� 5   
   $ 
Horizontal=�6   .+�5       �� $��0, 0,2,0q�6   $?��9Temps en secondes (0 s'il n'y a pas de durée limitée) :��6(    6j   �� $ txtTemps���� 5!      -   5        $��txtTemps��5!      	 �� 	MaxLength$	 3��6&   $��0,0,0,0q�64   $��30��6E   $��Center=�6P   
 �� TextAlignment$
 Center=�6k   5"      5#      �� 5$   
   $ 
Horizontal=�6   .+�5%      �� $��0, 0,2,5q�6   $1��+Nombre de points que la question rapporte :��6'    6]   �� $ 
txtNbPoint���� 5&      -   5        $��
txtNbPoint��5&   F   $��0,0,0,5q�6X   $��61��6i   $��Center=�6t   $
 Center=�6�   54      �� 55   
   $ 
Horizontal=�6   $��Center=�6.   $��0,0,0,10q�6K   .+�56      �� -   5        $��0,0,5,0q�56      .��6@   	Nouveau6I   �� 57      -   5        $��btnSave��57   "   $	��5,0q�6   .��6L   Enregistrer6Y   �� 58      -   5        $��	btnDelete��58   "   $	��5,0q�6   .��6P   	Supprimer6[   59      �� 5:   
   �� 5;   
   $��	0, 10,2,0q�6   $��Liste des questions :��6$    6D   �� $ lstQuestions���� 5<   
   $ Vertical=�6   .+�5=      �� $ 
Horizontal=�6   .+�5>      �� 
������$��12��61   $��12��6<   
��� � �$
��10,0q�6]   6m   �� 5?      $��WrapWithOverflow=�6   $��Italic$�6<   
�������/-Cette question a une bonne réponse validée.6�   5@      �� 5A      $ 
Horizontal=�6   .+�5B      �� $��12��6   $��12��6$   
��� � �$
��10,0q�6E   
���z���6S   �� 5C      $��WrapWithOverflow=�6   $��Italic$�6<   
�������$��Center=�6a   <:Cette question n'a pas encore une bonne réponse validée.6�   5D      5E      �� 5G   
   -   5        $��lstQuestions��5G   (   $��10, 10,2,10q�6   $��Stretch=�6m   $��91��6�   ��5H      �� 5I      .R�5J      � $	��0,2q�6    � ColumnDefinitions 5K      �� 5L      $��10 �6/   �� 5M      $��* �6/   �� 5N      $��20 �6/   �� 5O      $��20 �6/   .+�5Q      �� ��6$   �� *NumQuestion+�� 5R   "   .�6'   :6,   5S      �� 5T      $��1��6$   $��CharacterEllipsis=�64   ��6U   �� *LibelleQuestion+�� 5U      $��btnUpQuestion��6�   -	   5        
������ 
������ $��2��5U   U   $	��▲��6e   $��9(�6q   $��15��6~   $��15��6�   �� 5V      $��btnDownQuestion��6�   -
   5        
������ 
������ $��3��5V   T   $	��▼��6d   $��9(�6q   $��15��6~   $��15��6�   5W      5X      5Z      5[      5]      