using ClubAdministration.Wpf.Common;
using ClubAdministration.Wpf.Common.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ClubAdministration.Wpf.ViewModels
{
  public class MainViewModel : BaseViewModel
  {


    public MainViewModel(IWindowController windowController) : base(windowController)
    {
      LoadCommands();
    }


    private void LoadCommands()
    {
    }


    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Initialisiert das ViewModel (lang laufende Datenladevorgänge, etc.).
    /// </summary>
    public override Task InitAsync()
    {
      throw new NotImplementedException();
    }
  }
}
