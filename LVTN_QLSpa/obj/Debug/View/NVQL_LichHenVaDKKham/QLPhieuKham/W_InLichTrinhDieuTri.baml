   M S B A M L   `   `   `  ����E  ALVTN_QLSpa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham0LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham  5   	   E'clr-namespace:LVTN_QLSpa.UserControlSpaLVTN_QLSpa.UserControlSpa  5   	   K    ELVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham.W_InLichTrinhDieuTri   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:LVTN_QLSpa.View.NVQL_LichHenVaDKKham.QLPhieuKham     5   	   6uc'clr-namespace:LVTN_QLSpa.UserControlSpa     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��wInLichTrinhDieuTri��5	   	     � Title$  W_InLichTrinhDieuTri��5   	   $	��680��6&   $	��800��62    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     InLichTrinhDieuTriVM � DataContext# [ 5   	   ��5   	   Z� .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
   	   	EventName$	 Loaded��6   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *
LoadWindow+   CommandParameter 5   $   ��  �� ElementName$ wInLichTrinhDieuTri��5       .��5"      � .+�5#   
   �� 
���   �$��2q�6%    �� CornerRadius$ 15 15 15 15��69   ._�5$      #  MaterialDesignThemes.Wpf.Card     UniformCornerRadius$ 15Q�6"   .��5%      � 
������� � RowDefinitions 5&      �� 5'      $
��auto �6(   68   �� 5(      6*   .+�5+      � $��0��6    � ColumnDefinitions 5,      �� 5-      61   �� 5.      $
��auto �6/   6>   .+�50      �� -   5         & "MaterialDesignToolForegroundButton#��[ 50   !   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��51   !   $
��Left=�52   !   .��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
ArrowRight=�66   $��Right=�54   2   $��	15 -3 0 0q�55   2   
���   �56   2   57      �� 58       �� Orientation$ 
Horizontal=�6%   $��1��6>   $��Right=�59      .+�5:      �� -   5           MaterialDesignOutlinedButton#��[ 5:   %    � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5;   %   $��10 15 10 10q�5<   %   $��0q�5=   %   $��40��5>   %   $��Center=�5?   %   
�������$��2q�5@   8   
��� � �$	��150��5B   %   
��� � �.��5E   "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   $��Right=�6X   .+�5F   &     $ Printer=�6>   $��0 0 10 0q�6M   $��25��6_   $��25��6j   �� 5G   &   $��In��60   $��0 5 0 0q�6:   6M   5H   #   5I      �� 5J      #��[ 6%   $/ )Resource name: MaterialDesignRaisedButton��5K   %   $��10 15 10 10q�5L   %   
�������$��2q�5O   8   
���  ��$��40��5Q   %   $	��150��5R   %   
���  ����5M   %   �� *CommandClose+��5N   %   �� $ wInLichTrinhDieuTri��.��5T   "   �� $ 
Horizontal=�6-   $��0 0 10 0q�6F   $��Right=�6X   .+�5U   &     $ CloseBox=�6>   $��0 0 10 0q�6N   $��25��6`   $��25��6k   �� 5V   &   $��Thoát��60   $��0 5 0 0q�6=   6P   5W   #   5X      5Y      5[      � 5]      $��1��6    5^      �� 5_      $
��auto �6/   6>   �� 5`      61   .+�5b      �� -   5        $��grdEditLichTrinh��5b   5   $��0��6%   .+�5c      (	  "System.Windows.Controls.DatePicker	  $��15 50 15 10q�6)   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Ngày tái liệu trình��5d   %    ( $MaterialDesignFloatingHintDatePicker#��[ 5e   %    	  SelectedDate 5f   %   �� *LTDT_NGAYDT+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5g      �� 5h      $ Đơn vị tính��6'   $��2��5i   #   $��15 10 15 10q�5j   #    & "MaterialDesignFloatingHintComboBox#��[ 5k   #    �� DisplayMemberPath$
 Name��5l   #   ��5m   #   �� *BUOI+ �� SelectedItem 5n   #   �� *SelectedBUOI+$ TwoWay=�$ PropertyChanged=�5o      �� 5p      #��[ 6%   $" MaterialDesignOutlinedButton��5q   %   $��15 15 15 10q�5r   %   $
��Lưu��5s   %   ��5t   %   �� *CommandLuuLTDT+5u      5v      � 5w      -   5         �Name$ print��5w   /   $��1��6    5x      �� 5y   "   $
��auto �60   6@   �� 5z   "   62   .+�5}      �� $��0��6)   $��0 20 0 0q�66   .+�5~   "   �� $��Sitka Subheading)�6,   $��Center=�5�   (   $��23(�5�   (   $
��Bold"�5�   (   ��5   (   �� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�5�   <   � 5�   "    5�   &   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   .+�5�   &   � $��0��6+    5�   *   �� 5�   .   $	��140 �6?   6M   �� 5�   .   6A   .+�5�   *   �� $��Sitka Subheading)�64   $��
Họ tên:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   *   $��Sitka Subheading)�64   $��15(�5�   0   $��
20 10 0 10q�6>   $��1��5�   0   ��5�   0   �� *
KH_HOTEN+$ TwoWay=�$ PropertyChanged=�5�   0   5�   '   � 5�   &   $��2��6+    5�   *   �� 5�   .   $	��140 �6?   6M   �� 5�   .   6A   .+�5�   *   �� $��Sitka Subheading)�64   $��Lần liệu trình:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   *   $��Sitka Subheading)�64   $��15(�5�   0   $��
20 10 0 10q�6>   $��1��5�   0   ��5�   0   �� *	GDV_SOLAN+$ TwoWay=�$ PropertyChanged=�5�   0   5�   '   � 5�   &   $��1��6+    5�   *   �� 5�   .   $	��140 �6?   6M   �� 5�   .   6A   .+�5�   *   �� $��Sitka Subheading)�64   $��Gói dịch vụ:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   *   $��Sitka Subheading)�64   $��15(�5�   0   $��20 10 20 10q�6>   $��1��5�   0   $
��Wrap=�5�   0   ��5�   0   �� *	GDV_TEN+$ TwoWay=�$ PropertyChanged=�5�   0   5�   '   � 5�   &   $��4��6+    5�   *   �� 5�   .   $	��140 �6?   6M   �� 5�   .   6A   .+�5�   *   �� $��Sitka Subheading)�64   $!��Bắt đầu liệu trình:��5�   0   $��15(�5�   0   $��
20 10 0 10q�6>   $��0��5�   0   �� 5�   *   $��Sitka Subheading)�64   $��15(�5�   0   $��20 10 20 10q�6>   $��1��5�   0   $
��Wrap=�5�   0   ��5�   0   �� *PDK_NGAYBDDT+ �� StringFormat$ 
dd/MM/yyyy��$ TwoWay=�$ PropertyChanged=�5�   0   5�   '   5�   #   5�      � 5�      $��1��6#    5�   "   �� 5�   &   $
��auto �64   6D   �� 5�   &   66   .+�5�   "   �� $��Sitka Subheading)�6,   $"��Liệu trình thực hiện:��5�   (   $��18(�5�   (   $
��Bold"�5�   (   $��	20 20 0 0q�5�   (   $��0��5�   (   �� 5�   "   -   5        $��lvwLTDT��5�   +   $��1��5�   +   ��5�   +   �� *ListLichTrinhDieuTri+ 5�   +   �� *SelectedLichTrinhDieuTri+$ OneWayToSource=� 5�   &     5�   *   $	 SelectionChanged��69   .
 5�   .      6D   �� *!CommandSelectedLichTrinhDieuTri+ 5�   D   �� $ lvwLTDT��5�   +    �� View 5�   &   �� 5�   *   .P�5�   .   �� $��Lần��6=    �� CellTemplate 5�   2   �� 5�   6   .R�5�   :   � .+�5�   >   �� $��20 0 0 0q�6j   $��Center=�6|   
���   ���6H   �� *LIEUTRINH.LT_STT+6�   5�   ;   5�   7   5�   /   �� 5�   .   $��Liệu trình��6=    5�   2   �� 5�   6   .R�5�   :   � .+�5�   >   �� $	��220��6k   $��15 0 0 0q�6w   $��Center=�6�   $
��Wrap=�6�   
���   ���6H   �� *LIEUTRINH.LT_MOTA+6�   5�   ;   5�   7   5�   /   �� 5�   .   $��Ngày đến��6=    5�   2   �� 5�   6   .R�5�   :   � .+�5�   >   �� $��20 0 0 0q�6�   $��Center=�6�   
���   ���6H   �� *LTDT_NGAYDT+$ 
dd/MM/yyyy��6�   5�   ;   5�   7   5�   /   �� 5�   .   $��Buổi��6=    5�   2   �� 5�   6   .R�5�   :   � .+�5   >   �� $��20 0 0 0q�6j   $��Center=�6|   
���   ���6H   �� *LTDT_THOIGIANDEN+6�   5  ;   5  7   5  /   �� 5  .   $��Thực hiện��6=    5  2   �� 5  6   .R�5  :   � .+�5	  >   �� $��20 0 0 0q�6q   $��Center=�6�   
���   ���6H   �� *LIEUTRINH.LT_THOIGIANTH+6�   5
  ;   5  7   5  /   5  +   5  #   5     5     5     5     5     5     5     5     