using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LAb11_12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Получаем все текстовые поля из обеих частей окна
            var textboxes = FindVisualChildren<TextBox>(this);

            foreach (var textbox in textboxes)
            {
                // Устанавливаем стиль для всех текстовых полей как маленький
                textbox.Style = (Style)Resources["SmallTextBoxStyle"];
            }

            // Устанавливаем стиль для текущего текстового поля как большой
            if (sender is TextBox focusedTextBox)
            {
                focusedTextBox.Style = (Style)Resources["BigTextBoxStyle"];
            }
        }

        // Вспомогательный метод для поиска всех дочерних элементов определенного типа
        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child is T t)
                    {
                        yield return t;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}