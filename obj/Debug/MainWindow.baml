   M S B A M L   `   `   `  ����  Assignment3    Assignment3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$$  AVI and MP3 Player by Tim Osse��5   	   $	��350��60   $	��600��6=    � 	Resources 5         ListViewItemStyleEvent �� 
TargetType��%E   &	        �� 5   
   " ��6/   .�5      -   5        5	      5
      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��stackPanel1��5       �� Orientation$ Vertical=�6(   $��0��6?   $��0��6L   $	��Top=�6\   .+�5      �� -   5        $��openFile��5      $��30��6%   $��75��61   .��6S   
Open Files6_   �� 5      -   5        $��openList��5      #���   6'   $��0��6e   $��0��6r   6�   5      r� 5   
   -   5        $��player��5       r� LoadedBehavior$ Manual=�6%    r� UnloadedBehavior$
 Stop=�6=   $��0��6U   $��1��6b   6u   �� 5   
   -   5        $��label��5      $��1��6   $��0��6*   .��6:   File being played:6N   �� 5    
   -   5        $��stackPanel2��5       $ 
Horizontal=�6(   $��1��6A   $��1��6N   $��Center=�6^   .+�5!      �� -   5        $
��Stop��5!      $��30��64   $��75��6@   $
��Left=�6K   $	��Top=�6f   .��6~   Stop6�   �� 5"      -	   5        $
��Play��5"      $��30��64   $��75��6@   $��Right=�6K   $	��Top=�6g   .��6   Play6�   �� 5$      -
   5        $
��Back��5$      $��30��64   $��75��6@   $
��Left=�6K   $	��Top=�6f   .��6~   
Previous6�   �� 5%      -   5        $��Forward��5%      $��30��6:   $��75��6F   $��Right=�6Q   $	��Top=�6m   .��6�   	Forward6�   5&      5(      5*      