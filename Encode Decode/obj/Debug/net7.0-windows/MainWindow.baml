   M S B A M L   `   `   `  ����H  DEncode Decode, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Encode_DecodeEncode_Decode  5   	       Encode_Decode.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Encode_Decode     5   	     � Icon$  /assets/logoencrypt.ico��5   	    � Title$ Decoder/Encoder v.3.0��5	   	   $	��450��6'   $	��800��64   $	��450��6@   $	��800��6P   .��5      � $
��auto��6   .+�5   
   �� $
��auto��6   $
��Left=�6"   ��5      �� 5       �� ImageSource$ \Assets\unlocked.png��6    j� Stretch$ UniformToFill=�6@   .+�5      �� $��Klartext��6   $��20q�6'   $��Center=�63   �� 5      -   5         ��Name$ 
EncodeText��5       �� TextWrapping$
 Wrap=�6*   $��Bottom=�6>   
�������
�������$��2q�5   -   $
��Left=�5      $��300px��61   $��100px��6?   $
��20pxq�6N   �� 5      -   5         ��Name$ KeyTextEncode��5      $	��Key��6+   $��Center=�69   $y�Hidden=�6V   
�������6j   �� 5       -   5        $ 	KeyEncode��5       $��300px��6)   $
��10pxq�67   $y�Hidden=�6E   �� 5"      -   5         ��Name$ EncodeButton��5"      $	��100��6+   $��Encode��67   6H   5$      �� 5'   
   $
��auto��6   $��right=�6"   ��5*      �� 5,      $ /assets/locked.png��6   $ UniformToFill=�6>   .+�5/      �� $��Verschlüsselter Text��6   $��20q�63   $��Center=�6?   �� 52      -   5        $ 
DecodeText��52      $��Bottom=�6*   $
 Wrap=�6E   
�������
�������$��2q�53   D   $��right=�54      $��300px��62   $��100px��6@   $
��20pxq�6O   �� 56      -   5        $ KeyTextDecode��56      $	��Key��6+   $��Center=�69   $y�Hidden=�6V   
�������6j   �� 58      -   5        $ 	KeyDecode��58      $��300px��6)   $
��10pxq�67   $y�Hidden=�6E   �� 5:      -   5        $ DecodeButton��5:      $	��100��6+   $��Decode��67   6H   5;      �� 5>   
   .+�5?      �� $#��Decoder/Encoder v.3.0 by IRay��6   $��Center=�6<   $
��auto��6Y   
�������$
��auto��5@   &   
���   �$��2q�6H   5A      �� 5D   
   $	��120��6   $��Center=�6!   $��Bottom=�6>   $	��200��6Y   
�������.+�5G      �� $��Algorythmus��6   $��Center=�6*   $��Stretch=�6G   	� 5I      -	   5         	�Name$ Caesar��5I      $��Cäsar��6*   	 d� 	IsChecked$
	 TrueY�6:   $
��Left=�5J      	� 5K      -
   5        $ Vignere��5K      $��Vignere��6+   $
��Left=�5L      5N      5P      5Q      