   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV)LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  @    :LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV.W_LapLichLamViec   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  w_LapLichLamViec��$	��650��$	��710�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    LapLichLamViecVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ w_LapLichLamViec��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� .+���  �� Orientation$ 
Horizontal=�$��5 10 0 0q�$��0��.+��� $a��[E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\appointment.png��$��35��$��35��$��10 0 0 0q��� $��Xếp lịch làm việc��$
��Bold"�$��20(�$��Center=�$��10 0 0 0q���    MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$)��#Lập lại lịch cho tuần tới��$	��180��$��0 2 0 0q�$��
280 0 20 0q�
�������$��1q�
���   �
���   ����� *CommandLapLichTuanToi+�� $��5q�$��1q�
���   �$��1��� $��2�� �� $
��auto ��� $
��auto ��� $
��auto ��� .+�� $��0�� � ColumnDefinitions �� �� .+��� $��0��.+��� -   $��cbxCLV��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ca làm việc�� & "MaterialDesignFloatingHintComboBox#��[ $��30 10 30 10q����� *	CALAMVIEC+ �� SelectedItem �� *SelectedCALAMVIEC+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedCLV+ �� $ cbxCLV������ .R��� $ 
Horizontal=�.+��� ���� *	CLV_TEN+�� $��: ���� ���� *CLV_GIOBATDAU+ �� StringFormat$ hh\:mm���� $	�� - ���� ���� *CLV_GIOKETTHUC+$ hh\:mm��(  "System.Windows.Controls.DatePicker  -   $��dtpkNgay��$��30 10 30 10q�$ 
Ngày làm�� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *
N_THOIGIAN+$ TwoWay=�$ PropertyChanged=�   $	 SelectedDateChanged��.
    �� *CommandSelectedDate+ �� $ dtpkNgay���� $ Ghi chú�� % !MaterialDesignFloatingHintTextBox#��[  �� AcceptsReturn . $��1�� �� TextWrapping$
 Wrap=�$	��Top=�" �� VerticalScrollBarVisibility$
 Auto=�$��30 10 30 10q�$��93������ *
LLV_GHICHU+$ PropertyChanged=�$ TwoWay=��� $��
20 10 20 5q�$��1q�
���   �$��1��� $��2�� �� �� $
��auto ��� .+�� $��0��.+��� .+��� -   $��cbxPhong��$ Chọn phòng��#��[  �� DisplayMemberPath$
 P_SO��$��	30 5 10 5q����� *PHONG+ �� *SelectedPHONG+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedPhong+ �� $ cbxPhong���� -   $��	cbxVaiTro��$ Vai trò��#��[ $ VT_TEN��$��	30 5 10 5q����� *VAITRO+ �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedVaiTro+ �� $ 	cbxVaiTro��� $��	30 5 10 5q�$	��250��.+��� 
���   �$	��0.5q�._��� ���� *ListNhanVien+ �� *SelectedNhanVien+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�$��40��.+�A� $��35��$��35��$��5 0 0 0q�$��Center=�����  �� ImageSource �� *NV_ANH+�� .+��� $ 
Horizontal=�.+��� $
��Left=�
���   �$��5 0 0 0q����� *NV_TEN+�� $	�� - ��$
��Left=�
���   ��� $
��Left=�
���   �$��0 0 5 0q����� *VT_TEN+�� $
��Left=�
���   �$��5 5 0 0q����� *CM_TEN+� $��1��$��Center=�.+��� $��0 80 0 0q�.+���   MaterialDesignRaisedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q����	#FF2D2F4C$��0q����� *CommandMoveRight+.��'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ ChevronRight=�$��20��$��20���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q����	#FF2D2F4C$��0q����� *CommandMoveLeft+.��	  $ ChevronLeft=�$��20��$��20���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q����	#FF2D2F4C$��0q����� *CommandMoveRightAll+.��	  $ ChevronDoubleRight=�$��20��$��20���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q����	#FF2D2F4C$��0q����� *CommandMoveLeftAll+.��	  $ ChevronDoubleLeft=�$��20��$��20��� $��2��.+��� .+��� $ 
Horizontal=�.+��� $	��(*)��
���  ��$��	10 15 0 5q��� $��	5 15 30 5q�$��57��$	��255��$
��Wrap=����� *GhiChuSucChuaPhong+� $��
10 20 30 5q�$	��250��.+��� 
���   �$	��0.5q�._��� -   $��lbxListNhanVienXepLich������ *ListNhanVienXepLich+ �� *SelectedNhanVienXepLich+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�$��40��.+�A� $��35��$��35��$��5 0 0 0q�$��Center=�����  �� *NV_ANH+�� .+��� $ 
Horizontal=�.+��� $
��Left=�
���   �$��5 0 0 0q����� *NV_TEN+�� $	�� - ��$
��Left=�
���   ��� $
��Left=�
���   ����� *VT_TEN+�� $
��Left=�
���   �$��5 5 5 0q����� *CM_TEN+�� $ 
Horizontal=�$��3��$��Right=�.+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$	��120��$��Right=�$��Bottom=�$��0q����	#FF2D2F4C���� *CommandAddLLV+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ ContentSaveOutline=�$��0 0 10 0q�$��25��$��25���� $
��Lưu��$��0 4 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��35��$��Right=�$	��120��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandCloseLLV+���� $ w_LapLichLamViec��.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ CloseCircle=�$��0 0 10 0q�$��25��$��25���� $��Đóng��$��0 4 0 0q�