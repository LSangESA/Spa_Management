   M S B A M L   `   `   `  ���� E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV(LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV  E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  C    =LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV.W_ThemPhuTrachDichVu   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLNV     6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $��wThemPhuTrach��  � Title$  W_ThemPhuTrachDichVu��$	��670��$
��1050�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .    MaterialDesignBody#���   $��Regular"�$��13(�&   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�   TextRenderingMode$
 Auto=�  MaterialDesignFont#���    ThemPhuTrachDichVuVM � DataContext# [ ��Z� .  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 Loaded��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *
LoadWindow+   CommandParameter ��  �� ElementName$ wThemPhuTrach��.��� .+��� 
���   �$��2q� �� CornerRadius$ 15 15 15 15��._�#  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q����	#FFF7F7F7.���  � RowDefinitions �� $
��auto ��� $
��auto ��� .+�� -   $��grdPhuTrachNV��$��0��$��0 10 0 0q� � ColumnDefinitions �� �� .+��� $��0��.+��  �� �� .+��� -   $��	cbxVAITRO��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Vai trò��$��	20 5 10 5q� & "MaterialDesignFloatingHintComboBox#��[  �� DisplayMemberPath$ VT_TEN��$��0������ *VAITRO+ �� SelectedItem �� *SelectedVAITRO+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionVAITRO+ �� $ 	cbxVAITRO���� -   $��cbxCHUYENMON��$ Chuyên môn��$��	10 5 20 5q�#��[ $ CM_TEN��$��1������ *	CHUYENMON+ �� *SelectedCHUYENMON+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionCHUYENMON+ �� $ cbxCHUYENMON��� $��65��.+��� -   $��cbxNhanVien��$ Nhân viên��$��	20 5 20 5q�#��[ $	��Top=�$��1������ *
NHANVIEN+ �� *SelectedNHANVIEN+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectedNHANVIEN+ �� $ cbxNhanVien������ .R���  �� Orientation$ 
Horizontal=�.+�A� $��30��$��30��$��0 5 0 0q�����  �� ImageSource �� *NV_ANH+�� $��Center=�$��10 0 0 0q����� *
NV_HOTEN+� $��	20 10 0 0q� �� $	��100 ��� .+��� $��70��$��70��$��0��$��10 10 20 20q����� *NV_ANH+� $��1�� �� $
��auto ��� $
��auto �.+��� $ 
Horizontal=�$��20 5 0 0q�$��0��$
��Left=�$��Center=�.+���  $  MaterialDesignHeadline6TextBlock#��[ ���� *
NV_HOTEN+�� $ 
Horizontal=�.+���    MaterialDesignBody2TextBlock#��[ $��Mã NV: ��$��20 5 0 0q��� #��[ $��0 5 0 0q����� *NV_MA+� $��1�� �� �� .+��� $��0��$��15 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
PhoneCheck=�$��0 3 5 0q���  " MaterialDesignCaptionTextBlock#��[ ���� *NV_SDT+�� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ GenderMaleFemale=�$��0 0 5 0q��� #��[ ���� *NV_GIOITINH+�� $��1��$��
0 10 10 10q�.+��� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $
 Cake=�$��0 0 5 0q��� #��[ ���� *NV_NGAYSINH+ �� StringFormat$ 
dd/MM/yyyy���� $ 
Horizontal=�$��0 5 0 0q�$
��Left=�$��Center=�.+�  $ Email=�$��0 3 5 0q��� #��[ ���� *
NV_EMAIL+�� $ 
Horizontal=�$��	20 10 0 0q�.+��� $��
Vai trò: ��$��13(�$	��100��$��	15 10 0 0q�$
��Bold"�$��Center=��� $��13(�$��0 10 0 0q�$��Center=����� *VT_TEN+�� $ 
Horizontal=�$��20 0 0 0q�.+��� $��Chuyên môn: ��$��13(�$	��100��$��15 0 0 0q�$
��Bold"�$��Center=��� $
��Wrap=�$	��240��$��13(�$��0 0 0 0q�$��Center=����� *CM_TEN+�� $ 
Horizontal=�$��0 20 0 0q�.+��� -   $��chkAllNV��  MaterialDesignDarkCheckBox#��[ $��15(�$
��Bold"�$��35 6 0 0q�$��Phụ trách gói:��$	��Top=�   $	 Checked��.
    �� *CommandCheckAllGDVNV+ �� $ chkAllNV��  $	 	Unchecked��.
    �� *CommandUnCheckAllGDVNV+ �� $ chkAllNV����    MaterialDesignOutlinedButton#��[  � ToolTip$/ )Resource name: MaterialDesignRaisedButton��$��190 0 10 10q�$��0q�$��30�����	#FFF7F7F7$��Bottom=�$��0q����� *CommandDeletePhuTrach+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CloseCircle=�$��5 0 5 0q�$��25��$��25��
���  ���� $
��Xóa��$��0 0 0 0q�
���  ��$��Center=��� $��	20 10 5 0q�.���� 
�������$��1q�$	��250��._���  � IsSharedSizeScope . ���� *ListGoiDichVuNhanVien+���� .R���  ��Name$ Border�� �� Padding$ 8q�$��0 0 0 1q� 	 MaterialDesignDivider#��� 	 ._��  ��  z� SharedSizeGroup$ Checkerz���� .+�d�   d�Name$  chkPDT��$��Center=� )
 %MaterialDesignActionLightToggleButton#��[
 ! d� 	IsChecked! �� *	IsCheck+.���� $��45��$��45������ *	GDV_ANH+�� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *GDV_MA+�� $ 
Horizontal=�.+��� ���� *
LGDV_TEN+�� $
��Bold"�$	�� - ���� ���� *DONGIA+" �� Triggers" �� # �� Value$
# True��$ �� Binding$ �� *
IsSelected+.a��� % �� 
TargetName$% Border��  MaterialDesignSelection& �� Value#& �  ' �� Property' � ���� 
�������$��0 0 1 0q��� $��1��.+��  �� �� $
��auto �.+��� -   $��	cbxDICHVU��$ Dịch vụ��$��	20 5 20 5q�#��[ $ DV_TEN��$��0������ *DICHVU+ �� *SelectedDICHVU+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionDICHVU+ �� $ 	cbxDICHVU���� -   #��[ $/ )Resource name: MaterialDesignRaisedButton��+	  %MaterialDesignThemes.Wpf.ButtonAssist( 	  CornerRadius$( 5��$��60��$��0 0 20 0q�
�������$��1q�
���   �
���   �$��2��.��  $ PageNext=�$��20��$��20���� $ 
Horizontal=�.+�	� -	   ) 	�Name$) chkTatCaGDV��$��15 20 15 10q�$��0��* 	� 	GroupName$* checkGDV��$��
Tất cả��! �� *CheckAllGDVLoc+   $	 Checked��.
    �� *CommandAllGoiDichVu+ �� $ chkTatCaGDV��	� -
   $) chkCoLieuTrinh��$��15 20 15 10q�$��0��$* checkGDV��$��Có liệu trình��! �� *CheckCoLieuTrinh+   $	 Checked��.
    �� *CommandCheckCoLieuTrinh+ �� $ chkCoLieuTrinh��	� -   $) chkKhongLieuTrinh��$��15 20 15 10q�$��0��$* checkGDV��$��Không liệu trình��! �� *CheckKhongLieuTrinh+   $	 Checked��.
    �� *CommandCheckKhongLieuTrinh+ �� $ chkKhongLieuTrinh���� $ 
Horizontal=�$��0 20 0 0q�.+��� -   $��	chkAllGDV��#��[ $��15(�$
��Bold"�$��40 6 0 0q�$��Gói dịch vụ:��$	��Top=�   $	 Checked��.
    �� *CommandCheckAllGDV+ �� $ 	chkAllGDV��  $	 	Unchecked��.
    �� *CommandUnCheckAllGDV+ �� $ 	chkAllGDV���� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��170 0 10 10q�$��0q�$��30�����	#FFF7F7F7$��Bottom=�$��0q����� *CommandAddPhuTrachDichVu+.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CheckBoxMultipleOutline=�$��5 0 5 0q�$��25��$��25��
��� � ��� $��Nhập��$��0 0 0 0q�
��� � �$��Center=��� $��
20 10 10 0q�.���� 
�������$��1q�$	��431��._���  . ���� *ListGoiDichVu+���� .R��� $ Border��$ 8q�$��0 0 0 1q�#��� 	 ._��  �� $ Checkerz���� .+�d� $  chkPDT��$��Center=�#��[
 ! �� *	IsCheck+.���� $��45��$��50������ *	GDV_ANH+�� $��8 0 0 0q�$��1��.+��� $ 
Horizontal=�.+��� $
��Bold"�$��16(����� *	GDV_TEN+�� $
��Bold"�$��16(�$	�� - ���� $
��Bold"�$��16(����� *GDV_MA+�� $ 
Horizontal=�.+��� ���� *
LGDV_TEN+�� $
��Bold"�$	�� - ���� ���� *DONGIA+" �� $
# True��$ �� *
IsSelected+.a��� $% Border��#& �  ' � ��� -   $��grdPhuTrachAllNV��$��1��$y�Visible=� �� �� $
��auto ��� .+��� $��0 10 0 0q�.+��  �� �� .+��� -   $��
cbxVaiTroS��$ Vai trò��$��	30 5 10 5q�#��[ $��0��$ VT_TEN������ *	VAITRO_NV+ �� *SelectedVAITRO_NV+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionVAITRO_NV+ �� $ 
cbxVaiTroS���� -   $��cbxChuyenMonS��$ Chuyên môn��$��	10 5 30 5q�#��[ $ CM_TEN��$��1������ *CHUYENMON_NV+ �� *SelectedCHUYENMON_NV+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionCHUYENMON_NV+ �� $ cbxChuyenMonS���� $��Danh sách nhân viên��  MaterialDesignGroupBox#���  $��20 10 10 10q�.
  (MaterialDesignThemes.Wpf.ColorZoneAssist+ 
  Mode$+ Custom=�, 
  
Background, �	#FF2D2F4C- 
  
Foreground
- �����.���� $	��480������ *ListNhanVienChuaPhuTrach+ �� *" SelectedListNhanVienChuaPhuTrach+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+��� $��40��$��40������ *NV_ANH+�� .+��� $ 
Horizontal=�.+��� $��15(�$��10 0 0 0q�$
��Bold"�$��Center=����� *
NV_HOTEN+�� $	�� - ��$��15(�$��0 0 0 0q�$
��Bold"�$��Center=��� $��15(�$��0 0 0 0q�$
��Bold"�$��Center=����� *NV_MA+� $��1��$��0 40 0 0q�$��Center=�.+��� .+��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q�$��1q�
���   ����� *CommandMoveRight+.��  $ ChevronRight=�$��20��$��20��
���   ��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q�$��1q�
���   ����� *CommandMoveLeft+.��  $ ChevronLeft=�$��20��$��20��
���   ��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q�$��1q�
���   ����� *CommandMoveRightAll+.��  $ ChevronDoubleRight=�$��20��$��20��
���   ��� #��[ $/ )Resource name: MaterialDesignRaisedButton��$��
10 0 10 10q�$��1q�
���   ����� *CommandMoveLeftAll+.��  $ ChevronDoubleLeft=�$��20��$��20��
���   ��� $��0 10 0 0q�$��2��.+��  �� �� �� $
��auto �.+��� -   $��	cbxDichVu��$ Dịch vụ��$��	30 5 10 5q�#��[ $��0��$ DV_TEN������ *	DICHVU_NV+ �� *SelectedDV_NV+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionDICHVU_NV+ �� $ 	cbxDichVu���� -   $��cbxGOIDICHVU��$ Gói dich vụ��$��	10 5 20 5q�#��[ $��1��$ GDV_TEN������ *	GOIDICHVU+ �� *SelectedGOIDICHVU+$ TwoWay=�$ PropertyChanged=�   $	 SelectionChanged��.
    �� *CommandSelectionGOIDICHVU+ �� $ cbxGOIDICHVU���� -   #��[ $/ )Resource name: MaterialDesignRaisedButton��$( 5��$��60��$��0 0 20 0q�
�������$��1q�
���   �
���   �$��2��.��  $ PagePreviousOutline=�$��20��$��20���� $��Danh sách nhân viên��#���  $��10 10 20 10q�$+ Custom=�, �	#FF2D2F4C
- �����.���� $	��480������ *ListNhanVienPhuTrach+ �� *SelectedListNhanVienPhuTrach+$ TwoWay=�$ PropertyChanged=����� .R��� $ 
Horizontal=�.+��� $��40��$��40������ *NV_ANH+�� .+��� $ 
Horizontal=�.+��� $��15(�$��10 0 0 0q�$
��Bold"�$��Center=����� *
NV_HOTEN+�� $	�� - ��$��15(�$��0 0 0 0q�$
��Bold"�$��Center=��� $��15(�$��0 0 0 0q�$
��Bold"�$��Center=����� *NV_MA+�� $ 
Horizontal=�$��2��$��Right=�.+��� -   $��btnLuuPhuTrachNhieuNV��  MaterialDesignRaisedButton#��[ $A ;Quản lý phụ trách dịch vụ theo từng nhân viên��$( 5��$��10 10 20 10q�$��35��$	��130��$��Right=�$��Bottom=�$��0q�
��� � ����� *CommandAddPhuTrachDV+���� $ wThemPhuTrach��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ TextBoxCheck=�$��0 0 5 0q�$��25��$��25���� $
��Lưu��$��0 5 0 0q��� #��[ $A ;Quản lý phụ trách dịch vụ theo từng nhân viên��$( 5��$��10 10 20 10q�$��35��$	��130��$��Right=�$��Bottom=�$��0q����	#FFCA3C2A���� *CommandClose+���� $ wThemPhuTrach��.���� $ 
Horizontal=�$��0 0 10 0q�.+�  $ CloseBox=�$��0 0 5 0q�$��25��$��25���� $��Thoát��$��0 5 0 0q�