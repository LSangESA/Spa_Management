   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  K    ELVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_InLichTrinhDieuTri   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wInLichTrinhDieuTri��  � Title$  W_InLichTrinhDieuTri��$	��680��$	��800�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    InLichTrinhDieuTriVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wInLichTrinhDieuTri��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�.��� 
������� � RowDefinitions �� $
��auto ��� .+�� $��0�� � ColumnDefinitions �� �� $
��auto �.+��� -    & "MaterialDesignToolForegroundButton#��[ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��$
��Left=�.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
ArrowRight=�$��Right=�$��	15 -3 0 0q�
���   ���  �� Orientation$ 
Horizontal=�$��1��$��Right=�.+��� -      MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��10 15 10 10q�$��0q�$��40��$��Center=�
�������$��2q�
��� � �$	��150��
��� � �.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ Printer=�$��0 0 10 0q�$��25��$��25���� $��In��$��0 5 0 0q��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��10 15 10 10q�
�������$��2q�
���  ��$��40��$	��150��
���  ������ *CommandClose+���� $ wInLichTrinhDieuTri��.���� $ 
Horizontal=�$��0 0 10 0q�$��Right=�.+�  $ CloseBox=�$��0 0 10 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�� $��1�� �� $
��auto ��� .+��� -   $��grdEditLichTrinh��$��0��.+�(	  "System.Windows.Controls.DatePicker	  $��15 50 15 10q�)
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Ngày tái liệu trình�� ( $MaterialDesignFloatingHintDatePicker#��[  	  SelectedDate �� *LTDT_NGAYDT+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ Đơn vị tính��$��2��$��15 10 15 10q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$
 Name������ *BUOI+ �� SelectedItem �� *SelectedBUOI+$ TwoWay=�$ PropertyChanged=��� #��[ $" MaterialDesignOutlinedButton��$��15 15 15 10q�$
��Lưu������ *CommandLuuLTDT+� -    �Name$ print��$��1�� �� $
��auto ��� .+��� $��0��$��0 20 0 0q�.+��� $��Sitka Subheading)�$��Center=�$��23(�$
��Bold"����� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=��  �� �� �� �� �� .+�� $��0�� �� $	��140 ��� .+��� $��Sitka Subheading)�$��
Họ tên:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��
20 10 0 10q�$��1������ *
KH_HOTEN+$ TwoWay=�$ PropertyChanged=�� $��2�� �� $	��140 ��� .+��� $��Sitka Subheading)�$��Lần liệu trình:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��
20 10 0 10q�$��1������ *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=�� $��1�� �� $	��140 ��� .+��� $��Sitka Subheading)�$��Gói dịch vụ:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��20 10 20 10q�$��1��$
��Wrap=����� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�� $��4�� �� $	��140 ��� .+��� $��Sitka Subheading)�$!��Bắt đầu liệu trình:��$��15(�$��
20 10 0 10q�$��0���� $��Sitka Subheading)�$��15(�$��20 10 20 10q�$��1��$
��Wrap=����� *PDK_NGAYBDDT+ �� StringFormat$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�� $��1�� �� $
��auto ��� .+��� $��Sitka Subheading)�$"��Liệu trình thực hiện:��$��18(�$
��Bold"�$��	20 20 0 0q�$��0���� -   $��lvwLTDT��$��1������ *ListLichTrinhDieuTri+ �� *SelectedLichTrinhDieuTri+$ OneWayToSource=�   $	 SelectionChanged��.
    �� *!CommandSelectedLichTrinhDieuTri+ �� $ lvwLTDT�� �� View �� .P��� $��Lần�� �� CellTemplate �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_STT+�� $��Liệu trình�� �� .R�� .+��� $	��220��$��15 0 0 0q�$��Center=�$
��Wrap=�
���   ����� *LIEUTRINH.LT_MOTA+�� $��Ngày đến�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LTDT_NGAYDT+$ 
dd/MM/yyyy���� $��Buổi�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LTDT_THOIGIANDEN+�� $��Thực hiện�� �� .R�� .+��� $��20 0 0 0q�$��Center=�
���   ����� *LIEUTRINH.LT_THOIGIANTH+