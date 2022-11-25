using FluentValidation;
using LED_Control.MVVM.Models;
using LED_Control.MVVM.ViewModels;
using LED_Control.Services;
using LED_Control.Services.Abstractions;
using LED_Control.Validators;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using System.Windows.Media;

namespace LED_Control
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        readonly ServiceProvider? _serviceProvider;

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ILedService, LedService>();
            services.AddSingleton<AbstractValidator<TranzitReport>, ReportValidator>();
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider!.GetService<MainWindow>();
            mainWindow!.DataContext = GetMainViewModel();
            mainWindow!.Show();

            base.OnStartup(e);
        }

        private MainViewModel GetMainViewModel()
        {
            var mainViewModel = _serviceProvider!.GetService<MainViewModel>();

            mainViewModel!.Commands = CommandList.GetCommands();

            mainViewModel.SelectedColor = Brushes.Black;
            mainViewModel.SetButtonColor = Brushes.DarkRed;

            mainViewModel.IsEnable = true;
            mainViewModel.SetButtonEnable = false;

            mainViewModel.Message = "Not enough parameters. Use command line: VID PID Command Red Green Blue.";

            return mainViewModel!;
        }
    }
}
