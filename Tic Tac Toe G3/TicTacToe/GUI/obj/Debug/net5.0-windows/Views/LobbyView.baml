   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GUI.Views	GUI.Views  5   	       GUI.Views.LobbyView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GUI.Views     5   	   -   5          � Title$  	LobbyView��5   	   $	��500��6   $	��700��6(    � 
ResizeMode$ NoResize=�64   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��109 �6   6-   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   ��    	TicTacToe#��[  6   $��4��63   �� 5   
   $��X��6   $��1��6   $��1��6*     LabelOptions#��[ 6:   �� 5   
   $��O��6   $��1��6   $��3��6*   #��[ 6:   �� 5   
   $��VS��6   $��2��6   $��2��6*   #��[ 6:   �� 5   
   $��Player 1��6   $��2��6$   $��1��61     PlayerLabel#��[ 6A   �� 5   
   $��Player 2��6   $��2��6$   $��3��61   #��[ 6A   �� 5   
   -   5         ��Name$ player1��5      $��3��6@   $��1��6M   $��Stretch=�6]   $��Center=�6{   $��Comic Sans MS)�6�   $��28(�6�   �� 5    
   -   5        $ player2��5       $��3��6@   $��3��6M   $��Stretch=�6]   $��Center=�6{   $��Comic Sans MS)�6�   $��28(�6�   �� 5!   
   -   5        $
��Back��5!      $��4��6    $��1��6-     OptionsButton#��[ 6Q   �� 5"   
   -   5        $��Start��5"      $��4��6!   $��3��6.   #��[ 6S   5#      5$      