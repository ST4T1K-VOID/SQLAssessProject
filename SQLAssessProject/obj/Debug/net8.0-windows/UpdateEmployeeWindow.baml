   M S B A M L   `   `   `  ����E  ASQLproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SQLproject
SQLproject  5   	   %    SQLproject.UpdateEmployeeWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SQLproject     5   	     � Title$  UpdateEmployeeWindow��5   	   $	��450��6&   $	��800��63   $	��500��6?   $	��900��6O   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��.5* �6   �� 5      $��7* �6   �� 5      $
��1.5* �6   .+�5   
   �� $��1��6   $��1��6%    �� Orientation$ Vertical=�62   $
��50,0q�6I   .+�5      �� $��
First Name��6   $
��Left=�6)   $��Black"�6K   �� 5      -   5         ��Name$ textbox_FirstName��5      $�� ��61   $��30��69   $��Center=�6E   $��16(�6g   �� 5      $��	Last Name��6   $
��Left=�6(   $��Black"�6J   �� 5      -   5        $ textbox_LastName��5      $�� ��60   $��30��68   $��Center=�6D   $��16(�6f   �� 5      $��DATE OF BIRTH��6   $
��Left=�6,   $��Black"�6N   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ datebox_DOB��5      $��30��6.   �� 5      $��SALARY��6   $
��Left=�6%   $��Black"�6G   �� 5      -   5        $ textbox_Salary��5      $�� ��6.   $��30��66   $��Center=�6B   $��16(�6d   �� 5      $��	BRANCH ID��6   $
��Left=�6(   $��Black"�6J   �� 5      -   5        $ textbox_BranchID��5      $�� ��60   $��30��68   $��Center=�6D   $��16(�6f   �� 5      $��SUPERVISOR ID��6   $
��Left=�6,   $��Black"�6N   �� 5       -   5        $ textbox_SupervisorID��5       $�� ��64   $��30��6<   $��Center=�6H   $��16(�6j   5!      �� 5"   
   $��1��6   $��2��6%   $ 
Horizontal=�62   $��Center=�6K   .+�5#      �� -   5         ��Name$ button_Confirm��5#      $��CONFIRM��6-   $	��167��6?   $��33��6K   $��0,0,20,0q�6W   $��Black"�6i   $��18(�6|   �� 5$      -   5        $ button_Cancel��5$      $��CANCEL��6,   $	��167��6=   $��33��6I   $��Black"�6U   $��18(�6h   6v   5%      5&      5'      