   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  H    BLVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_LapPhieuDieuTri   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wLapPhieuDieuTri��  � Title$  W_LapPhieuDieuTri��$	��650��$	��500�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    LapPhieuDieuTriVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wLapPhieuDieuTri��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.���  � RowDefinitions �� $
��auto ��� .+�� -    �Name$ print��$��0�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+�� $��0��.+��� $��PHIẾU ĐIỀU TRỊ��$��Center=�$��40(�$��20q�$��0��� $��1��.+��  � ColumnDefinitions �� $
��auto ��� .+�� $��0�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Phiếu điều trị: ��$
��Bold"�$��0��$��17(�$��
25 15 0 15q��� $��Phiếu đăng ký: ��$��1��$��17(�$��
25 15 0 15q��� $��Gói dịch vụ: ��$��2��$��17(�$��
25 15 0 15q��� $��Khách hàng: ��$��3��$��17(�$��
25 15 0 15q��� $��Liệu trình: ��$��4��$��17(�$��
25 15 0 15q��� $��Ngày khám: ��$��6��$��17(�$��
25 15 0 15q��� $��Cách thanh toán: ��$��7��$��17(�$��
25 15 0 15q�� $��1�� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $
��Bold"�$��0��$��17(�$��
25 15 0 15q����� *SOPDT+ �� UpdateSourceTrigger$ PropertyChanged=��� $��1��$��17(�$��
25 15 0 15q����� *SOPDK+$ PropertyChanged=��� $��2��$��17(�$��
25 15 0 15q����� *TENGDV+$ PropertyChanged=��� $��3��$��17(�$��
25 15 0 15q����� *	HOTENKH+$ PropertyChanged=��� $��4��$��17(�$��
25 15 0 15q����� *LT_STT+$ PropertyChanged=��� $��6��$��17(�$��
25 15 0 15q����� *NGAYDT+ �� StringFormat$ dd/MM/yyyy HH:mm��$ PropertyChanged=��� $��7��$��17(�$��
25 15 0 15q����� *	CTT_TEN+$ dd/MM/yyyy hh:ss��$ PropertyChanged=�� $��2��.+��� -   $��cbxPhong��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Phòng��$��	30 5 30 5q� & "MaterialDesignFloatingHintComboBox#��[ $��17(�{��� *HienThiPhong+���� *PHONG+ �� SelectedItem �� *SelectedPHONG+ �� Mode$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedPHONG+ �� $ cbxPhong������ .R���  �� Orientation$ 
Horizontal=�.+��� ���� *P_SO+�� $	�� - ���� ���� *P_TEN+�� -   $��
chkKhachNo��  MaterialDesignDarkCheckBox#��[ $��3��$��Khách nợ��$��17(�$��
25 20 0 15q� d� 	IsChecked �� *CheckKhachNo+{��� *EnabledKhachNo+   $	 Checked��.
    �� *CommandCheckKhachNo+ �� $ 
chkKhachNo��  $	 	Unchecked��.
    �� *CommandUnCheckKhachNo+ �� $ 
chkKhachNo��� $��1�� �� �� �� .+���   MaterialDesignRaisedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$��40��$��0��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandInPhieu+���� $ wLapPhieuDieuTri��.���� $ 
Horizontal=�$��0 0 10 0q�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ Receipt=�$��0 0 10 0q�$��25��$��25���� $��
In phiếu��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$ 10��$��40��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandOpenPhieuThu+���� $ wLapPhieuDieuTri��.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ CurrencyUsd=�$��0 0 0 0q�$��25��$��25���� $��Thanh toán��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$ 10��$��40��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandClosePDT+���� $ wLapPhieuDieuTri��.���� $ 
Horizontal=�$��0 0 10 0q�.+�	  $ DeleteForeverOutline=�$��0 0 0 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�