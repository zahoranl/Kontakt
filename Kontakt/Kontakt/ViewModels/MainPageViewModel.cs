using Kontakt.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Kontakt.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand<Person> NavigateToDetailsPageCommand { get; private set; }
        public ObservableCollection<Person> Contacts { get; private set; }
        private IContactProvider contactProvider;

        public MainPageViewModel(INavigationService navigationService, IContactProvider contactProvider) 
            : base (navigationService)
        {
            Title = "Main Page";
            this.contactProvider = contactProvider;
            Contacts = contactProvider.GetContactList();
           // Contacts = new ObservableCollection<Person>(Contacts.OrderBy(p => p.Name).ToList());
            NavigateToDetailsPageCommand = new DelegateCommand<Person>(NavigateToDetailsPage);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            Contacts = contactProvider.GetContactList();
            base.OnNavigatedTo(parameters);
        }

        private void NavigateToDetailsPage(Person param)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("contact", param);
            NavigationService.NavigateAsync("DetailsPage", navigationParams);
        }
    
    }
}
