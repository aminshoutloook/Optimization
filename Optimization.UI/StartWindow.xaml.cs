using Optimization.UI.Services;
using Optimization.UI.ViewModels;
using System;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace Optimization.UI
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private readonly IDisposable _disposable;
        Storyboard StoryboardMain1 = null;
        public StartWindow(IMessageService messageService, ISchedulerService schedulerService)
        {
            InitializeComponent();

            StoryboardMain1 = this.Resources["StoryboardMain1"] as Storyboard;
            StoryboardMain1.Completed += Storyboard_Completed;
            _disposable = messageService.Show
               // Delay to make sure there is time for the animations
               .Delay(TimeSpan.FromMilliseconds(250), schedulerService.TaskPool)
               .ObserveOn(schedulerService.Dispatcher)
               .Subscribe();

            Closed += HandleClosed;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = this.DataContext as IChromeViewModel;
            if (viewModel.Main != null)
            {
               await viewModel.Main.initEfFirstCall();
               StoryboardMain1.Begin(this);
            }
            else
            {
                throw new NotImplementedException("Something is wrong on start window model!!!");
            }
        }

        private void HandleClosed(object sender, EventArgs e)
        {
            _disposable.Dispose();
        }
        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.showMainWindow();
        }

        private void showMainWindow()
        {
            this.Cursor = Cursors.Wait;
            var window = new MainWindow();
            window.ShowDialog();
            this.Close();
            this.Dispatcher.InvokeShutdown();
            this.Cursor = Cursors.Arrow;
        }

    }
}
