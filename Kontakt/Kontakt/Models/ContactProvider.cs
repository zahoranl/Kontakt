using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Kontakt.Models
{
    class ContactProvider: IContactProvider
    {
        private ObservableCollection<Person> ContactList;
        public ContactProvider()
        {
            ContactList = new ObservableCollection<Person>();
            Init();
            
        }

        public void Init()
        {
            Person person = new Person();
            person.Name = ". Zahorán László";
            person.Number = "+36 30 601 89xx";
            person.Email = "zahoranl.q@gmail.com";
            person.Facebook = "/zahoranllaszlo";
            person.Instagram = "@zahoranl";
            person.Github = "@zlacigit";
            person.Birthday = "1996. Nov. 23.";
            person.Company = "BME";
            ContactList.Add(person);

            Person person1 = new Person();
            person1.Name = "Nagy Lajos";
            person1.Number = "+36 30 601 1111";
            person1.Email = "minta@pelda.hu";
            person1.Facebook = "/mintaface";
            person1.Instagram = "@instaminta";
            person1.Github = "@gitme";
            person1.Birthday = "1998.Jan.01.";
            person1.Company = "Minta Kft.";

            for (int i = 0; i < 15; i++)
            {
                ContactList.Add(person1.Clone());
            }

            ContactList.ElementAt(2).Name ="Kis Károly";
            ContactList.ElementAt(3).Name = "Endy";
            ContactList.ElementAt(4).Name = "Mézga Géza";
            ContactList.ElementAt(5).Name = "Irma";
            ContactList.ElementAt(6).Name = "Viktor";
            ContactList.ElementAt(7).Name = "Olga";
            ContactList.ElementAt(8).Name = "Nagy Ervin";
            ContactList.ElementAt(9).Name = "Tóth János";
            ContactList.ElementAt(10).Name = "Álmos";
            ContactList.ElementAt(11).Name = "Előd";
            ContactList.ElementAt(12).Name = "Autó mentő";
            ContactList.ElementAt(13).Name = "Isvtán";
            ContactList.ElementAt(14).Name = "Vazul";
            ContactList.ElementAt(15).Name = "Márk";
        }

        public ObservableCollection<Person> GetContactList()
        {

             return new ObservableCollection<Person>(ContactList.OrderBy(p => p.Name).ToList());
     
        }


        public Person GetPersonById(int id)
        {
            ObservableCollection<Person> tmp= new ObservableCollection<Person>(ContactList.OrderBy(p => p.Name).ToList());
            return tmp.ElementAt(id);
        }
    }
}
