   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV)LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  I    CLVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV.W_InfoLichLamViecNhanVien   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wInfo��  � Title$  W_InfoLichLamViecNhanVien��$	��410��$	��980�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InfoLichLamViecNhanVienVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wInfo��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � ColumnDefinitions �� $��1* ��� $��1* �.+��  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0��$��0 0 0 0q� �� $
��auto ��� .+��� $��0��.+��� 
���   �$��0��$	��0.5q�$	��Top=�$��20q�._��� $	��140��$	��129������ *NV_ANH+��  �� Orientation$ 
Horizontal=�$��20 0 0 5q�.+���    MaterialDesignBody2TextBlock#��[ $
��Ca: ��$��45��$��11(�$
��Bold"��� #��[ $��11(����� *TextCa+�� $ 
Horizontal=�$��20 0 0 5q�.+��� #��[ $��Ngày: ��$��45��$��11(�$
��Bold"��� #��[ $��11(����� *
TextNgay+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$��20 0 0 0q�.+��� #��[ $��Phòng: ��$��45��$��11(�$
��Bold"��� #��[ $��11(����� *	TextPhong+� $��1��$��0 20 0 0q�.+��� .+��� $ 
Horizontal=�.+��� #��[ $��Mã NV: ��$	��100���� #��[ ���� *NV_MA+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Họ tên: ��$	��100���� #��[ ���� *NV_TEN+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Ngày sinh: ��$	��100���� #��[ ���� *NV_NGAYSINH+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��CCCD: ��$	��100���� #��[ ���� *	NV_CCCD+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Số điện thoại: ��$	��100���� #��[ ���� *NV_SDT+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Email: ��$	��100���� #��[ ���� *
NV_EMAIL+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Giới tính: ��$	��100���� #��[ ���� *NV_GIOITINH+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��Trạng thái: ��$	��100���� #��[ ���� *NV_TRANGTHAI+�� $ 
Horizontal=�$��0 10 0 0q�.+��� #��[ $��
Vai trò: ��$	��100���� #��[ ���� *VT_TEN+� $��1��.+��� $��10 20 10 20q�$	��0.1q�
���   ��� $��2��.+��  �� �� .+��� $��0��$
��Left=�.+��� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ca làm việc�� & "MaterialDesignFloatingHintComboBox#��[ $��20 0 0 0q�$	��200������ *	CALAMVIEC+ �� SelectedItem �� *SelectedCALAMVIEC+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=����� .R��� $ 
Horizontal=�.+��� ���� *	CLV_TEN+�� $��: ���� ���� *CLV_GIOBATDAU+$ hh\:mm���� $	�� - ���� ���� *CLV_GIOKETTHUC+$ hh\:mm���� $ Phòng��#��[ $��	20 10 0 0q�$	��200������ *PHONG+ �� *SelectedPHONG+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+��� ���� *P_SO+�� $	�� - ���� ���� *P_TEN+�� $��1��$	��Top=�.+�(  "System.Windows.Controls.DatePicker  $��	10 0 10 0q�$	��200��$ 
Ngày làm�� ( $MaterialDesignFloatingHintDatePicker#��[    SelectedDate �� *
N_THOIGIAN+$ TwoWay=�$ PropertyChanged=��� $ Ghi chú�� % !MaterialDesignFloatingHintTextBox#��[  �� AcceptsReturn . $��1�� �� TextWrapping$
 Wrap=�$	��Top=�" �� VerticalScrollBarVisibility$
 Auto=�$��
20 10 20 0q�$	��200������ *
LLV_GHICHU+$ PropertyChanged=�$ TwoWay=��� $��1��.+���  & "MaterialDesignToolForegroundButton#��[ $��0q�$��25��$��0 3 10 0q�$��Bottom=�$��0q�$��Right=����� *CommandClose+���� $ wInfo��.��'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Close=��� -   $��lvwLichLamViec��$��2��$	��300��{�.  ���� *LICHLAMVIEC+ �� *SelectedLICHLAMVIEC+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedLICHLAMVIEC+ �� $ lvwLichLamViec�� �� View �� .P��� $��Ngày�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Bold"����� *NGAY+$ 
dd/MM/yyyy������ *
ColorDay+�� $��Sáng�� �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80������ *SANG+���� *	ColorSang+�� $��Chiều�� �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80������ *CHIEU+���� *
ColorChieu+�� $��
Cả ngày�� �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Bold"�$��80������ *CANGAY+���� *ColorCaNgay+�� $ 
Horizontal=�$��4��$
��Left=�$��Bottom=�.+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��+
  %MaterialDesignThemes.Wpf.ButtonAssist  
  CornerRadius$  5��$��10 20 10 20q�$��35��$��0q�$	��130��$��1��$��Bottom=�$��0q�
��� � ����� *CommandXacNhan+���� $ wInfo��.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ CheckAll=�$��0 0 10 0q�$��25��$��25���� $��Xác nhận��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$  5��$��10 20 10 20q�$��35��$	��130��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandXoaLich+.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ DeleteForeverOutline=�$��0 0 5 0q�$��25��$��25���� $��Xóa lịch��$��0 5 0 0q�