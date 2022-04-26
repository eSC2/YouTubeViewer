using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.Domain.Models;

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
            _youTubeViewerStore.YouTubeViewerAdded += YouTubeViewerStore_YouTubeViewerAdded;
        }

        private void YouTubeViewerStore_YouTubeViewerAdded(YouTubeViewer youTubeViewer)
        {
            SelectedYouTubeViewer = youTubeViewer;
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
