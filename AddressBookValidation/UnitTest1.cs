﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AddressBookLINQ;

namespace AddressBookValidation
{
    [TestClass]
    public class UnitTest1
    {
        ContactDataManager contactData;

        [TestInitialize]
        public void SetUp()
        {
            contactData = new ContactDataManager();
        }
        /// <summary>
        /// Returns the count of inserted data
        /// </summary>
        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = contactData.AddValues();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// UC4--->Edit the existing contact using their name
        /// </summary>
        [TestMethod]
        public void TestMethodForModifyDetailsUsingName()
        {
            bool expected = true;
            var actual = contactData.ModifyDataTableUsingName("Priya", "LastName");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC5--->Delete a Person Using FirstName Column
        /// </summary>
        [TestMethod]
        public void TestMethodForDeleteDataUsingName()
        {
            bool expected = true;
            var actual = contactData.DeleteRecordUsingName("Vishnu");
            Assert.AreEqual(expected, actual);
        }
    }
}
