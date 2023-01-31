using Insurance.Controllers;
using Insurance.Model;
using Insurance.Repository;
using Moq;
using NUnit.Framework;

namespace Insurance.Test
{
    public class PremiumCalculatorControllerTest
    {
        private Mock<IInsurance> insuranceMock;
        private IInsurance insurance;
        private PremiumCalculatorController controller;
        [SetUp]
        public void Setup()
        {
            insuranceMock=new Mock<IInsurance>();
            insurance=insuranceMock.Object;
            controller=new PremiumCalculatorController(insuranceMock.Object);
        }

        [Test]
        public void CalculatePremiumActionTest()
        {
            //Arrange
            InsuranceModel model = new InsuranceModel()
            {
                 Name="Rana",
                 Age=36,
                 Occupation= "Author",
                 Death=200000
            };
            insuranceMock
                .Setup(x => x.CalculatePremium(model)).Returns(129600);
            //Act
            var result=controller.CalculatePremiumAction(model);
            //Assert
            Assert.IsNotNull(result);
        }
    }
}