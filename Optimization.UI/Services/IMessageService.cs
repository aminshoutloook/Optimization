
using Optimization.UI.Models;
using Optimization.UI.ViewModels;
using System;

namespace Optimization.UI.Services
{
    public interface IMessageService : IService
    {
        IObservable<Message> Show { get; }

        void Post(string header, ICloseableViewModel viewModel);
    }
}
