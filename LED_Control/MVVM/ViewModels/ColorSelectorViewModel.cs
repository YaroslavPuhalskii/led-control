using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LED_Control.MVVM.ViewModels;

internal partial class ColorSelectorViewModel : ObservableObject
{
    private readonly MainViewModel? _mainViewModel;

    [ObservableProperty]
    private ObservableObject? currentViewModel;

    [ObservableProperty]
    private bool isChecked;

    [RelayCommand]
    public void Close() => _mainViewModel!.IsEnable = true;

    [RelayCommand]
    public void ChangeView()
        => CurrentViewModel = IsChecked ? new CustomeColorSelectoreViewModel(_mainViewModel!)
        : new DefaultColorSelectorViewModel(_mainViewModel!);

    public ColorSelectorViewModel(MainViewModel mainViewModel)
    {
        IsChecked = false;
        _mainViewModel = mainViewModel;

        CurrentViewModel = new DefaultColorSelectorViewModel(_mainViewModel!);
    }
}
