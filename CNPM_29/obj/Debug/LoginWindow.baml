   M S B A M L   `   `   `  ����B  >CNPM_29, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CNPM_29CNPM_29  5   	       CNPM_29.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CNPM_29     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   .��5	      �  � LayoutTransform 5
   
   �� 5      -   5        MyScaleTransform�� �� ScaleX$ 1Q�5   7    �� ScaleY$ 1Q�6B   .+�5   
   A� ���#FFEB3B$	��300��6!   $	��300��6-   $	��Top=�6:   $
��Left=�6R   $��-150,-150,0,0q�6m   A� 5   
   ���#FF5722$	��300��6!   $	��300��6-   $��Bottom=�6:   $��Right=�6U   $��0,0,-70,-120q�6q   �� 5   
   
������� �� CornerRadius$ 10��5      $��Center=�5      $��Center=�5      $	��300��5      $	��270��6   ._�5      �� $��Center=�6   $��Center=�64   $��10q�6Q   .+�5      ��  �� Padding$ 10q�6   $ 5��6&   $	��250��67   $��Center=�6C   ._�5      �� $��LOGIN��6    $
��Bold"�5       $��28(�5       $��Center=�5       ���	#FF638FE65       5      �� 5      $	��250��6   $��50��6)    �� Orientation$ 
Horizontal=�65   .+�5!      �� $��\Assets\user.png��6   $��30��66   $��30��6A   �� 5"      -   5         ��Name$ txtUsername��5"      $	��250��63   $��30��6?   $��0,0,0,1q�5#      $��18(�5$      $��
UltraLight"�6(   $��	0,10,0,10q�5%      5'      5(      �� 5*      $	��250��6   $��50��6)   $ 
Horizontal=�65   .+�5+      �� $��\Assets\padlock.png��6   $��30��69   $��30��6D   G� 5,      -   5         G�Name$ txtPassword��5,   "   $	��250��67   $��30��6C   $��0,0,0,1q�5-      $��18(�5.      $��
UltraLight"�6,   $��0,0,0,10q�5/      51      52      �� 55      $��FORGOT YOUR PASSWORD��6   $��12(�56      $��Right=�57      
�������$��	0,10,0,20q�59      �� 5;      -   5        $��Login��5;      $��80��6)   $��40��64   $��14(�5<      
���������5>      �� 5?      	 �� 
TargetType"	 ��6*   .R�5@      �� ���	#FF638FE6$ 20��6<   ._�5A   "   �� $��Center=�63   $��Center=�6P   5B      5C      5E      5H      5I      5J      5K      