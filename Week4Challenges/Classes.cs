using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    abstract class Customer
    {
        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasPhone { get; set; }
    }
    
    class Phone : Customer
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Phone() { }
    }

    class Manager : Phone
    {
        public int ManagerId { get; set; }
        public bool HasWorkPhone { get; set; }
        public DateTime PromotionDate { get; set; }

        public Manager() { }
    }
}
