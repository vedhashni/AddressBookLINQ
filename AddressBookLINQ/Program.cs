using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using linq");

            ContactDataManager contactDataManager = new ContactDataManager();
            //contactDataManager.CreateDataTable();
            //contactDataManager.AddValues();
            //contactDataManager.Display();

            //contactDataManager.ModifyDataTableUsingName("Raju", "LastName");

            contactDataManager.DeleteRecordUsingName("Vishnu");
        }

    }
    }
}
