using System;

using myOffice_uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace myOffice_uwp.Views
{
    public sealed partial class TabbedPage : Page
    {
        public TabbedViewModel ViewModel { get; } = new TabbedViewModel();

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
