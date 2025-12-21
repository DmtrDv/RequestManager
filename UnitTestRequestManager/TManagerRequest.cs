using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RequestManager;

namespace UnitTestRequestManager
{
    [TestClass]
    public class TManagerRequest
    {
        [TestMethod]
        public void TestAddRequest_validData()
        {
            var mockRepository = new Mock<IRequestManager>();
            var testManager = new ManagerRequest(mockRepository.Object);
            var testValidRequest = new RequestModel()
            {
                Customer = "Заказчик_1",
                Condition = "Открыта",
                Description = "Тестовое описание",
            };
            List<RequestModel> repositoryContent = new List<RequestModel>();

            mockRepository.Setup(r => r.AddRequest(testValidRequest))
                          .Returns("")
                          .Callback<RequestModel>(requestModel => repositoryContent.Add(requestModel));

            var actualResult = testManager.AddRequest(testValidRequest);

            Assert.AreEqual("Новая заявка успешно добавлена", actualResult);
            mockRepository.Verify(r => r.AddRequest(testValidRequest), Times.Once);
            Assert.IsTrue(repositoryContent.Contains(testValidRequest),
                                  "Заявка была сохранена в репозитории");
        }

        [TestMethod]
        [DataRow("", "Открыта", "Тестовое описание", "Введите заказчика")]
        [DataRow("Заказчик_1", "", "Тестовое описание", "Введите состояние заявки")]
        [DataRow("Заказчик_1", "Открыта", "", "Введите описание заявки")]
        public void TestAddRequest_invalidData(string customer, string condition, string description, string expectedResult)
        {
            var mockRepository = new Mock<IRequestManager>();
            var testManager = new ManagerRequest(mockRepository.Object);
            var testInvalidRequest = new RequestModel()
            {
                Customer = customer,
                Condition = condition,
                Description = description
            };

            var actualResult = testManager.AddRequest(testInvalidRequest);

            Assert.AreEqual(expectedResult, actualResult);
            mockRepository.Verify(r => r.AddRequest(testInvalidRequest), Times.Never);
        }
    }
}