   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn.LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn  5      B    <LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn.UC_HoSoBenhAn   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:LVTN_QLSpa.View.NVQL_KhamVaDieuTri.QL_HSBenhAn     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��wHoSoBenhAn��5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5        HoSoBenhAnVM � DataContext# [ 5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wHoSoBenhAn��5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $��0.95* �6   6/   �� 5      6!   .+�5"   
   � $��0��6   $��5q�6   
 � RowDefinitions
 5#      �� 5$      $
��auto �6    60   �� 5%      6"   .+�5'      �� -   5        $��txtKeySearch��5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Nhập từ khóa tìm kiếm��5'       % !MaterialDesignFloatingHintTextBox#��[ 5(      $��15 10 15 10q�5)      $��0��5*      $
��Left=�5+      $	��300��61   ��5-      �� *	KeySearch+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6c    5.        5/      $ TextChanged��6%   . 50         60   �� *KeySearchCommand+ 51   0   �� $ txtKeySearch��52      .��53   *   54      #  MaterialDesignThemes.Wpf.Card  56         UniformCornerRadius$ 10Q�6"   $��1��6;   .��57      �� .+�58      ��  �� Orientation$ 
Horizontal=�6!   $��15 15 10 10q�6:   $��0��6O   .+�59      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5:      �� $)��#Danh sách dịch vụ đăng ký: ��6(   $
��Bold"�6K   $��15(�6]   6m   5;      5<      �� 5=      $��	10 5 10 5q�6    $	��0.1q�63   
���   �$��1��6]   6l   �� 5>      -   5        $��lvwPDK��5@   #   $	��720��5A   #   ��5>      �� *ListPhieuDangKy+ �� SelectedItem 5?   #   �� *SelectedPhieuDangKy+$ OneWayToSource=� 5B        5C      $ SelectionChanged��6-   . 5D   "      68   �� *CommandSelectedPhieuDangKy+ 5E   $   �� $ lvwPDK��5F       �� View 5H      �� 5I      .P�5O   "   �� $��Số PDK��61    �� CellTemplate 5P   &   �� 5Q   *   .R�5R   .   � .+�5S   2   �� $��20 0 0 0q�6U   $��Center=�6g   ��6<   �� *	PDK_STT+6�   5T   /   5U   +   5W   #   �� 5X   "   $��Gói dịch vụ��61    5Y   &   �� 5Z   *   .R�5[   .   � .+�5\   2   �� $��20 0 0 0q�6_   $��Center=�6q   ��6<   �� *GOIDICHVU.GDV_TEN+6�   5]   /   5^   +   5`   #   �� 5a   "   $��Họ tên KH��61    5b   &   �� 5c   *   .R�5d   .   � .+�5e   2   �� $��20 0 0 0q�6`   $��Center=�6r   ��6<   �� *KHACHHANG.KH_HOTEN+6�   5f   /   5g   +   5i   #   �� 5j   "   $��Ngày đăng ký��61    5k   &   �� 5l   *   .R�5m   .   � .+�5n   2   �� $��20 0 0 0q�6s   $��Center=�6�   ��6<   �� *
PDK_NGAYDK+ �� StringFormat$ 
dd/MM/yyyy��6�   5o   /   5p   +   5r   #   �� 5s   "   $��Trạng thái��61    5t   &   �� 5u   *   .R�5v   .   � .+�5w   2   �� $��20 0 0 0q�6[   $��Center=�6m   ��6<   �� *PDK_TRANGTHAI+6�   5x   /   5y   +   5{   #   5}      5      5�      5�      5�      � 5�   
   $��1��6   $��5q�6   
 5�      �� 5�      $
��auto �6    60   �� 5�      6"   �� 5�      6"   .+�5�      ��    MaterialDesignOutlinedButton#��[ 6   $��
5 10 15 10q�5�      $��35��5�      $��0��5�      $
��Left=�5�      ��5�      �� *CommandXemPhieuDieuTri+.��5�      �� $ 
Horizontal=�6   $��0 0 10 0q�66   .+�5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Eye=�6.   $��0 0 10 0q�69   $��25��6K   $��25��6V   �� 5�      $��Xem hồ sơ��6    $��0 5 0 0q�61   6D   5�      5�        5�      $��1��6"   $ 10Q�6/   .��5�      � 
 5�      �� 5�      $
��auto �6(   68   �� 5�      $
��auto �6(   68   �� 5�      6*   .+�5�      � 	 5�      �� 5�      $	��100 �6/   6=   �� 5�      61   �� 5�      61   �� 5�      61   .+�5�      �� $[��UE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Avatars\Customer\man.png��6    $��60��5�       $��60��5�       $��0��5�       $��20 10 20 20q�5�       �� 5�      $��1��6%   $��10 20 10 10q�65   .+�5�      ��  $  MaterialDesignHeadline6TextBlock#��[ 6(   ��5�   0   �� *KH_TEN+5�      �� 5�      $ 
Horizontal=�6)   .+�5�   "   ��    MaterialDesignBody2TextBlock#��[ 6,   $��Mã KH: ��5�   (   $��0 10 0 0q�5�   (   5�   #   �� 5�   "   #��[ 6,   $��0 10 0 0q�5�   (   ��5�   (   �� *KH_MA+5�   #   5�      5�      �� 5�      $��2��6%   $��20 10 10 10q�65   .+�5�      �� $ 
Horizontal=�6)   $��0 5 0 0q�6B   $
��Left=�6S   $��Center=�6n   .+�5�   "     $ 
PhoneCheck=�6:   $��0 10 5 0q�6L   �� 5�   "    " MaterialDesignCaptionTextBlock#��[ 6,   $��0 6 0 0q�5�   ,   ��5�   ,   �� *KH_SDT+5�   #   5�      �� 5�      $ 
Horizontal=�6)   $��0 5 0 0q�6B   $
��Left=�6S   $��Center=�6n   .+�5�   "     $ GenderMaleFemale=�6:   $��0 10 5 0q�6R   �� 5�   "   #��[ 6,   $��0 6 0 0q�5�   ,   ��5�   ,   �� *KH_GIOITINH+5�   #   5�      5�      �� 5�      $��3��6%   $��10 10 10 10q�65   .+�5�      �� $ 
Horizontal=�6)   $��0 5 0 0q�6B   $
��Left=�6S   $��Center=�6n   .+�5�   "     $
 Cake=�6:   $��0 8 5 0q�6F   �� 5�   "   #��[ 6,   $��0 6 0 0q�5�   ,   ��5�   ,   �� *KH_NGAYSINH+$ 
dd/MM/yyyy��5�   #   5�      �� 5�      $ 
Horizontal=�6)   $��0 5 0 0q�6B   $
��Left=�6S   $��Center=�6n   .+�5�   "     $ Email=�6:   $��0 10 5 0q�6G   �� 5�   "   #��[ 6,   $��0 6 0 0q�5�   ,   ��5�   ,   �� *
KH_EMAIL+5�   #   5�      5�      5�      �� 5�      $��	10 0 10 5q�6    $	��0.1q�63   
���   �$��1��6]   6l   �� 5�      $��2��6#   .��5�      �� -   5        $��lbxPDT��5�   "   $
��1100��5�   "   ��5�   "   �� *ListPhieuDieuTri+ 5�   "   �� *SelectedPhieuDieuTri+$ OneWayToSource=� 5�        5�   "   $ SelectionChanged��61   . 5�   &      6<   �� *CommandSelectedPhieuDieuTri+ 5�   $   �� $ lbxPDT��5�   #   ��5�      �� 5�   "   .R�5�   &   � $��	10 5 0 10q�6+   	 5�   *   �� 5�   .   �� 5�   .   �� 5�   .   $	��360 �6?   �� 5�   .   .+�5�   *   �� $Y��SE:\LuanVanTotNghiep\Project\App\LVTN_QLSpa\LVTN_QLSpa\Assets\Icons\pay\expenses.png��60   $��35��5�   4   $��35��5�   4   6B   �� 5�   *   $��30 0 0 0q�65   $��1��5�   9   .+�5�   .   �� $ 
Horizontal=�69   .+�5�   2   �� $��16(�6<   $��65��6J   $��Số: ��6U   �� 5�   2   $��16(�6<   ��6J   �� *	PDT_STT+5   /   �� 5  .   $ 
Horizontal=�69   .+�5  2   �� $��16(�6<   $��65��6J   $��Ngày: ��6U   �� 5  2   $��16(�6=   ��6K   �� *PDT_NGAYLAP+$ dd/MM/yyyy hh:mm��5  /   �� 5  .   $ 
Horizontal=�69   .+�5  2   �� $��16(�6<   $��65��6J   $��Dịch vụ: ��6U   �� 5  2   $��16(�6=   ��6K   �� *	GDV_TEN+5  /   5	  +   �� 5
  *   $��50 0 0 0q�65   $��2��5  9   .+�5  .   �� $ 
Horizontal=�69   .+�5  2   �� $��16(�6<   $	��100��6J   $��Chuẩn đoán: ��6V   �� 5  2   $
��Wrap=�6<   $	��180��6P   $��16(�6\   ��6j   �� *PDT_CHUANDOAN+5  /   �� 5  .   $ 
Horizontal=�69   .+�5  2   �� $��16(�6<   $��Lời dặn: ��6J   �� 5  2   $
��Wrap=�6<   $	��200��6P   $��16(�6\   ��6j   �� *
PDT_LOIDAN+5  /   �� 5  .   $ 
Horizontal=�69   .+�5  2   �� $��16(�6<   $��
Ghi chú: ��6J   �� 5  2   $
��Wrap=�6<   $	��200��6P   $��16(�6\   ��6j   �� *
PDT_GHICHU+5  /   5  +   �� 5  *   $��45 0 0 0q�65   $��3��5  9   .+�5  .     $��30��6}   $��30��6�    6F   �� *Icon+��6\   �� *	ColorIcon+6�   5  +   5  '   5  #   5      5!     5"     5#       5%     $��2��6"   $ 10Q�6/   $��0 5 0 0q�6H   .��5&     � 
 5'     �� 5(     $
��auto �6(   68   �� 5)     $
��auto �6(   68   �� 5*     6*   .+�5,     �� $��Toa thuốc��6    $
��Bold"�61   $��	10 10 0 0q�6C   $��15(�6V   6f   �� 5-     $��	10 5 10 5q�6    $	��0.1q�63   
���   �$��1��6]   6l   �� 5.     $��2��6G   ��6#   �� *ListChiDinh+��5/     �� 50     .R�51  "   � 
 52  &   �� 53  *   $
��auto �68   6H   �� 54  *   $
��auto �68   6H   .+�57  &   � $��0��6+   	 58  *   �� 59  .   $��1* �6?   6L   �� 5:  .   $��1* �6?   6L   .+�5=  *   �� $ 
Horizontal=�65   $��0��6N   .+�5>  .   ��  �� TextAlignment$ Center=�5?  4   $
��Wrap=�5@  4   $��15(�5A  4   $��25,0,0,0q�6B   $��Center=�5B  4   $��Sitka Subheading)�5C  4   $
��Bold"�5D  4   $��Italic$�5E  4   ��5>  8   �� *T_STT+5E  4   �� 5F  .   $��Sitka Subheading)�5G  4   $��Center=�5H  4   $��17(�5I  4   $
��Bold"�5J  4   $��Italic$�5K  4   ��5F  8   �� *T_TEN+$ TwoWay=�$ PropertyChanged=�5L  /   �� 5M  .   $��Sitka Subheading)�5N  4   $��Center=�5O  4   $��17(�5P  4   $
��Bold"�5Q  4   $��Italic$�5R  4   ��5M  8   �� *	DVT_TEN+$ TwoWay=�$ PropertyChanged=�5S  /   5T  +   �� 5V  *   $ 
Horizontal=�65   $��1��6N   .+�5W  .   �� $��Số lượng: ��68   $��Sitka Subheading)�5X  5   $��Center=�5Y  5   $��15(�5Z  5   5[  /   �� 5\  .   $��Sitka Subheading)�5]  5   $��Center=�5^  5   $��15(�5_  5   ��5\  8   �� *
CD_SOLUONG+$ TwoWay=�$ PropertyChanged=�5`  /   5a  +   5b  '   � 5d  &   $��1��6+   $��0 0 0 10q�68   .+�5e  *   �� $ 
Horizontal=�65   .+�5f  .   �� $��Sitka Subheading)�5g  5   $��Center=�5h  5   $��15(�5i  5   $��25,0,0,0q�5j  5   ��5f  8   �� *CD_LIEUDUNG+$ TwoWay=�$ PropertyChanged=�5k  /   �� 5l  .   $��Sitka Subheading)�5m  5   $��Center=�5n  5   $��15(�5o  5   ��5l  8   �� *CD_CACHDUNG+$ TwoWay=�$ PropertyChanged=�5p  /   5q  +   5r  '   5s  #   5t     5v     5w     5y     5z     5{     5|     