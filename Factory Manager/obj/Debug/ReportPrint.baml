   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   h dSAPBusinessObjects.WPF.Viewer, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304tRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.ViewerSAPBusinessObjects.WPF.Viewer 5   	    Factory Manager!   Factory_Manager.ReportPrint   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   eViewerRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.Viewer     5   	     � Title$K  Eค้นหาใบคำสั่งที่จะพิมพ์��5   	   $	��301��6)   $	��677��66   ���	#FFE6E6E6 � 
ResizeMode$ NoResize=�6Y    � WindowStartupLocation$ CenterScreen=�6o    � Icon$ image/Fm.png��6�   .��5      � .+�5   
   �� $?��9เลือกประเภทใบคำสั่ง��6   $
��Left=�60   $��
465,18,0,0q�6K   $	��Top=�6_   $	��159��6w   $	��168��6�   $��16(�6�   �� 5	   
   -   5         ��Name$ printBtn��5	      $-��'พิมพ์ใบคำสั่ง��6#   $
��Left=�6;   $��230,221,0,0q�6V   $	��Top=�6k   $��94��6�   $��16(�6�   6�   �� 5
   
   $i��cเลือกประเภทการค้นหาและกรอกคำค้นหา��6   $
��Left=�6<   $��	84,10,0,0q�6W   $	��Top=�6j   $��16(�6�   	� 5   
   -   5         	�Name$ orderNo��5      $!��ลำดับสั่ง��6'   $
��Left=�6;   $��	33,50,0,0q�6V   $	��Top=�6i   $��16(�6�   $��93��6�    	� 	GroupName$ g1��6�   	� 5   
   -   5        $ 	receiveNo��5      $3��-เลขที่ใบรับสั่ง��6)   $
��Left=�6C   $��	32,74,0,0q�6^   $	��Top=�6q   $��16(�6�   $	��106��6�   $ g1��6�   	� 5   
   -   5        $ 
recordDate��5      $*��$วันที่บันทึก��6*   $
��Left=�6A   $��	32,95,0,0q�6\   $	��Top=�6o   $��16(�6�   $	��106��6�   $ g1��6�   	� 5   
   -   5        $ 
finishDate��5      $��กำหนดส่ง��6*   $
��Left=�6=   $��
32,120,0,0q�6X   $	��Top=�6l   $��16(�6�   $	��106��6�   $ g1��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ dateCalendar��5      $
��Left=�6)   $��
144,40,0,0q�6D   $	��Top=�6X   
 �� Now	   SelectedDate#	 Z 6p   �� 5   
   -   5        
 ��Name$
 queryString��5      $
��Left=�6'   $��23��6B   $��
33,222,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��178��6�   $��16(�6�   �� 5   
   -   5         ��Name$ dateCalendarText��5      $6��0กรุณาเลือกวันที่��6*   $
��Left=�6E   $��339,104,0,0q�6`   $	��Top=�6u   $��16(�6�   	� 5   
   -	   5        $	 cut��5      $!��ใบสั่งตัด��6#   $
��Left=�67   $��
477,54,0,0q�6R   $	��Top=�6f   $��16(�6~   $��93��6�   $ g2��6�   	� 5   
   -
   5        $
 blow��5      $$��ใบสั่งเป่า��6$   $
��Left=�69   $��
477,78,0,0q�6T   $	��Top=�6h   $��16(�6�   $��93��6�   $ g2��6�   	� 5   
   -   5        $ print��5      $'��!ใบสั่งพิมพ์��6%   $
��Left=�6;   $��477,104,0,0q�6V   $	��Top=�6k   $��16(�6�   $��93��6�   $ g2��6�   	� 5   
   -   5        $ material��5      $0��*ใบเบิกวัตถุดิบ��6(   $
��Left=�6A   $��477,129,0,0q�6\   $	��Top=�6q   $��16(�6�   $	��110��6�   $ g2��6�   5      5      