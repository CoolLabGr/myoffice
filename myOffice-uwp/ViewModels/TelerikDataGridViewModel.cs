using System;
using System.Collections.ObjectModel;

using myOffice_uwp.Core.Models;
using myOffice_uwp.Core.Services;
using myOffice_uwp.Helpers;

namespace myOffice_uwp.ViewModels
{
    public class TelerikDataGridViewModel : Observable
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
