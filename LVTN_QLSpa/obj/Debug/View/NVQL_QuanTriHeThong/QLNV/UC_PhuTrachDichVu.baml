   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LVTN_QLSpa.View.QLNVLVTN_QLSpa.View.QLNV  5      ,    &LVTN_QLSpa.View.QLNV.UC_PhuTrachDichVu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:LVTN_QLSpa.View.QLNV     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��ucPhuTrachDichVu��5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5        PhuTrachDichVuVM � DataContext# [ 5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ ucPhuTrachDichVu��5      .��5      � $��0 10 0 0q�6   	 � RowDefinitions	 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5!   
   � $��0��6   
 � ColumnDefinitions
 5"      �� 5#      $
��0.5* �6#   62   �� 5$      6%   .+�5'      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�6"   $��10q�6;   $��0��6G   $	��734��6W   .��5(      � 	 5)      �� 5*      $
��auto �6(   68   �� 5+      6*   .+�5.      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Dịch vụ��6    �� 
IsEditable . $��30 10 30 10q�50   !    & "MaterialDesignFloatingHintComboBox#��[ 51   !    �� DisplayMemberPath$ DV_TEN��52   !   $��0��55   %   ��53   !   �� *DICHVU+ �� SelectedItem 54   !   �� *
SelectedDV+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�56      �� 57      $��Gói dịch vụ��6     MaterialDesignGroupBox#���  58   %   $��30 10 30 20q�59   %   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�5:   %      
Background �	#FF2D2F4C   
Foreground
 �����$��1��5=   %   .��5>      �� -   5        $��lbxGDV��5>   B   ��6"   �� *	ListGDV+ 5?   "   �� *SelectedGDV+$ TwoWay=�$ PropertyChanged=� 5@        5A   "   $ SelectionChanged��61   . 5B   &      6<   �� *CommandSelectionGDV+ 5C   <   �� $ lbxGDV��5D   #   ��5F      �� 5G   "   .R�5H   &   ��  �� Orientation$ 
Horizontal=�61   .+�5I   *   �� $��40��6U   $��40��6`   ��60   �� *GOIDICHVU.GDV_ANH+6o   �� 5J   *   .+�5K   .   �� $��15(�6[   $��30 0 0 0q�6i   $
��Bold"�6{   ��68   �� *GOIDICHVU.GDV_TEN+6�   �� 5L   .   $ 
Horizontal=�69   .+�5M   2   �� $ 
Horizontal=�6=   $
��Left=�5N   E   $��Center=�5O   E   $��30 0 0 0q�5P   E   .+�5Q   6   ��  " MaterialDesignCaptionTextBlock#��[ 6@   $��Loại: ��5R   @   5S   7   �� 5T   6   #��[ 6@   $	��100��5V   @   ��5U   @   �� *" GOIDICHVU.LOAIGOIDICHVU.LGDV_TEN+5W   7   5X   3   �� 5Z   2   $ 
Horizontal=�6=   $
��Left=�5[   E   $��Center=�5\   E   $��0 0 0 0q�5]   E   .+�5^   6   �� #��[ 6@   $��Đơn giá: ��5_   @   $
��Left=�5`   @   5a   7   �� 5b   6   #��[ 6@   ��5c   H   �� *DONGIA+5d   7   �� 5e   6   #��[ 6@   $	�� đ��5f   H   5g   7   5h   3   5i   /   5j   +   5k   '   5l   #   5n      5o      5p      5q      � 5s      $��1��6   	 5t      �� 5u      $
��auto �6$   64   �� 5v      6&   .+�5y        $��0��6&   $��
10 10 10 0q�63   $ 10Q�6G   .��5z      � 
 5{      �� 5|      $
��0.5* �6/   6>   �� 5}      61   �� 5~      $
��0.4* �6/   6>   .+�5�      �� -   5        $��	cbxVaiTro��5�   #   $ Vai trò��5�   #    . $��
30 0 30 10q�5�   %   #��[ 5�   %   $ VT_TEN��5�   %   $��0��5�   %   ��5�   %   �� *VAITRO+ 5�   %   �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=� 5�        5�   "   $ SelectionChanged��61   . 5�   &      6<   �� *CommandSelectionVaiTro+ 5�   <   �� $ 	cbxVaiTro��5�   #   5�      �� 5�      $ 
Horizontal=�6%   $��1��6>   $��	0 5 50 15q�6N   $��Center=�6a   .+�5�      �� -   5        $��txtKeySearch��5�   *   $# Nhập từ khóa tìm kiếm��5�   &    % !MaterialDesignFloatingHintTextBox#��[ 5�   *   $	��250��5�   *   ��5�   *   �� *	KeySearch+.��5�   >    5�   "     5�   &   $ TextChanged��65   . 5�   *      6@   �� *CommandKeySearch+ 5�   @   �� $ txtKeySearch��5�   '   .��5�   :   5�      5�      �� 5�        MaterialDesignRaisedButton#��[ 6!    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5�   !   $��2��5�   !   $��Lập phụ trách��5�   !   $��
10 5 10 10q�5�   !   $��Bottom=�5�   !   ���	#FF2D2F4C$��0q�5�   8   $��40��5�   !   ��5�   !   �� *CommandLapPhuTrach+5�      5�      5�        5�      $��1��6&   $��10q�63   $ 10Q�6?   .��5�      �� $��1��6D   ��6   �� *ListNhanVien+ 6Q   �� *SelectedItemNhanVien+$ OneWayToSource=� �� View 5�      �� 5�      .P�5�   "   �� $��Mã nhân viên��61    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   .+�5�   6   �� $��70��6V   $��70��6b   ��6<   �� *NV_ANH+6o   �� 5�   6   $��20 0 0 0q�6W   $��Center=�6i   $��Center=�6�   ��6@   �� *NV_MA+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $��	Họ tên��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6Z   $��Center=�6l   $��Center=�6�   ��6@   �� *
NV_HOTEN+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $��Số điện thoại��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6X   $��Center=�6j   $��Center=�6�   ��6@   �� *NV_SDT+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $
��CCCD��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6Y   $��Center=�6k   $��Center=�6�   ��6@   �� *	NV_CCCD+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $��
Ngày sinh��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6]   $��Center=�6o   $��Center=�6�   ��6@   �� *NV_NGAYSINH+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $��Giới tính��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6]   $��Center=�6o   $��Center=�6�   ��6@   �� *NV_GIOITINH+6�   5�   3   5�   /   5�   +   5�   #   �� 5�   "   $��Tài khoản��61    5�   &   �� 5�   *   .R�5�   .   � .+�5�   2   �� $ 
Horizontal=�6=   $��70��6V   .+�5�   6   �� $��20 0 0 0q�6]   $��Center=�6o   $��Center=�6�   ��6@   �� *NV_USERNAME+6�   5�   3   5�   /   5�   +   5�   #   �� 5   "   $��Trạng thái��61    5  &   �� 5  *   .R�5  .   � .+�5  2   �� $ 
Horizontal=�6=   $��70��6V   .+�5  6   �� $��20 0 0 0q�6^   $��Center=�6p   $��Center=�6�   ��6@   �� *NV_TRANGTHAI+6�   5  3   5  /   5  +   5
  #   5     5     5     5     5     5     5     