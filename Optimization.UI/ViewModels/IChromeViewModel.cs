
namespace Optimization.UI.ViewModels
{
    using Commands;
    using Optimization.UI.ViewModels.Concrete;

    public interface IChromeViewModel : IViewModel
    {
        IStartWindowViewModel Main { get; }
        ReactiveCommand<object> CloseOverlayCommand { get; }
        bool HasOverlay { get; }
        string OverlayHeader { get; }
        BaseViewModel Overlay { get; }
    }
}
