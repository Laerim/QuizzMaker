   M S B A M L   `   `   `  ����E  AQuizzMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuizzMaker
QuizzMaker  5   	       QuizzMaker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QuizzMaker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value N� EnterActions	 g� Duration	
 W� To �� TargetProperty	 �� To N� ExitActions��%�  '��       �� 5
   
   " ��6   .�5      ��  � ��
 � ���6+   �� 5       � ��$ 20(�6)    5      P� 5       �@J�IsMouseOver .  5      �� 5      .��5      �� .��5   "   W� $	 	0:0:0.300D�62   $
 30X�6G   $ FontSize�6O   �� 5   "   $	 	0:0:0.300D�61   $ #0cf500X�6F   $* $(Foreground).(SolidColorBrush.Color)�6S   5      5       5      �� 5      .��5      �� .��5   "   W� $	 	0:0:0.150D�62   $
 20X�6G   $ FontSize�6O   �� 5   "   $	 	0:0:0.300D�61   $ YellowX�6F   $* $(Foreground).(SolidColorBrush.Color)�6R   5      5      5!      5#      5%      .��5&      ]� 
���   �.+�5'   
   �� $
��Left=�6   V1.061   � 5(      
���   � � RowDefinitions 5)   
   �� 5*      $��2* �6   �� 5+      $
��Auto �6   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   �� 5.      $
��Auto �6   �� 5/      $��1* �6   .+�51   
   ��  �� TextAlignment$ Center=�6   $��Center=�6,   Quizz Maker6T   �� 52   
   -   5         �� Padding$ 10q�52   C   $ Center=�6P   $��1��6g   Lancer une partie6�   �� 53   
   $ 10q�6   $ Center=�6!   $��2��68   Créer une partie6X   �� 54   
   $ 10q�6   $ Center=�6!   $��3��68   Modifier une partie6Z   �� 55   
   $ 10q�6   $ Center=�6!   $��4��68   	Quitter6N   58      59      5:      