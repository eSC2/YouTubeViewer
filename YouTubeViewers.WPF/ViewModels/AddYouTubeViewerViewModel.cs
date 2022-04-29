using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Commands;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    internal class AddYouTubeViewerViewModel : ViewModelBase
    {

        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public AddYouTubeViewerViewModel(YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);

            ICommand submitCommand = new AddYouTubeViewerCommand(this, youTubeViewersStore, modalNavigationStore);

            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
