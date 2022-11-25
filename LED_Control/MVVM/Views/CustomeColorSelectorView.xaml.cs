using System.Windows;
using System.Windows.Controls;

namespace LED_Control.MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для CustomeColorSelectorView.xaml
    /// </summary>
    public partial class CustomeColorSelectorView : UserControl
    {
        public CustomeColorSelectorView()
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
