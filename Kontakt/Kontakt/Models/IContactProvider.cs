using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Kontakt.Models
{
    public interface IContactProvider
    {
        ObservableCollection<Person> GetContactList();
        Person GetPersonById(int id);
    }
}
