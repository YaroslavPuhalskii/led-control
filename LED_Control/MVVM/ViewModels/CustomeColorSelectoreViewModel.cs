using System.Windows.Media;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LED_Control.MVVM.ViewModels;

internal partial class CustomeColorSelectoreViewModel : ObservableObject
{
    private byte _redIndex = 0;

    private byte _greenIndex = 0;

    private byte _blueIndex = 0;

    private readonly MainViewModel _mainViewModel;

    [ObservableProperty]
    public SolidColorBrush? selectedColor;

    [RelayCommand]
    public void SetRedColor(string? data)
    {
        _ = byte.TryParse(data, out _redIndex);

        ChangeColor();
    }

    [RelayCommand]
    public void SetGreenColor(string? data)
    {
        _ = byte.TryParse(data, out _greenIndex);

        ChangeColor();
    }

    [RelayCommand]
    public void SetBlueColor(string? data)
    {
        _ = byte.TryParse(data, out _blueIndex);

        ChangeColor();
    }

    [RelayCommand]
    public void Close() => _mainViewModel.IsEnable = true;

    private void ChangeColor()
        => _mainViewModel.SelectedColor = SelectedColor = new SolidColorBrush(Color.FromRgb(_redIndex, _greenIndex, _blueIndex));

    public CustomeColorSelectoreViewModel(MainViewModel mainViewModel)
    {
        _mainViewModel = mainViewModel;
        SelectedColor = _mainViewModel!.SelectedColor;
    }
}
