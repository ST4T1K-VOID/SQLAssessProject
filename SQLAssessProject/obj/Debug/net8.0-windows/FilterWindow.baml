   M S B A M L   `   `   `  ����E  ASQLproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SQLproject
SQLproject  5   	       SQLproject.FilterWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SQLproject     5   	     � Title$  FilterWindow��5   	   $	��251��6   $	��686��6+   ���	#FFEEF5FF.��5	      � .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   $��Center=�6F   $��0,23,0,0q�6c   .+�5      �� $ Vertical=�6   $	��132��60   .+�5      �� $��FILTER OPTIONS��6   $��Black"�61   ���	#FF03073E6D   �� 5      -   5         ��Name$ check_byName��5      $��By Name��61   $
��Bold"�6b   $��14(�6t   $��Center=�6�   ���	#FF03073E6�   �� 5      -   5        $ check_bySalary��5      $��	By Salary��63   $
��Bold"�6h   $��14(�6z   $��Center=�6�   ���	#FF03073E6�   �� 5      -   5        $ check_byBranch��5      $��By Branch ID��63   $
��Bold"�6k   $��14(�6}   $��Center=�6�   ���	#FF03073E6�   5      �� 5      $ Vertical=�6   $��20,10q�60   $	��475��6?   $	��131��6K   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��FIRST NAME:��6   $��Black"�62   ���	#FF03073E6E   �� 5      -   5         ��Name$ textbox_firstName��5      $	��150��69   ���	#FF1B5E75$��Center=�6]   �� 5      $��
LAST NAME:��6   $��Black"�61   ���	#FF03073E6D   �� 5      -   5        $ textbox_LastName��5      $	��150��68   ���	#FF1B5E75$��Center=�6\   5      �� 5      $ 
Horizontal=�6   $��0,10,0,0q�66   $
��Left=�6H   .+�5      �� $��
MIN RANGE:��6   $��Black"�61   ���	#FF03073E6D   �� 5      -   5        $ textbox_minRange��5      $	��100��68   ���	#FF1B5E75$��Center=�6\   �� 5      $��
MAX RANGE:��6   $��Black"�61   ���	#FF03073E6D   �� 5      -   5        $ textbox_maxRange��5      $	��100��68   ���	#FF1B5E75$��Center=�6\   5!      �� 5"      $ 
Horizontal=�6   $
��Left=�66   $��0,10,0,0q�6Q   .+�5#      �� $��
BRANCH ID:��6   $��Black"�61   ���	#FF03073E6D   �� 5$      -   5        $ textbox_branchID��5$      $��75��68   ���	#FF1B5E75$��Center=�6[   5%      5&      5'      �� 5)   
   $ 
Horizontal=�6   $��0,0,0,20q�6.   $��Bottom=�6@   $��Center=�6[   .+�5*      �� -	   5         ��Name$ button_confirm��5*      $	��125��6-   $��Black"�69   $��CONFIRM��6L   $��45��6^   ���	#FFCADEED���	#FF1B5E75��5+      �� 5,       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5-      �  � Color$ 	#FF03073E��6'    � Offset$
 0.57Q�69   � 5.      $ 	#FF085EA0��6'   $ 0Q�69   5/      51      �� 52      -
   5        $ button_cancel��52      $��Black"�6,   $��CANCEL��6?   $	��125��6P   $��45��6\   $��15,0,0,0q�6h   ���	#FFCADEED���	#FF1B5E75��53      �� 54      $ 0.5,1&�6*   $ 0.5,0&�6;   .��55      � $ 	#FF03073E��6'   $
 0.57Q�69   � 56      $ 	#FF085EA0��6'   $ 0Q�69   57      59      5:      5=      5>      