using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentValidation;
using LED_Control.MVVM.Models;
using LED_Control.Services.Abstractions;
using LED_Control.MVVM.Views;

namespace LED_Control.MVVM.ViewModels;

internal partial class MainViewModel : ObservableObject
{
    private readonly ILedService _ledService;

    private readonly ColorSelectorViewModel _colorSelectorViewModel;

    [ObservableProperty]
    private string? vendorId;

    [ObservableProperty]
    private string? productId;

    [ObservableProperty]
    private ObservableCollection<Command>? commands;

    [ObservableProperty]
    private Command? selectedCommand;

    [ObservableProperty]
    private SolidColorBrush? selectedColor;

    [ObservableProperty]
    private bool? isEnable;

    [ObservableProperty]
    private string? message;

    [ObservableProperty]
    private SolidColorBrush? setButtonColor;

    [ObservableProperty]
    private bool? setButtonEnable;

    partial void OnProductIdChanged(string? value)
    {
        ConnectToDevice();
    }

    partial void OnVendorIdChanged(string? value)
    {
        ConnectToDevice();
    }

    [RelayCommand]
    public async Task SetColor()
    {
        try
        {
            SetButtonEnable = false;

            var report = new TranzitReport
            {
                VendorId = VendorId,
                ProductId = ProductId,
                Color = SelectedColor!.Color,
                Command = SelectedCommand,
            };

            await _ledService.SetColorAsync(report);

            Message = "OK.";
        }
        catch (ValidationException ex)
        {
            Message = string.Join(Environment.NewLine, ex.Errors.Select(error => error.ErrorMessage));
        }
        catch (Exception ex)
        {
            Message = ex.Message;
        }
        finally
        {
            SetButtonEnable = true;
        }
    }

    [RelayCommand]
    public void OpenDefaultColorSelector()
    {
        IsEnable = false;

        var colorSelector = new ColorSelectorWindow
        {
            WindowStartupLocation = WindowStartupLocation.Manual,
            Left = Application.Current.MainWindow.Left,
            Top = Application.Current.MainWindow.Top + 120,
        };

        colorSelector.DataContext = _colorSelectorViewModel;
        colorSelector.Show();
    }

    public MainViewModel(ILedService ledService)
    {
        _ledService = ledService;
        _colorSelectorViewModel = new ColorSelectorViewModel(this);
    }

    private void ConnectToDevice()
    {
        if (_ledService.IsConnected(VendorId, ProductId))
        {
            SetButtonEnable = true;
            SetButtonColor = Brushes.Green;
            Message = "OK.";

            return;
        }

        SetButtonEnable = false;
        SetButtonColor = Brushes.DarkRed;
        Message = "Device isn't connected.";
    }
}
