   M S B A M L   `   `   `  ����A  =Watsap, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WatsapWatsap  5   	       Watsap.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Watsap     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignWindow#��[  5	   	     � Title$  
MainWindow��5
   	   $	��400��6   $	��500��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��3* �6   .+�5   
   �� $��/watsap.png��6   $
��Auto��6%   $��10q�63   �� 5   
   -   5         ��Name$ 
userNameTb��5   b   $��Boris��5      $��Tektur)�5        MaterialDesignFilledTextBox#��[ 5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$4 .Введите имя пользователя��5      $	��Top=�5      $��1��6%   $��3q�5      {�5      ��  �� Path$ 	IsChecked� �� ElementName$0 *MaterialDesignFilledTextBoxEnabledComboBox��5      �� 5   
   -   5         ��Name$ 
newChatBtn��5      $��Tektur)�5       * &MaterialDesignPaperSecondaryDarkButton#��[ 5      $&�� Создать новый чат��5   !   $��3q�6=   $��2��6H   $��Center=�5        � Cursor$
 Hand��6A   �� 5!   
   -   5        $ 
oldChatBtn��5$      $��Tektur)�5"      #��[ 5#      $9��3Подключиться к старому чату��5$   !   $��3��6G   $��Center=�6T   $��3q�6o   6z   �� 5%   
   -   5        $
 ipTb��5-      $��	127.0.0.1��5&      $��Tektur)�5'      #��[ 5(      $	��Top=�5)      $G AВведите IP-адрес сервера или клиента��5*      $��3q�5-      $��4��6&   {�5+      �� $ 	IsChecked�$0 *MaterialDesignFilledTextBoxEnabledComboBox��5-   &   5/      50      