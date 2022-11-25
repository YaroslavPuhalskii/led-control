using System.Windows;
using System.Windows.Controls;

namespace LED_Control.MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для DefaultColorSelectorView.xaml
    /// </summary>
    public partial class DefaultColorSelectorView : UserControl
    {
        public DefaultColorSelectorView()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }
    }
}
