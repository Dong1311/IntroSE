   M S B A M L   `   `   `  ����B  >CNPM_29, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CNPM_29.ControlsCNPM_29.Controls  5          CNPM_29.Controls.Nop_tien   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CNPM_29.Controls     5      
�������  � 	Resources  5	         CustomTextBlockStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5
   
   " ��6-   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ Light"�6+   �� 5       � ��$ Times New Roman)�6+   �� 5       � ��$ center=�62   �� 5       � ��$ 8q�6'   5      5      .��5      ��  �� Orientation$ Vertical=�6    J� RenderTransformOrigin$ 0.5,0.5&�6(   .+�5   
   � .+�5      �� -   5        $��35��5      $��35��6!     	ReturnBtn#��[ 6,   $
��Left=�5      5      �� 5      $��ĐÓNG TIỀN��6   #��[  6)   $��Center=�5      $��20(�62   5      5      � 5   
   $��8q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6     � ColumnDefinitions 5$      �� 5%      $	��200 �6#   �� 5&      .+�5(      �� $��Tên khoản thu��6   $��0��6-   $��0��6:   #��[  5)      �� 5*      $��0��6   $��1��6#     TxtBoxStyle1#��[ 63   �� 5,      $��Tên người nộp��6   $��1��6-   $��0��6:   #��[  5-      �� 5.      $��1��6   $��1��6#   #��[ 63   �� 50      $��Ngày nộp��6   $��3��6(   $��0��65   #��[  51      (  "System.Windows.Controls.DatePicker  52      -   5          Name$ MyDatePicker��52      $
��Left=�6/   $��Center=�6J   $��3��53      $��1��6&   $	��350��66   $��10,8,5,5q�6B   $��30��6T   55      59      �� 5:   
   $��Thêm��6   $��Center=�6    $��0q�6=    
 RedBtn#��[ 5;      5>      5?      