   M S B A M L   `   `   `  ����G  CWpfApp2Polak, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp2PolakWpfApp2Polak  5   	       WpfApp2Polak.mainwindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp2Polak     5   	   -   5          �Name$  dsdsaads��5   	    � Title$ Duck Shooter��5	   	   $	��450��6   $	��800��6+   .��5
      � -   5        ��5   
   �� 5       �� ImageSource$ Resources/Aero_Grass.jpg��6    � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5       � RowDefinitions 5   
   .+�5   
   �� -   5         ��Name$ Counter��5      $��	Counter:0��6!   $
��Bold"�65   $��30(�6G   $
��Left=�6U   
�������$��3,10,0,0q�6�   $	��Top=�6�   $��50��6�   $	��270��6�   $��1��6�   �� 5   
   -   5         ��Name$ Duck1��5      $	��120��6   $��
667,10,0,0q�6,   $	��125��6@   $	��Top=�6L   $
��Left=�6d   $��Resources/duck.png��6   $��1��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   �� 5   
   -   5        $ Duck2��5      $	��120��6   $��317,139,0,0q�6,   $	��125��6A   $	��Top=�6M   $
��Left=�6e   $��Resources/duck.png��6�   $��1��6�   $ 0.5,0.5&�6�   5       �� 5"   
   -   5        $ Duck3��5"      $	��120��6   $��802,277,-135,0q�6,   $	��125��6D   $	��Top=�6P   $
��Left=�6h   $��Resources/duck.png��6�   $��1��6�   $ 0.5,0.5&�6�   �� 5$   
   -   5        $ GunSight��5$      $	��100��6#   $	��100��61   $��Resources/target.png��6=   $��	73,75,0,0q�6[   $	��Top=�6o   $
��Left=�6�   $��2��6�   $��UniformToFill=�6�   5&      5'      