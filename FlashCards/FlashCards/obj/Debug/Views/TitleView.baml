   M S B A M L   `   `   `  ����E  AFlashCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FlashCards.ViewsFlashCards.Views  5           FlashCards.Views.TitleView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:FlashCards.Views     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� $
��Wrap=�6    �� TextAlignment$ Center=�6(   $��28(�6?   $��0��6M   $��2��6Z   $��Center=�6n   Flash Cards!6�   �� 5   
   $��1��65   $��2��6B   $��50��6V   ��6   �� *StartFlashCards+.��6b   Start6i   �� 5   
   $��3��66   $��1��6C   $��50��6S   ��6   �� *ConfigFlashCards+.��6^   Config6f   �� 5   
   $��2��67   $��1��6D   $��50��6T   $��50��6_   $��Bottom=�6k   ��6   �� *LoadNewFlashCards+.��6�   ...6�   �� 5   
   -   5        $��LoadedFlashSet��5   u   $
��Wrap=�6   $ Center=�6(   $��18(�6?   $��2��6M   $��Center=�6Z   ��6�   �� *
FlashSet+5      5      