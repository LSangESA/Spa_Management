   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  D    >LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_LapPhieuThu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wLapPhieuThu��  � Title$  W_LapPhieuThu��$	��680��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    LapPhieuThuVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wLapPhieuThu��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $	��280 ��� $
��auto ��� $
��auto ��� $
��auto ��� .+��� $��LẬP PHIẾU THU��$
��Bold"�$��25(�$��30 30 20 20q�$��0��� $��1��.+��� $��30 0 0 0q�.+���  �� Orientation$ 
Horizontal=�.+���  " MaterialDesignCaptionTextBlock#��[ $��Số phiếu thu:��$��15(�$	��130���� #��[ $��15(�$
��Bold"����� *PT_STT+�� $ 
Horizontal=�.+��� #��[ $��Ngày:��$��15(�$	��130���� #��[ $��15(����� *
PT_NGAYLAP+ �� StringFormat$ dd/MM/yyyy hh:mm���� $ 
Horizontal=�.+��� #��[ $��Khách hàng:��$��15(�$	��130���� #��[ $��15(����� *
KH_HOTEN+�� $ 
Horizontal=�.+��� #��[ $��Nhân viên lập:��$��15(�$	��130���� #��[ $��15(����� *NV_HOTEN_MA+� $��2��$��20q� � ColumnDefinitions �� $
��1.5* ��� .+��� $+��%Thanh toán cho phiếu điều trị��  MaterialDesignGroupBox#���  $��10 10 10 30q�$��0��.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   
Background �	#FF2D2F4C   
Foreground
 �����.���� .����  � IsSharedSizeScope . ���� *PHIEUDIEUTRI+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q�  MaterialDesignDivider#���  ._��  ��  z� SharedSizeGroup$ Checkerz���� .+�d�  d�Name$ chkPDT��$��Center=� ) %MaterialDesignActionLightToggleButton#��[  d� 	IsChecked �� *
IsSelected+���� .R�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
FormSelect=�   $	 Checked��.
    ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" ��  �� Path$*  $DataContext.CommandCheckThanhToanPDT� �� $ chkPDT��  $	 	Unchecked��.
    ��  �� *FindAncestor+" ��$,  &DataContext.CommandUnCheckThanhToanPDT� �� $ chkPDT���� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	PDT_STT+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *PDT_NGAYLAP+�� $ 
Horizontal=�.+��� ���� *	PDK_STT+�� $
��Bold"�$	�� - ���� ���� *	GDV_TEN+! �� Triggers! �� " �� Value$
" True��# �� Binding# �� *
IsSelected+.a��� $ �� 
TargetName$$ Border��  MaterialDesignSelection% �� Value#% �  & �� Property& � ���� $��1��$��Bottom=�$��0 0 0 25q�$��Right=�.+��� )	  #MaterialDesignThemes.Wpf.HintAssist' 	  Hint$' Hình thức thanh toán��( �� 
IsEditable( . $��10 10 20 10q�$	��240�� & "MaterialDesignFloatingHintComboBox#��[ ) �� DisplayMemberPath$) HTTT_TEN������ *HTTT+* �� SelectedItem* �� *SelectedHTTT++ �� Mode$+ TwoWay=�, �� UpdateSourceTrigger$, PropertyChanged=��� -   $��txtTIENKHACHDUA��$ ' Nhập tiền khách đưa�� %	 !MaterialDesignFloatingHintTextBox#��[	 $��10 10 20 10q�$	��240������ *TIENKHACHDUA+$+ TwoWay=�$, PropertyChanged=�.���� -   $��txtTIENTHUACHOKHACH��$' Trả lại khách��#��[	 $��10 10 20 10q�$	��240��{�.  $
��Bold"�
���  ������ *TIENTHUACHOKHACH+$+ TwoWay=�$, PropertyChanged=�.��� $��3��.+��� $��	10 0 10 0q�$	��0.1q�
���   �� $��4�� �� �� .+��� $��30 0 0 0q�$��0��.+��� $��Thành tiền��#��[ $��15(��� $��Giảm giá��$��15(�$��0 7 0 0q�#��[ 
���  ���� $��
Tổng thu��#��[ $��0 7 0 0q�$��20(��� $��0 0 30 0q�$��1��$��Right=�.+��� $ 
Horizontal=�$��Right=�.+��� #��[ $��15(�$��Right=����� *	THANHTIEN+�� $	�� đ��$��Right=�#��[ $��15(��� $ 
Horizontal=�$��Right=�.+��� $��15(�$��0 7 0 0q�$��Right=�#��[ 
���  ������ *	GG_TIEN+�� $	�� đ��$��15(�$��0 7 0 0q�$��Right=�#��[ 
���  ���� $ 
Horizontal=�$��Right=�.+��� -   $��
txtTONGTHU��#��[ $��0 7 0 0q�$��Right=�$��20(����� *
TONGTIEN+�� $	�� đ��#��[ $��0 7 0 0q�$��Right=�$��20(�� $��5��.+��� $��	10 0 10 0q�$	��0.1q�
���   �� $��6�� �� �� �� .+���  
 MaterialDesignRaisedButton#��[
 - � ToolTip$/- )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�+
  %MaterialDesignThemes.Wpf.ButtonAssist. 
  CornerRadius$. 10��$��40��$��0��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandInHoaDon+���� $ wLapPhieuThu��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ Receipt=�$��0 0 10 0q�$��25��$��25���� $��In hóa đơn��$��0 5 0 0q��� #��[
 $/- )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$. 10��$��40��$��1��$��Bottom=�$��0q����	#FF2D2F4C���� *CommandAddPT+���� $ wLapPhieuThu��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CheckAll=�$��0 0 10 0q�$��25��$��25���� $��Hoàn thành��$��0 5 0 0q��� #��[
 $/- )Resource name: MaterialDesignRaisedButton��$��10 10 10 20q�$. 10��$��40��$��2��$��Bottom=�$��0q����	#FFCA3C2A���� *CommandHuyPhieuThu+���� $ wLapPhieuThu��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ DeleteForeverOutline=�$��0 0 5 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�