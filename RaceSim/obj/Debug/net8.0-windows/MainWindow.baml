   M S B A M L   `   `   `  ����B  >RaceSim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RaceSimRaceSim  5   	       RaceSim.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:RaceSim     5   	     � Title$#  Симулятор гонок��5   	   $	��168��6!   $	��411��6.    � 
ResizeMode$ NoResize=�6:   .��5	      �  � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ vehicleChoiceList��5      $��164,10,10,10q�6X    �� SelectionMode$ Multiple=�6n   �� 5   
   -   5         ��Name$ racesChoiceBox��5      $
��Left=�6+   $��	20,10,0,0q�6F   $	��Top=�6Y   $	��120��6q   6}   �� 5   
   -   5         ��Name$ startBtn��5      $��Начать гонку ��6#   $
��Left=�5      $��	40,99,0,0q�6   $	��Top=�61   4  .System.Windows.Automation.AutomationProperties   Name$  ��6I   6f   �� 5   
   -   5        	 ��Name$	 distanceField��5      $
��Left=�6)   $��	20,62,0,0q�6D   
 �� TextWrapping$

 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��120��6�   �� 5   
   $
��Left=�6   $��	20,46,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $	��120��6n   �� 6{    � Language$ ru-ru�6   $�Дистанция��6�   6�   5      5      