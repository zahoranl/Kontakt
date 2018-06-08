using Kontakt.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kontakt.ViewModels
{
	public class DetailsPageViewModel : ViewModelBase
    {
        private Person contact;
        public Person Contact
        {
            get { return contact; }
            set { SetProperty(ref contact, value); }
        }

        public DetailsPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "Details Page";
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            Contact = (Person)parameters["contact"];
            base.OnNavigatedTo(parameters);
        }
    }
}
