   M S B A M L   `   `   `  ����E  AQuizzMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuizzMaker
QuizzMaker  5          QuizzMaker.PageReponses   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:QuizzMaker     5        N� Title$  PageReponses��5	      $	��425��6   .��5      �� $��	0, 0,10,0q�6   .+�5   
   �� $��	0, 10,2,0q�6   $S��MSélectionnez une question à laquelle vous souaitez ajouter les réponses  :��6$    �� Target 6y   ��  �� ElementName$ txtQuestion���� 5   
    �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� 
������$��12��61   $��12��6<   
��� � �$
��10,0q�6]   6m   �� 5      $��WrapWithOverflow=�6   $��Italic$�6<   
�������/-Cette question a une bonne réponse validée.6�   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��12��6   $��12��6$   
��� � �$
��10,0q�6E   
���z���6S   �� 5      $��WrapWithOverflow=�6   $��Italic$�6<   
�������$��Center=�6a   <:Cette question n'a pas encore une bonne réponse validée.6�   5      5      �� 5   
   -   5        $��lstQuestions��5   (   $��10, 10,2,10q�6   $��Stretch=�6m   $��91��6�   ��5      �� 5      .R�5      � $	��0,2q�6    � ColumnDefinitions 5      �� 5      $��10 �6/   �� 5      $��* �6/   .+�5      �� ��6$   �� *NumQuestion+�� 5    "   .�6'   :6,   5!      �� 5"      $��1��6$   $��CharacterEllipsis=�64   ��6U   �� *LibelleQuestion+5#      5$      5'      �� 5(   
   $��5��6   �� 5)   
   -   5        $��GbxReponses��5)   *   {�.  ��6   Z� .��5*      �� .+�5+      �� $��	0, 10,2,0q�6   $��Réponses :��6,    6A   �� $ 
txtReponse���� 5,      -   5         ��Name$ 
txtReponse��5,      $��10, 10,2,10q�5-       �� AcceptsReturn . $��32��6=    �� 	UndoLimit$	 150��6I   $��Réponse possible...��6Z   $��Italic$�6u   
�������6�   �� 5.      $ 
Horizontal=�6   $��0,0,0,5q�66   .+�5/      �� $��0, 0,2,0q�6   $��Bonne réponse :��6/    6I   �� $ chkBonneReponse���� 50      -   5        $��chkBonneReponse��50       $��RightToLeft=�67   $��Center=�6S   51      52      �� 53      $ 
Horizontal=�6   $��Center=�66   $��0,0,0,10q�6S   .+�54      �� -   5        $��0,0,5,0q�54      .��6G   	Nouveau6P   �� 55      -   5        $��btnSave��55   *   $	��5,0q�6   .��6S   Enregistrer6`   �� 56      -   5        $��	btnDelete��56   *   $	��5,0q�6   .��6W   	Supprimer6b   57      �� 58      -   5        $��
lstReponse��58   0   $��10, 10,2,10q�6   $��Stretch=�6r   $��91��6�   ��59      �� 5:      .R�5;      � $	��0,2q�6#    5<   "   �� 5=   &   $��10 �67   �� 5>   &   $��* �67   �� 5?   &   $��20 �67   �� 5@   &   $��20 �67   .+�5B   "   �� ��6,   �� *Ordre+�� 5C   "   .�6'   :6,   5D   #   �� 5E   "   $��1��6,   $��CharacterEllipsis=�6<   ��6]   �� *LibelleReponse+�� 5F   "   $��btnUpReponse��6�   -	   5        
������ 
������ $��2��5F   ]   $	��▲��6m   $��9(�6y   $��15��6�   $��15��6�   �� 5G   "   $��btnDownReponse��6�   -
   5        
������ 
������ $��3��5G   \   $	��▼��6l   $��9(�6y   $��15��6�   $��15��6�   5H      5I      5L      5M      5N      5Q      5R      