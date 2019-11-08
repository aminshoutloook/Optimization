
using Optimization.UI.ViewModels;

namespace Optimization.UI.Models
{
    public sealed class Message
    {
        public Message(string header, ICloseableViewModel viewModel)
        {
            Header = header;
            ViewModel = viewModel;
        }

        public string Header { get; private set; }

        public ICloseableViewModel ViewModel { get; private set; }
    }
}
