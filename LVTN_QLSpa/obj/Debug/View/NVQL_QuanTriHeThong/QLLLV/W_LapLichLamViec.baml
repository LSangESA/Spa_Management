   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV)LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5
   	   @    :LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV.W_LapLichLamViec   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:LVTN_QLSpa.View.NVQL_QuanTriHeThong.QLLLV     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5
   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  w_LapLichLamViec��5   	   $	��650��5      $	��710��6'    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     LapLichLamViecVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ w_LapLichLamViec��5      .��5!      � .+�5"   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5#      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5$      �  � RowDefinitions 5%      �� 5&      $
��auto �6(   68   �� 5'      $
��auto �6(   68   �� 5(      6*   .+�5*      ��  �� Orientation$ 
Horizontal=�6!   $��5 10 0 0q�6:   $��0��6L   .+�5+      �� $a��[E:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\calendar\appointment.png��6    $��35��5,       $��35��6+   $��10 0 0 0q�5-       64   �� 5.      $��Xếp lịch làm việc��6$   $
��Bold"�5/   $   $��20(�50   $   $��Center=�51   $   $��10 0 0 0q�52   $   68   �� 53         MaterialDesignOutlinedButton#��[ 6!    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��54   !   $)��#Lập lại lịch cho tuần tới��56   !   $	��180��57   !   $��0 2 0 0q�58   !   $��
280 0 20 0q�59   !   
�������$��1q�5:   4   
���   �
���   ���55   !   �� *CommandLapLichTuanToi+5=      5?      �� 5A      $��5q�6    $��1q�5B      
���   �$��1��5D      5E      � 5G      $��2��6    5H      �� 5I      $
��auto �6,   6<   �� 5J      $
��auto �6,   6<   �� 5K      $
��auto �6,   6<   �� 5L      6.   .+�5O      � $��0��6    � ColumnDefinitions 5P      �� 5Q   "   65   �� 5R   "   65   .+�5U      �� $��0��6)   .+�5V   "   �� -   5        $��cbxCLV��5Y   +   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ca làm việc��5V   +    & "MaterialDesignFloatingHintComboBox#��[ 5W   +   $��30 10 30 10q�5X   +   ��5Z   +   �� *	CALAMVIEC+ �� SelectedItem 5[   +   �� *SelectedCALAMVIEC+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� 5\   &     5]   *   $	 SelectionChanged��69   .
 5^   .      6D   �� *CommandSelectedCLV+ 5_   H   �� $ cbxCLV��5`   +   ��5b   &   �� 5c   *   .R�5d   .   �� $ 
Horizontal=�69   .+�5e   2   �� ��6<   �� *	CLV_TEN+6W   �� 5f   2   $��: ��6<   6H   �� 5g   2   ��6<   �� *CLV_GIOBATDAU+ �� StringFormat$ hh\:mm��6u   �� 5h   2   $	�� - ��6<   6I   �� 5i   2   ��6<   �� *CLV_GIOKETTHUC+$ hh\:mm��6w   5j   /   5k   +   5m   #   (  "System.Windows.Controls.DatePicker  5n   "   -   5        $��dtpkNgay��5p   -   $��30 10 30 10q�5n   -   $ 
Ngày làm��5o   -    ( $MaterialDesignFloatingHintDatePicker#��[ 5q   -      SelectedDate 5r   -   �� *
N_THOIGIAN+$ TwoWay=�$ PropertyChanged=� 5s   &     5t   *   $	 SelectedDateChanged��69   .
 5u   .      6D   �� *CommandSelectedDate+ 5v   H   �� $ dtpkNgay��5w   +   5y   #   5z      �� 5|      $ Ghi chú��6&    % !MaterialDesignFloatingHintTextBox#��[ 5}   %    �� AcceptsReturn . $��1��5   &    �� TextWrapping$
 Wrap=�5�   %   $	��Top=�5�   &   " �� VerticalScrollBarVisibility$
 Auto=�5�   %   $��30 10 30 10q�5�   &   $��93��5�   &   ��5�   %   �� *
LLV_GHICHU+$ PropertyChanged=�$ TwoWay=�5�      �� 5�      $��
20 10 20 5q�6$   $��1q�5�   $   
���   �$��1��5�   $   5�      � 5�      $��2��6    5�      �� 5�   "   65   �� 5�   "   $
��auto �63   6B   �� 5�   "   65   .+�5�      � $��0��6#   .+�5�   "   �� .+�5�   &   �� -   5        $��cbxPhong��5�   /   $ Chọn phòng��5�   /   #��[ 5�   /    �� DisplayMemberPath$
 P_SO��5�   /   $��	30 5 10 5q�5�   /   ��5�   /   �� *PHONG+ 5�   /   �� *SelectedPHONG+$ TwoWay=�$ PropertyChanged=� 5�   *     5�   .   $	 SelectionChanged��6=   .
 5�   2      6H   �� *CommandSelectedPhong+ 5�   H   �� $ cbxPhong��5�   /   5�   '   �� 5�   &   -   5        $��	cbxVaiTro��5�   /   $ Vai trò��5�   /   #��[ 5�   /   $ VT_TEN��5�   /   $��	30 5 10 5q�5�   /   ��5�   /   �� *VAITRO+ 5�   /   �� *SelectedVAITRO+$ TwoWay=�$ PropertyChanged=� 5�   *     5�   .   $	 SelectionChanged��6=   .
 5�   2      6H   �� *CommandSelectedVaiTro+ 5�   @   �� $ 	cbxVaiTro��5�   /   5�   '   � 5�   &   $��	30 5 10 5q�6+   $	��250��6>   .+�5�   *   �� 
���   �$	��0.5q�6E   ._�5�   .   �� ��66   �� *ListNhanVien+ 5�   6   �� *SelectedNhanVien+$ TwoWay=�$ PropertyChanged=���5�   2   �� 5�   6   .R�5�   :   �� $ 
Horizontal=�6E   $��40��6^   .+�5�   >   A� $��35��6F   $��35��6Q   $��5 0 0 0q�6]   $��Center=�6n   ��5�   B   �� 5�   F    �� ImageSource 6Q   �� *NV_ANH+5�   ?   �� 5�   >   .+�5�   B   �� $ 
Horizontal=�6M   .+�5�   F   �� $
��Left=�5�   L   
���   �$��5 0 0 0q�5�   L   ��5�   P   �� *NV_TEN+5�   _   �� 5�   F   $	�� - ��6P   $
��Left=�5�   P   
���   �5�   e   �� 5�   F   $
��Left=�5�   L   
���   �$��0 0 5 0q�5�   L   ��5�   P   �� *VT_TEN+5�   _   5�   C   �� 5�   B   $
��Left=�5�   L   
���   �$��5 5 0 0q�5�   L   ��5�   L   �� *CM_TEN+5�   _   5�   ?   5�   ;   5�   7   5�   /   5�   +   5�   '   5�   #   5�      � 5�      $��1��6#   $��Center=�63   .+�5�   "   �� $��0 80 0 0q�6-   .+�5�   &   ��   MaterialDesignRaisedButton#��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�   -   $��
10 0 10 10q�5�   -   ���	#FF2D2F4C$��0q�5�   D   ��5�   -   �� *CommandMoveRight+.��5�   *   '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$ ChevronRight=�6B   $��20��6V   $��20��6a   5�   '   �� 5�   &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�   -   $��
10 0 10 10q�5�   -   ���	#FF2D2F4C$��0q�5�   D   ��5�   -   �� *CommandMoveLeft+.��5�   *   	  $ ChevronLeft=�6B   $��20��6U   $��20��6`   5�   '   �� 5�   &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�   -   $��
10 0 10 10q�5�   -   ���	#FF2D2F4C$��0q�5�   D   ��5�   -   �� *CommandMoveRightAll+.��5�   *   	  $ ChevronDoubleRight=�6B   $��20��6\   $��20��6g   5�   '   �� 5�   &   #��[ 6-   $/ )Resource name: MaterialDesignRaisedButton��5�   -   $��
10 0 10 10q�5�   -   ���	#FF2D2F4C$��0q�5�   D   ��5�   -   �� *CommandMoveLeftAll+.��5�   *   	  $ ChevronDoubleLeft=�6B   $��20��6[   $��20��6f   5�   '   5�   #   5�      � 5�      $��2��6#   .+�5�   "   �� .+�5�   &   �� $ 
Horizontal=�61   .+�5   *   �� $	��(*)��64   
���  ��$��	10 15 0 5q�5  ,   6A   �� 5  *   $��	5 15 30 5q�64   $��57��5  (   $	��255��5  ,   $
��Wrap=�5  (   ��5  (   �� *GhiChuSucChuaPhong+5  +   5  '   � 5  &   $��
10 20 30 5q�6+   $	��250��6?   .+�5  *   �� 
���   �$	��0.5q�6E   ._�5  .   �� -   5        $��lbxListNhanVienXepLich��5  6   ��5  6   �� *ListNhanVienXepLich+ 5  6   �� *SelectedNhanVienXepLich+$ TwoWay=�$ PropertyChanged=���5  2   �� 5  6   .R�5  :   �� $ 
Horizontal=�6E   $��40��6^   .+�5  >   A� $��35��6F   $��35��6Q   $��5 0 0 0q�6]   $��Center=�6n   ��5  B   �� 5  F    6Q   �� *NV_ANH+5  ?   �� 5  >   .+�5  B   �� $ 
Horizontal=�6M   .+�5  F   �� $
��Left=�5  L   
���   �$��5 0 0 0q�5  L   ��5  P   �� *NV_TEN+5  _   �� 5  F   $	�� - ��6P   $
��Left=�5  L   
���   �5   a   �� 5!  F   $
��Left=�5"  L   
���   ���5!  P   �� *VT_TEN+5#  a   5$  C   �� 5%  B   $
��Left=�5&  L   
���   �$��5 5 5 0q�5(  L   ��5%  L   �� *CM_TEN+5(  _   5)  ?   5*  ;   5+  7   5-  /   5.  +   5/  '   50  #   51     52     �� 54     $ 
Horizontal=�6%   $��3��55     $��Right=�56     .+�57     �� #��[ 6%   $/ )Resource name: MaterialDesignRaisedButton��58     $��10 10 10 10q�59     $��35��5:     $	��120��5;     $��Right=�5=     $��Bottom=�5>     $��0q�69   ���	#FF2D2F4C��5<     �� *CommandAddLLV+.��5?  "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5@  &   	  $ ContentSaveOutline=�6>   $��0 0 10 0q�6X   $��25��6j   $��25��6u   �� 5A  &   $
��Lưu��60   $��0 4 0 0q�6;   6N   5B  #   5C     �� 5D     #��[ 6%   $/ )Resource name: MaterialDesignRaisedButton��5E     $��10 10 10 10q�5F     $��35��5G     $��Right=�5J     $	��120��5K     $��Bottom=�5L     $��0q�69   ���	#FFCA3C2A��5H     �� *CommandCloseLLV+��5I     �� $ w_LapLichLamViec��.��5M  "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   .+�5N  &   	  $ CloseCircle=�6>   $��0 0 10 0q�6Q   $��25��6c   $��25��6n   �� 5O  &   $��Đóng��60   $��0 4 0 0q�6<   6O   5P  #   5Q     5R     5S     5T     5U     5V     5W     5X     