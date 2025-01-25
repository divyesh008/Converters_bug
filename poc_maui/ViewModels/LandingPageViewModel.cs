using System;
using System.Collections.ObjectModel;
using poc_maui.Models;

namespace poc_maui.ViewModels
{
	public class LandingPageViewModel : BaseViewModel
	{
		public LandingPageViewModel()
		{
            LoadData();
		}

        public ObservableCollection<PreviousInspection> Inspections
        {
            get { return _inspections; }
            set { _inspections = value; OnPropertyChanged(nameof(Inspections)); }
        }
        private ObservableCollection<PreviousInspection> _inspections;

        private void LoadData()
        {
            var inspectionId = Guid.NewGuid().ToString();

            Inspections = new ObservableCollection<PreviousInspection>()
            {
                new PreviousInspection
                {
                    InspectionId = inspectionId,
                    PreviousInspectionId = "927ab1a5-e177-4e4b-ae03-2a78de1336ee",
                    BusinessName =  "Jockma 041254-06-2022",
                    CompletionDate = new DateTime(2022,07,08,9,0,0),
                    ScheduledStartDate = new DateTime(2022,07,08,9,0,0),
                    InspectionType = "Test 388 - Regular inspection checking multiline support but not working",
                    InspectorFirstName = "Jagan",
                    InspectorLastName = "Mohan",
                    IsSuccess = true,
                },
                new PreviousInspection
                {
                    InspectionId = inspectionId,
                    PreviousInspectionId = "dd6cad17-b1be-4e73-b140-a19a9795e280",
                    BusinessName =  "Puma 041254-06-2022",
                    CompletionDate = new DateTime(2022,07,08,9,0,0),
                    ScheduledStartDate = new DateTime(2022,07,08,9,0,0),
                    InspectionType = "Test 222 - Regular inspection",
                    InspectorFirstName = "Krupal",
                    InspectorLastName = "Khal",
                    IsSuccess = true,
                },
                new PreviousInspection
                {
                    InspectionId = inspectionId,
                    PreviousInspectionId = "d81ebe70-a4d8-4596-aa31-240975638f93",
                    BusinessName =  "Sterling 041253-06-2022",
                    CompletionDate = new DateTime(2022,05,02,0,0,0),
                    ScheduledStartDate = new DateTime(2022,07,08,9,0,0),
                    InspectionType = "Test 455 - Regular inspection",
                    InspectorFirstName = "Irfan",
                    InspectorLastName = "Chawda",
                    IsSuccess = true,
                },
            };
        }
    }
}

