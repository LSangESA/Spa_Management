   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM*LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  >    8LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM.W_GhiNhanBenh   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Jlocal8clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_KHAM     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     �Name$  wGhiNhanBenh�� � Title$ GHI NHẬN BỆNH��$	��800��$
��1450�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    GhiNhanBenhVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction	   Triggers	 /  )System.Windows.Interactivity.EventTrigger  
   	EventName$
 Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wGhiNhanBenh��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � RowDefinitions �� $
��auto ��� .+�� $��0��.+�,   &LVTN_QLSpa.UserControlSpa.UseControlUC  
 � Tag �� *Title+$ wGhiNhanBenh��� $��1�� � ColumnDefinitions �� $
��0.3* ��� $
��1.7* �.+�  $��
10 10 0 10q�$ 10Q�$��0��.���� $��Lịch sử điều trị��  MaterialDesignGroupBox#���  $��10 10 10 30q�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ 
PrimaryMid=�   
Background �	#FF2D2F4C   
Foreground
 �   �.���� -   $��lbxPhieuDangKy������ *PHIEUDIEUTRI+ �� SelectedItem �� *SelectedPHIEUDIEUTRI+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�	   $
 SelectionChanged��.    �� *CommandSelectedPHIEUDANGKY+ �� $ lbxPhieuDangKy������ .R���  �� Orientation$ 
Horizontal=�.+��� 
���   �$
��Bold"����� *PDT_NGAYLAP+ �� StringFormat$ dd/MM/yyyy hh:mm��� $��1�� �� $
��auto ��� $��70 �.+�� $��0�� �� �� .+�  $��0��$ 10Q�$��10q�.���  �� $
��auto ��� .+��� $��Thông tin khách hàng��#���  $��10 10 10 10q�$ 
PrimaryMid=� �	#FF2D2F4C
 �����$��0��.���  �� �� .+�� $��0�� �� �� �� .+��� )	  #MaterialDesignThemes.Wpf.HintAssist 	  Hint$ Tên khách hàng�� % !MaterialDesignFloatingHintTextBox#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��0������ *KH_TEN+$ TwoWay=�$ PropertyChanged=�.���� $ Tuổi��#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��1������ *	KH_TUOI+$ TwoWay=�$ PropertyChanged=�.���� $ Giới tính��#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��2������ *KH_GIOITINH+$ TwoWay=�$ PropertyChanged=�.��� $��1�� �� �� �� .+��� $ Số điện thoại��#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��0������ *KH_SDT+$ TwoWay=�$ PropertyChanged=�.���� $ Email��#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��1������ *
KH_EMAIL+$ TwoWay=�$ PropertyChanged=�.���� $ Địa chỉ��#��[ $��15 10 15 10q�{�.  
���   �$
��Bold"�$��2������ *	KH_DIACHI+$ TwoWay=�$ PropertyChanged=�.���� $��Thông tin điều trị��#���  $��10 10 10 10q�$ 
PrimaryMid=� �	#FF2D2F4C
 �����$��1��.���  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0�� �� �� .+��� $! Gói dịch vụ đăng ký��#��[ $��	15 7 15 7q�{�.  $��0��
���   �$
��Bold"����� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�.���� $ Loại gói dịch vụ��#��[ $��	15 7 15 7q�{�.  $��1��
���   �$
��Bold"����� *
LGDV_TEN+$ TwoWay=�$ PropertyChanged=�.��� $��1�� �� �� .+��� $  Số phiếu điều trị��#��[ $��	15 7 15 7q�{�.  $��0��
���   �$
��Bold"����� *	PDT_STT+$ TwoWay=�$ PropertyChanged=�.���� $! Liệu trình điều trị��#��[ $��	15 7 15 7q�{�.  $��1��
���   �$
��Bold"����� *LT_STT_MOTA+$ TwoWay=�$ PropertyChanged=�.���� $ Ngày khám��#��[ $��	15 7 15 7q�{�.  $��2��
���   �$
��Bold"����� *PDT_NGAYKHAM+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�.���� $ Chuẩn đoán��#��[ $��	15 7 15 7q�$��3������ *PDT_CHUANDOAN+$ TwoWay=�$ PropertyChanged=�.���� $ Lời đặn��#��[ $��	15 7 15 7q�$��4������ *
PDT_LOIDAN+$ TwoWay=�$ PropertyChanged=�.���� $ Ghi chú��#��[ $��15 10 15 10q�$��5������ *
PDT_GHICHU+$ TwoWay=�$ PropertyChanged=�.��� $��6�� �� �� .+��� $ Ngày khám tiếp theo��#��[ $��	15 7 15 7q�{�.  $��0��
���   �$
��Bold"����� *	LTDT_NGAY+$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�.���� $ Thời gian đến��#��[ $��	15 7 15 7q�{�.  $��1��
���   �$
��Bold"����� *LTDT_THOIGIAN+$ TwoWay=�$ PropertyChanged=�.��  $��1��$ 10Q�$��
0 10 10 10q�.��� $��0�� �� �� .+�� $��0�� �� -    ��Name$ rdCDDT���� -   $
 rdTT��.+�� -    �Name$ grdCDDT��$��0��.+��� $��Kê đơn thuốc��#���  $��10 10 10 10q�$ 
PrimaryMid=� �	#FF2D2F4C
 �����.���� .+��  �� �� $��60 �.+��� -   $��txtSearchThuoc��$ Thuốc��#��[ $��15 15 15 15q�$��0������ *TextSearchThuoc+$ TwoWay=�$ PropertyChanged=�.��	   $
 TextChanged��.    �� *CommandSearchThuoc+ �� $ txtSearchThuoc��.���� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��+
  %MaterialDesignThemes.Wpf.ButtonAssist  
  CornerRadius$  0��
�������$��2q�
���   �$��0q�$��50��
���   �$��1��.��'  !MaterialDesignThemes.Wpf.PackIcon  !   Kind$
! Plus=�$��20��$��20���  �� �� .+��� $ Số lượng��#��[ $��15 15 15 15q�$��0������ *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=��� $ Liều dùng��#��[ $��15q�$��1������ *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=��� $ Cách dùng��#��[ $��15q����� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�� $��0 20 0 0q� �� �� .+���   MaterialDesignRaisedButton#��[ $/ )Resource name: MaterialDesignRaisedButton��$��0��$��Nhập��$��	15 8 15 8q�$��30�����	#FF43D05E$��0q�
���   ����� *CommandAddCHIDINH+�� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��1��$
��Xóa��$��	15 8 15 8q�$��30�����	#FFF45757$��0q�
���   ����� *CommandDeleteCHIDINH+  $	��153��$	��475��$��29,90,90,61.4q�y��� *HienThiListBox+.���� .���� -   $��lbxThuoc��$��0,0,0.2,-0.4q�" �� DisplayMemberPath$" T_TEN������ *	ListThuoc+ �� *SelectedTHUOC+$ TwoWay=�$ PropertyChanged=�	   $
 SelectionChanged��.    �� *CommandSelectedThuoc+ �� $ 	txtNV_TEN��� -	   $ grdTT��$��1��.+��� #���  $��10 10 10 10q�$ 
PrimaryMid=� �	#FF2D2F4C
 ��������� .R��� $ 
Horizontal=�$��20��.+��� -
    & "MaterialDesignToolForegroundButton#��[ $
��Left=�$��Center=�.��  $! 	ArrowLeft=�
��������� $��Thêm danh mục thuốc��$��Center=�$��10 0 0 0q�.���  �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $ Tên thuốc��#��[ $��	15 5 15 5q�$��0������ *T_TEN+$ TwoWay=�$ PropertyChanged=�.���� $ Hoạt chất��$��1��$��	15 5 15 5q� & "MaterialDesignFloatingHintComboBox#��[ $" HC_TEN������ *BIETDUOCAdd+ �� *SelectedBIETDUOCAdd+$ TwoWay=�$ PropertyChanged=��� $ Đơn vị tính��$��2��$��	15 5 15 5q�#��[ $" DVT_TEN������ *DVT+ �� *SelectedDVT+$ TwoWay=�$ PropertyChanged=��� $ Nhà sản xuất��$��3��$��	15 5 15 5q�#��[ $" NSX_TEN������ *NSX+ �� *SelectedNSX+$ TwoWay=�$ PropertyChanged=��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
15 30 15 5q�$��30��$��4��$  5�����	#FF43D05E$��0q�
���   �$��Bottom=����� *CommnadAddThuoc+.���� $ 
Horizontal=�.+�  $! ContentSaveEdit=�$��25��$��25��$��0 0 10 0q�$��Center=��� $��Lưu thuốc��$��Center=��� $��Toa thuốc��#���  $��10 10 10 10q�$ 
PrimaryMid=� �	#FF2D2F4C
 �����$��1��.���� -   $��
lvwCHIDINH������ *ListCHIDINH+ �� *SelectedCHIDINH+$ OneWayToSource=�	   $
 SelectionChanged��.    �� *CommandSelectedCHIDINH+ �� $ 
lvwCHIDINH��# �� View# �� .P��� $	��STT��$ �� Width$$ 90��% �� CellTemplate% �� .R�� .+��� $��20 0 0 0q�$��Center=����� *STT+�� $��Tên thuốc��$	$ 150��% �� .R�� .+��� $��20 0 0 0q�$��Center=����� *T_TEN+�� $��Số lượng��$	$ 120��% �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
CD_SOLUONG+�� $��Liều dùng��$	$ 180��% �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Wrap=����� *CD_LIEUDUNG+�� $��Cách dùng��$	$ 250��% �� .R�� .+��� $��20 0 0 0q�$��Center=�$
��Wrap=����� *CD_CACHDUNG+  $��1��$��
10 0 10 10q�$ 10Q�$��Bottom=�.���  �� �� �� �� �� �� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 5 10 10q�$��40��$��0��$  5��$��Bottom=����	#FF2D2F4C$��0q����� *CommandLuuPhieu+.���� $ 
Horizontal=�.+�  $! ContentSaveEdit=�$��0 0 10 0q�$��25��$��25���� $
��Lưu��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��40��$��1��$  5��$��Bottom=����	#FF2D2F4C$��0q����� *CommandInToaThuoc+���� $ wGhiNhanBenh��.���� $ 
Horizontal=�.+�  $! PrinterCheck=�$��0 0 10 0q�$��25��$��25���� $��In toa thuốc��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��40��$��2��$  5��$��Bottom=����	#FF2D2F4C$��0q����� *CommandLichTrinhKham+���� $ wGhiNhanBenh��.���� $ 
Horizontal=�.+�  $! CalendarText=�$��0 0 10 0q�$��25��$��25���� $��Lịch trình khám��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��40��$��3��$  5��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDoiNgayKham+���� $ wGhiNhanBenh��.���� $ 
Horizontal=�.+�  $! CalendarArrowRight=�$��0 0 10 0q�$��25��$��25���� $��Dời ngày khám��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$  5��$��40��$��4��$��Bottom=����	#FF2D2F4C$��0q����� *CommandDichVuDaDangKy+���� $ wGhiNhanBenh��.���� $ 
Horizontal=�.+�  $! TextBoxPlus=�$��25��$��25��$��0 0 10 0q��� $��DV đã đăng ký��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$  5��$��40��$��5��$��Center=����	#FF2D2F4C$��0q����� *CommandHoanThanh+���� $ wGhiNhanBenh��.���� $ 
Horizontal=�.+�  $! ClipboardCheckOutline=�$��0 0 10 0q�$��25��$��25���� $��Hoàn thành khám��$��0 5 0 0q�