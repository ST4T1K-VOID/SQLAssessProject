   M S B A M L   `   `   `  ����E  ASQLproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SQLproject
SQLproject  5   	       SQLproject.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SQLproject     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1600��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $��3* �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      �� 5      $��8* �6   �� 5      $��10 �6   �� 5      $��2* �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ list_employees��5      $��3��6*   $��2��6:   $��2��6G   $��22(�6[   ���	#FFF1F1F1���	#FF86888C6�   �� 5   
   $��1��6   $��2��6%    �� Orientation$ Vertical=�62   .+�5       �� $
��NAME��6   $
��Left=�6#   $	��177��6>   $��Black"�6J   $��22(�6]   �� 5!      $
��Left=�6   $ 
Horizontal=�64   .+�5"      �� -   5         ��Name$ textbox_FirstName��5"      $��PLACEHOLDER��65   $��22(�6H   $	��300��6V   $��0,0,15,0q�6b   $��40��6t   $��Center=�6�    �� 
IsReadOnly$
 True��6�   �� 5#      -   5        $ textbox_LastName��5#      $��PLACEHOLDER��64   $��22(�6G   $	��300��6U   $��40��6a   $��Center=�6m   $
 True��6�   5$      �� 5%      $��ID��6   $
��Left=�6!   $	��177��6<   $��Black"�6H   $��22(�6[   �� 5&      -   5        $ textbox_EmployeeID��5&      $��PLACEHOLDER��62   $��22(�6E   $	��610��6S   $��40��6_   $��Center=�6k   $
��Left=�6�   �� 5'      $��SALARY��6   $
��Left=�6%   $	��177��6@   $��Black"�6L   $��22(�6_   �� 5(      -   5        $ textbox_Salary��5(      $��PLACEHOLDER��6.   $��22(�6A   $	��610��6O   $��40��6[   $��Center=�6g   $
��Left=�6�   �� 5)      $��	BRANCH ID��6   $
��Left=�6(   $	��177��6C   $��Black"�6O   $��22(�6b   �� 5*      -   5        $ textbox_BranchID��5*      $��PLACEHOLDER��60   $��22(�6C   $	��610��6Q   $��40��6]   $��Center=�6i   $
��Left=�6�   �� 5+      $��SUPERVISOR ID��6   $
��Left=�6,   $	��177��6G   $��Black"�6S   $��22(�6f   �� 5,      -   5        $ textbox_SupervisorID��5,      $��PLACEHOLDER��64   $��22(�6G   $	��610��6U   $��40��6a   $��Center=�6m   $
��Left=�6�   5-      �� 5/   
   $��1��6   $��2��6%   $ 
Horizontal=�62   $
��Left=�6K   $��Bottom=�6f   .+�50      �� -   5         ��Name$ button_AddEmployee��50      $��ADD EMPLOYEE��61   $	��250��6H   $��70��6T   $��	0,0,30,30q�6`   $��Black"�6s   $��20(�6�   6�   �� 51      -	   5        $ button_UpdateEmployee��51      $��UPDATE EMPLOYEE��64   $	��250��6N   $��70��6Z   $��	0,0,30,30q�6f   $��Black"�6y   $��20(�6�   6�   �� 52      -
   5        $ button_RemoveEmployee��52      $��REMOVE EMPLOYEE��64   $	��250��6N   $��70��6Z   $��0,0,0,30q�6f   $��Black"�6x   $��20(�6�   54      56      57      