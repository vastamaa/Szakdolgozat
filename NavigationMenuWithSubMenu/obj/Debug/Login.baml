   M S B A M L   `   `   `  ����J  FMenuWithSubMenu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MenuWithSubMenuMenuWithSubMenu  5   	       MenuWithSubMenu.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MenuWithSubMenu     5   	   ���#FFFF76  � 
ResizeMode$  NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Litera Login��5   	   $	��240��6   $	��260��6+    � Icon$ Assets/favicon.ico��67   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��Login��6   $��10q�6"   $��10q�6.   
�������
���   �$��14(�6g   $��Medium"�6u   .��5      ��  � 	Resources 5       �� 
TargetType �� Property �� Value��%x   '��       �� 5      " ��6   .�5      ��  � ��
 �   �67   �� 5       � ��$ 14(�65   5      5      .+�5      �� 	Username:6'   �� 5      -   5        	 ��Name$	 
tbUsername��5      �� 5      	Password:6'   G� 5      -   5        
 G�Name$
 
tbPassword��5      $
��Left=�62   $��0,0,0,0q�6M   $	��194��6^   $��22��6j   $	��Top=�6v   �� 5      -   5         ��Name$ 	btnSignIn��5   -   $��0q�6   $��55, 20, 55, 0q�6@   .��6o   
Sign in!6y   5       5!      5"      5#      