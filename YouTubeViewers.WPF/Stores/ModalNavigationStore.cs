using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF.Stores
{
    internal class ModalNavigationStore
    {
        private ViewModelBase? _currentViewModel;

        public event Action CurrentViewModelChanged;
        public bool IsOpen => CurrentViewModel != null;

        public ViewModelBase? CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }

        internal void Close()
        {
            CurrentViewModel = null;
        }
    }
}
