   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn.LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn  B    <LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn.UC_HoSoBenhAn   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Nlocal<clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wHoSoBenhAn��   MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    HoSoBenhAnVM � DataContext# [ .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger     	EventName$ Loaded��.  (System.Windows.Interactivity.TriggerBase   Actions. 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wHoSoBenhAn��.��� 	 � ColumnDefinitions	 �� $��0.95* ��� .+�� $��0��$��5q�
 � RowDefinitions
 �� $
��auto ��� .+��� -   $��txtKeySearch��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Nhập từ khóa tìm kiếm�� % !MaterialDesignFloatingHintTextBox#��[ $��15 10 15 10q�$��0��$
��Left=�$	��300������ *	KeySearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��   $ TextChanged��.    �� *KeySearchCommand+ �� $ txtKeySearch��.��#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 10Q�$��1��.���� .+���  �� Orientation$ 
Horizontal=�$��15 15 10 10q�$��0��.+��� $ 
Horizontal=�$��Center=�.+��� $)��#Danh sách dịch vụ đăng ký: ��$
��Bold"�$��15(��� $��	10 5 10 5q�$	��0.1q�
���   �$��1���� -   $��lvwPDK��$	��720������ *ListPhieuDangKy+ �� SelectedItem �� *SelectedPhieuDangKy+$ OneWayToSource=�   $ SelectionChanged��.    �� *CommandSelectedPhieuDangKy+ �� $ lvwPDK�� �� View �� .P��� $��Số PDK�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=����� *	PDK_STT+�� $��Gói dịch vụ�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *GOIDICHVU.GDV_TEN+�� $��Họ tên KH�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *KHACHHANG.KH_HOTEN+�� $��Ngày đăng ký�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *
PDK_NGAYDK+ �� StringFormat$ 
dd/MM/yyyy���� $��Trạng thái�� �� .R�� .+��� $��20 0 0 0q�$��Center=����� *PDK_TRANGTHAI+� $��1��$��5q�
 �� $
��auto ��� �� .+���    MaterialDesignOutlinedButton#��[ $��
5 10 15 10q�$��35��$��0��$
��Left=����� *CommandXemPhieuDieuTri+.���� $ 
Horizontal=�$��0 0 10 0q�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Eye=�$��0 0 10 0q�$��25��$��25���� $��Xem hồ sơ��$��0 5 0 0q�  $��1��$ 10Q�.��� 
 �� $
��auto ��� $
��auto ��� .+�� 	 �� $	��100 ��� �� �� .+��� $[��UE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png��$��60��$��60��$��0��$��20 10 20 20q��� $��1��$��10 20 10 10q�.+���  $  MaterialDesignHeadline6TextBlock#��[ ���� *KH_TEN+�� $ 
Horizontal=�.+���    MaterialDesignBody2TextBlock#��[ $��Mã KH: ��$��0 10 0 0q��� #��[ $��0 10 0 0q����� *KH_MA+�� $��2��$��20 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ 
PhoneCheck=�$��0 10 5 0q���  " MaterialDesignCaptionTextBlock#��[ $��0 6 0 0q����� *KH_SDT+�� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ GenderMaleFemale=�$��0 10 5 0q��� #��[ $��0 6 0 0q����� *KH_GIOITINH+�� $��3��$��10 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $
 Cake=�$��0 8 5 0q��� #��[ $��0 6 0 0q����� *KH_NGAYSINH+$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ Email=�$��0 10 5 0q��� #��[ $��0 6 0 0q����� *
KH_EMAIL+�� $��	10 0 10 5q�$	��0.1q�
���   �$��1���� $��2��.���� -   $��lbxPDT��$
��1100������ *ListPhieuDieuTri+ �� *SelectedPhieuDieuTri+$ OneWayToSource=�   $ SelectionChanged��.    �� *CommandSelectedPhieuDieuTri+ �� $ lbxPDT������ .R�� $��	10 5 0 10q�	 �� �� �� $	��360 ��� .+��� $Y��SE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\expenses.png��$��35��$��35���� $��30 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $��16(�$��65��$��Số: ���� $��16(����� *	PDT_STT+�� $ 
Horizontal=�.+��� $��16(�$��65��$��Ngày: ���� $��16(����� *PDT_NGAYLAP+$ dd/MM/yyyy hh:mm���� $ 
Horizontal=�.+��� $��16(�$��65��$��Dịch vụ: ���� $��16(����� *	GDV_TEN+�� $��50 0 0 0q�$��2��.+��� $ 
Horizontal=�.+��� $��16(�$	��100��$��Chuẩn đoán: ���� $
��Wrap=�$	��180��$��16(����� *PDT_CHUANDOAN+�� $ 
Horizontal=�.+��� $��16(�$��Lời dặn: ���� $
��Wrap=�$	��200��$��16(����� *
PDT_LOIDAN+�� $ 
Horizontal=�.+��� $��16(�$��
Ghi chú: ���� $
��Wrap=�$	��200��$��16(����� *
PDT_GHICHU+�� $��45 0 0 0q�$��3��.+�  $��30��$��30�� �� *Icon+���� *	ColorIcon+  $��2��$ 10Q�$��0 5 0 0q�.��� 
 �� $
��auto ��� $
��auto ��� .+��� $��Toa thuốc��$
��Bold"�$��	10 10 0 0q�$��15(��� $��	10 5 10 5q�$	��0.1q�
���   �$��1���� $��2������ *ListChiDinh+���� .R�� 
 �� $
��auto ��� $
��auto �.+�� $��0��	 �� $��1* ��� $��1* �.+��� $ 
Horizontal=�$��0��.+���  �� TextAlignment$ Center=�$
��Wrap=�$��15(�$��25,0,0,0q�$��Center=�$��Sitka Subheading)�$
��Bold"�$��Italic$����� *T_STT+�� $��Sitka Subheading)�$��Center=�$��17(�$
��Bold"�$��Italic$����� *T_TEN+$ TwoWay=�$ PropertyChanged=��� $��Sitka Subheading)�$��Center=�$��17(�$
��Bold"�$��Italic$����� *	DVT_TEN+$ TwoWay=�$ PropertyChanged=��� $ 
Horizontal=�$��1��.+��� $��Số lượng: ��$��Sitka Subheading)�$��Center=�$��15(��� $��Sitka Subheading)�$��Center=�$��15(����� *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=�� $��1��$��0 0 0 10q�.+��� $ 
Horizontal=�.+��� $��Sitka Subheading)�$��Center=�$��15(�$��25,0,0,0q����� *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=��� $��Sitka Subheading)�$��Center=�$��15(����� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�