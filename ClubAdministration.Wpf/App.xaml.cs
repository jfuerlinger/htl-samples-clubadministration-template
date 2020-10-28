using ClubAdministration.Wpf.Common;
using ClubAdministration.Wpf.ViewModels;
using System.Windows;

namespace ClubAdministration.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private MainViewModel _mainWindowViewModel;

    public App()
    {
    }

    private void App_Startup(object sender, StartupEventArgs e)
    {
      WindowController controller = new WindowController();
      _mainWindowViewModel = new MainViewModel(controller);
      controller.ShowWindow(_mainWindowViewModel);

      Dispatcher.Invoke(async () => await _mainWindowViewModel.InitAsync());
    }
  }
}
