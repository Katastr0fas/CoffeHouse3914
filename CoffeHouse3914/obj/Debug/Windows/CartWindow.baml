   M S B A M L   `   `   `  ����I  ECoffeHouse3914, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CoffeHouse3914.WindowsCoffeHouse3914.Windows  5   	   '    !CoffeHouse3914.Windows.CartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CoffeHouse3914.Windows     5   	     � Title$  
CartWindow��5   	   $	��800��6   $
��1200��5	   	   .��5
      � 
����d� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BtnBack��5      $��
Назад��5      $��20(�5      $��40��5      $��90��5      $
��Left=�5      $��Center=�5      6,   �� 5   
   -   5         ��Name$ 
LvCartList��5      $��2��5      $��Disabled=�5      
����d���5      �� 5      .R�5       � 5!      ��5$      �� 5%      .R�5&      �� 
���   �$��1q�5'      $��5q�5(      $	��200��5)      $	��300��5*      ._�5+      �� .+�5,      �� $	��170��6$   $	��200��5-   $   $
��Fill=�5.   $   ��5/   "   �� 50   &    �� Path$ 	PhotoPath�6.    �� TargetNullValue 51   *   ��52   .   /Res/null.jpg��6I   54   '   56      �� 57      $��18(�58   (   $
��Bold"�59   (   $��10 0 0 0q�5:   (   $
��Wrap=�5;   (   ��57   (   �� *Title+5;   (   �� 5=      $��18(�5>   (   $
��Bold"�5?   (   $��10 0 0 0q�5@   (   ��5=   (   �� *Price+5@   (   �� 5A       ��Name$
 Cart��6)   $��Right=�67   $��Center=�6S   $��0 0 5 5q�6n   .+�5B   "   �� $ DellProduct��6)   -   5        $
��Dell��5C   )   $��40��68   $��40��6C   6O   5E      5F      5G      5H      5K      5L      5M      