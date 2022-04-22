using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.Stores
{
    internal class SelectedYouTubeViewerStore
    {
        private readonly YouTubeViewersStore _youTubeViewerStore;

        private YouTubeViewer _selectedYouTubeViewer;

        public YouTubeViewer SelectedYouTubeViewer
        {
            get { return _selectedYouTubeViewer; }
            set
            {
                _selectedYouTubeViewer = value;
                SelectedYouTubeViewerChanged?.Invoke();
            }
        }

        public event Action? SelectedYouTubeViewerChanged;

        public SelectedYouTubeViewerStore(YouTubeViewersStore youTubeViewerStore)
        {
            _youTubeViewerStore = youTubeViewerStore;

            _youTubeViewerStore.YouTubeViewerUpdated += YouTubeViewerStore_YouTubeViewerUpdated;
        }

        private void YouTubeViewerStore_YouTubeViewerUpdated(YouTubeViewer youTubeViewer)
        {
            if(youTubeViewer.Id == SelectedYouTubeViewer?.Id)
            {
                SelectedYouTubeViewer = youTubeViewer;
            }
        }
    }
}
