using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week4Challenges
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void PhoneExamples()
        {   
            var customerOnePhone = new Phone();
            customerOnePhone.CustId = 1;
            customerOnePhone.FirstName = "Timmy";
            customerOnePhone.LastName = "Powers";
            customerOnePhone.HasPhone = true;
            customerOnePhone.Brand = "Samsung";
            customerOnePhone.Name = "Galaxy S20 Plus";
            customerOnePhone.Color = "Coral Blue";

            var managerOne = new Manager();
            managerOne.ManagerId = 1;
            managerOne.FirstName = "Where's";
            managerOne.LastName = "Waldo";
            managerOne.PromotionDate = DateTime.Today;
            managerOne.HasWorkPhone = true;
            managerOne.Brand = "Google";
            managerOne.Name = "Pixel 3";
            managerOne.Color = "Red";
        }
    }
}
