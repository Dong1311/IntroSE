   M S B A M L   `   `   `  ����B  >CNPM_29, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CNPM_29.ControlsCNPM_29.Controls  5          CNPM_29.Controls.Ho_khau   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CNPM_29.Controls     5      
�������.��5	      � ���#EFEFF2  � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��10q�6;   .+�5      �� -   5        $��
Thêm hộ��5      $��0,0,30,0q�6'    
  RedBtn#��[  69   $
��Left=�5      60   �� 5      $��	Xóa hộ��6   $��0,0,30,0q�6&   #��[  68   �� 5      -   5        $��
Sửa hộ��5      $��0,0,30,0q�6&   #��[  68   5      5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��10,10,10,20q�6;   $
��Left=�6P   .+�5      �� $	��200��6   �� 5      $	��100��6   $��10,0,0,0q�6#   .@�5      �� .��6   Tên6$   5      �� 5      $��Tìm kiếm��6   $��10,0,0,0q�6(   #��[  5       5!      &   System.Windows.Controls.DataGrid  5$   
   $��2��6      AutoGenerateColumns . $��10q�6;   $��Times New Roman)�5%      $��20(�60      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã hộ��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 64      MinWidth$	 140Q�6>     5)      $ Tên chủ hộ��6%   $ * 69     5*      $ Số thành viên��6%   $ * 6<     5+      $ Địa chỉ��6%   $ * 66   5-      5.      5/      