   M S B A M L   `   `   `  ����M  IГороскопп, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ГороскоппГороскопп  5   	   #    Гороскопп.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Гороскопп     5   	     � Title$  Календарь��5   	   $	��500��6   $	��500��6(    � 
ResizeMode$ NoResize=�5	   	   .��5
      � ��5   
   �� 5       �� ImageSource$&  /значек_зодиака.png��6   .+�5   
   �� -   5         ��Name$ lblDate��5      $K��EВведите дату рождения от 1900 до 2025 года��6!   $	��Top=�6V   $��	35,10,0,0q�6n   $��20(�6�   
�������6�   �� 5   
   -   5         ��Name$ txtYear��5      $��0,50,0,0q�6#   $	��Top=�65   $��30��6M   $��50��6Y   $��18(�6�   6�   �� 5   
   -   5         ��Name$ btnNext��5      $��
Далее��6"   $
��Left=�62   $��420,420,0,0q�6M   $	��Top=�6b   $y�Hidden=�6z   6�   �� 5   
   -   5        $ btnClose��5      $��
Выход��6#   $
��Left=�63   $��
40,420,0,0q�6N   $	��Top=�6b   $y�Hidden=�6z   6�   �� 5   
   -   5         ��Name$ 	imgAnimal��5      $��/Animals.png��6#   $
��Left=�69   $	��280��6T   $��
75,108,0,0q�6a   $	��Top=�6u   $	��335��6�   $y�Hidden=�6�   5      5      5      