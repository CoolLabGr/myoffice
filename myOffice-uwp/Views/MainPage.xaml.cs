using System;

using myOffice_uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace myOffice_uwp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
