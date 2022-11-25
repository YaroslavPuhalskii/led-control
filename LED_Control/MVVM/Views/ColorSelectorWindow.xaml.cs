using System.Windows;
using System.Windows.Input;

namespace LED_Control.MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для ColorSelectorWindow.xaml
    /// </summary>
    public partial class ColorSelectorWindow : Window
    {
        public ColorSelectorWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RgbMap_Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
