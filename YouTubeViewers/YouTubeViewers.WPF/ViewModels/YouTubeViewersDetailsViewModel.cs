using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.WPF.ViewModels
{
    internal class YouTubeViewersDetailsViewModel : ViewModelBase
    {

        public string Username { get; }
        public string IsSubscribedDisplay { get; }
        public string IsMemberDisplay { get; }

        public YouTubeViewersDetailsViewModel()
        {
            Username = "eSC2";
            IsSubscribedDisplay = "Yes";
            IsMemberDisplay = "No";
        }

    }
}
