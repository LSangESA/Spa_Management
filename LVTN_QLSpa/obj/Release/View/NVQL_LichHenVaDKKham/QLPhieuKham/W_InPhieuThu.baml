   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  C    =LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_InPhieuThu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wInPhieuThu��  � Title$  W_InPhieuThu��$	��800��$	��725�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InPhieuThuVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wGuiTinNhan��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�
�������.���  � RowDefinitions �� �� $
��auto �.+�� -   $��print�� �� $	��135 ��� $
��auto ��� $	��100 ��� $
��auto ��� �� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0�� � ColumnDefinitions �� �� �� .+��� $��0��
�������$��1q�$	��110��$	��110��$
��Left=�$	��Top=�$��	30 20 0 0q�._��� $Q��KE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Image\logoSpaIcon.png����  $  MaterialDesignHeadline4TextBlock#��[ $��1��$��0 40 0 0q�$��Center=�PHIẾU THU�� $��2��$��Right=�$��	0 20 10 0q�.+���  �� Orientation$ 
Horizontal=�$��0 0 0 0q�.+��� $��Số: ��$��14(�$��75���� $��Italic$�$��14(����� *	PT_STTs+�� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Ngày: ��$��14(�$��75���� $��Italic$�$��14(����� *
PT_NGAYLAP+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Nhân viên: ��$��14(�$��75���� $��Italic$�$��14(�$
��Wrap=�$	��120������ *NV_TEN+�� $ 
Horizontal=�$��0 5 0 0q�.+��� $��HTTT: ��$��14(�$��75���� $��Italic$�$��14(�$
��Wrap=�$	��120������ *
HTTT_TEN+�� $��0 20 0 5q�$	��0.1q�
���   �$��1���� $��2��$��	20 10 0 0q�.+��� $��Thông tin khách hàng:��$
��Bold"�$��14(��� $ 
Horizontal=�$��0 10 0 0q�.+��� $ 
Horizontal=�$	��220��.+��� $��Họ tên: ��$
��Bold"��� ���� *
KH_HOTEN+�� $ 
Horizontal=�$	��150��.+��� $��Giới tính: ��$
��Bold"��� ���� *KH_GIOITINH+�� $ 
Horizontal=�$	��200��.+��� $��Ngày sinh: ��$
��Bold"��� ���� *KH_NGAYSINH+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�.+��� $ 
Horizontal=�$	��220��.+��� $��Số điện thoại: ��$
��Bold"��� ���� *KH_SDT+�� $ 
Horizontal=�.+��� $��Email: ��$
��Bold"��� ���� *
KH_EMAIL+�� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Địa chỉ: ��$
��Bold"��� ���� *	KH_DIACHI+�� $��0 15 0 5q�$��1q�
���   �$��3���� $��4������ *ListPhieuThu+ �� View �� .P��� $	��STT�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *STT+�� $��Số PDT�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDT_STT+�� $��Dịch vụ�� �� .R�� .+��� $	��100��$
��Wrap=�$��20 0 0 0q�$��Center=����� *DICHVU+�� $��
Đơn giá�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *DONGIA+�� $��Giá giảm�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	GIAGIAM+�� $��Thành tiền�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
TONGTIEN+�� $��0 15 0 5q�$��1q�
���   �$��5��� $��6��$��0 0 0 10q� �� �� .+��� $��30 0 0 0q�$��0��.+��� $��Thành tiền�� " MaterialDesignCaptionTextBlock#��[ $��15(��� $��Giảm giá��$��15(�$��0 7 0 0q�#��[ 
���  ���� $��
Tổng thu��#��[ $��0 7 0 0q�$��20(��� $��0 0 30 0q�$��1��$��Right=�.+��� $ 
Horizontal=�$��Right=�.+��� #��[ $��15(�$��Right=����� *	THANHTIEN+�� $	�� đ��$��Right=�#��[ $��15(��� $ 
Horizontal=�$��Right=�.+��� $��15(�$��0 7 0 0q�$��Right=�#��[ 
���  ������ *	GIAMGIA+�� $	�� đ��$��15(�$��0 7 0 0q�$��Right=�#��[ 
���  ���� $ 
Horizontal=�$��Right=�.+��� #��[ $��0 7 0 0q�$��Right=�$��20(����� *
TONGTIEN+�� $	�� đ��#��[ $��0 7 0 0q�$��Right=�$��20(��� $��1��$ 
Horizontal=�$��Right=�.+��� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�$��0q�$��40��$��Center=�
�������$��2q�
��� � �$	��150��
��� � �.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Printer=�$��0 0 10 0q�$��25��$��25���� $��In��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 10q�
�������$��2q�
���  ��$��40��$	��150��
���  ������ *CommandClose+���� $ wInPhieuThu��.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CloseBox=�$��0 0 10 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�