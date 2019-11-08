
namespace Optimization.UI.ViewModels
{
    using System;
    using System.ComponentModel;

    public interface IViewModel : IDisposable, INotifyPropertyChanged
    {
        IDisposable SuspendNotifications();
    }
}
