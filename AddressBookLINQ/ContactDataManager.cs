﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AddressBookLINQ
{
    public class ContactDataManager
    {
        DataTable dataTable;
        /// <summary>
        /// UC2-Create Column for addressbook in datatable
        /// </summary>
        public void CreateDataTable()
        {
            //Creating a object for datatable
            dataTable = new DataTable();
            //Creating a object for datacolumn
            DataColumn dtColumn = new DataColumn();
            // Create FirstName Column
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "FirstName";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create LastName Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "LastName";
            dtColumn.Caption = "Last Name";
            dtColumn.AutoIncrement = false;

            dataTable.Columns.Add(dtColumn);

            // Create Address Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Address";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create City Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "City";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create State Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "State";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create EmailId Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Email";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create Address column.    
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int64);
            dtColumn.ColumnName = "PhoneNumber";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

            // Create ZipCode Column
            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(Int64);
            dtColumn.ColumnName = "Zip";
            dtColumn.Caption = "Zip";
            dtColumn.AutoIncrement = false;
            dataTable.Columns.Add(dtColumn);

        }
        //Adding Values in datatable
        public int AddValues()
        {
            //Calling the createtable method
            CreateDataTable();
            //Create Object for DataTable for adding tow values in table
            ContactData contactDataManager = new ContactData();
            ContactData contactDataManagers = new ContactData();

            //Insert Values into Table
            contactDataManager.firstName = "Radhika";
            contactDataManager.lastName = "Shankar";
            contactDataManager.phoneNumber = 8934798542;
            contactDataManager.emailId = "radz@yahoo.com";
            contactDataManager.address = "Adam Street";
            contactDataManager.city = "Chennai";
            contactDataManager.state = "Tamilnadu";
            contactDataManager.zipCode = 600132;
            //Calling the insert table to insert the data 
            InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManagers.firstName = "Priya";
            contactDataManagers.lastName = "venkat";
            contactDataManagers.phoneNumber = 9874568154;
            contactDataManagers.emailId = "priya@gmail.com";
            contactDataManagers.address = "Ranganthan Street";
            contactDataManagers.city = "Chennai";
            contactDataManagers.state = "Tamilnadu";
            contactDataManagers.zipCode = 600014;
            InsertintoDataTable(contactDataManagers);
            //Returning the count of inserted data
            return dataTable.Rows.Count;
        }
        /// <summary>
        /// UC3-Insert the data in table
        /// </summary>
        /// <param name="contactDataManager"></param>
        //Insert values in Data Table
        public void InsertintoDataTable(ContactData contactDataManager)
        {
            DataRow dtRow = dataTable.NewRow();
            dtRow["FirstName"] = contactDataManager.firstName;
            dtRow["LastName"] = contactDataManager.lastName;
            dtRow["Address"] = contactDataManager.address;
            dtRow["City"] = contactDataManager.city;
            dtRow["State"] = contactDataManager.state;
            dtRow["Zip"] = contactDataManager.zipCode;
            dtRow["PhoneNumber"] = contactDataManager.phoneNumber;
            dtRow["Email"] = contactDataManager.emailId;
            dataTable.Rows.Add(dtRow);

        }
        //Display all Values in Table
        public void Display()
        {
            foreach (DataRow dtRows in dataTable.Rows)
            {
                Console.WriteLine("-------------Insert the values in datatable------------");
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}\n", dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
            }
        }

        // <summary>
        /// UC4--->Edit the existing contact using their name
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public bool ModifyDataTableUsingName(string FirstName, string ColumnName)
        {
            AddValues();
            var modifiedList = (from Contact in dataTable.AsEnumerable() where Contact.Field<string>("FirstName") == FirstName select Contact).LastOrDefault();
            if (modifiedList != null)
            {
                modifiedList[ColumnName] = "Swetha";
                Display();
                return true;
            }
            return false;
        }
    }
}
