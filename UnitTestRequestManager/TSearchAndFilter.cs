using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RequestManager;

namespace UnitTestRequestManager
{
	[TestClass]
	public class TSearchAndFilter
	{
        BindingList<RequestModel> CreateTestData()
        {
            return new BindingList<RequestModel>
            {
                new RequestModel(1)
                {
                    Customer = "Заказчик 1",
                    Condition = "Открыта",
                    RequestDate = new DateTime(2025, 1, 10)
                },
                new RequestModel(2)
                {
                    Customer = "Заказчик 2",
                    Condition = "Закрыта",
                    RequestDate = new DateTime(2025, 1, 15)
                },
                new RequestModel(3)
                {
                    Customer = "Заказчик 3",
                    Condition = "Закрыта",
                    RequestDate = new DateTime(2025, 2, 1)
                },
                new RequestModel(4)
                {
                    Customer = "Заказчик 4",
                    Condition = "Открыта",
                    RequestDate = new DateTime(2025, 2, 10)
                }
            };
        }

        [TestMethod]
        [DataRow("Заказчик", 4)]
        [DataRow("ЗАКАЗЧИК", 4)]
        [DataRow("Заказчик 2", 1)]
        [DataRow("Неправильный заказчик", 0)]
        public void TestSearchByCustomer(string searchText, int expectedResult)
        {
            SearchAndFilter searchAndFilter = new SearchAndFilter();
            BindingList<RequestModel> testData = CreateTestData();

            var actualResult = searchAndFilter.SearchByCustomer(testData, searchText);

            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [TestMethod]
        [DataRow("", 0)]
        [DataRow("Открыта", 2)]
        [DataRow("Закрыта", 2)]
        public void TestFilterCondition(string stringCondition, int expectedResult)
        {
            SearchAndFilter searchAndFilter = new SearchAndFilter();
            BindingList<RequestModel> testData = CreateTestData();

            var actualResult = searchAndFilter.FilterCondition(testData, stringCondition);

            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [TestMethod]
        [DataRow(2025, 1, 5, 2025, 2, 3, 3)]
        [DataRow(2025, 1, 1, 2025, 1, 9, 0)]
        [DataRow(2025, 2, 10, 2025, 2, 10, 1)]
        public void TestFilterDate(int yearStart, int monthStart, int dayStart, 
                                   int yearEnd, int monthEnd, int dayEnd, int expectedResult)
        {
            SearchAndFilter searchAndFilter = new SearchAndFilter();
            BindingList<RequestModel> testData = CreateTestData();

            var actualResult = searchAndFilter.FilterDate(testData, new DateTime(yearStart, monthStart, dayStart), 
                                                                    new DateTime(yearEnd, monthEnd, dayEnd) );

            Assert.AreEqual(expectedResult, actualResult.Count);
        }
    }
}
