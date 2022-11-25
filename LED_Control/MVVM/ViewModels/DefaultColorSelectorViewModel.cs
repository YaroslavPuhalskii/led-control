using System.Windows.Media;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LED_Control.MVVM.ViewModels;

internal partial class DefaultColorSelectorViewModel : ObservableObject
{
    private readonly MainViewModel _mainViewModel;

    #region Set Color
    [RelayCommand]
    public void SetBlackColor()
    {
        _mainViewModel!.SelectedColor = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetWhiteColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(80, 80, 80)),
            "160" => new SolidColorBrush(Color.FromRgb(160, 160, 160)),
            "255" => new SolidColorBrush(Color.FromRgb(255, 255, 255)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetRedColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(80, 0, 0)),
            "160" => new SolidColorBrush(Color.FromRgb(160, 0, 0)),
            "255" => new SolidColorBrush(Color.FromRgb(255, 0, 0)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetGreenColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(0, 80, 0)),
            "160" => new SolidColorBrush(Color.FromRgb(0, 160, 0)),
            "255" => new SolidColorBrush(Color.FromRgb(0, 255, 0)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetBlueColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(0, 0, 80)),
            "160" => new SolidColorBrush(Color.FromRgb(0, 0, 160)),
            "255" => new SolidColorBrush(Color.FromRgb(0, 0, 255)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetYellowColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(80, 80, 0)),
            "160" => new SolidColorBrush(Color.FromRgb(160, 160, 0)),
            "255" => new SolidColorBrush(Color.FromRgb(255, 255, 0)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetCyanColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(0, 80, 80)),
            "160" => new SolidColorBrush(Color.FromRgb(0, 160, 160)),
            "255" => new SolidColorBrush(Color.FromRgb(0, 255, 255)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }

    [RelayCommand]
    public void SetMagentaColor(string? data)
    {
        _mainViewModel!.SelectedColor = data switch
        {
            "80" => new SolidColorBrush(Color.FromRgb(80, 0, 80)),
            "160" => new SolidColorBrush(Color.FromRgb(160, 0, 160)),
            "255" => new SolidColorBrush(Color.FromRgb(255, 0, 255)),
            _ => new SolidColorBrush(Color.FromRgb(0, 0, 0)),
        };
        _mainViewModel.IsEnable = true;
    }
    #endregion

    public DefaultColorSelectorViewModel(MainViewModel mainViewModel)
        => _mainViewModel = mainViewModel;
}
