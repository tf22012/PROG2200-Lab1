using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    interface IPayee
    {
        void Pay();
    }
    internal class PayRoll
    {
        // Attribute(s):

        // Create new objs with Teacher Class:
        //Teacher teacher1 = new Teacher();
        //Teacher teacher2 = new Teacher();
        //Principal principal1 = new Principal();

        // Use list in C#:
        List<IPayee> payees = new List<IPayee>();

        // Create Constructor:
        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        

        // Methods:
        public void PayAll()
        {
            foreach (var faculty in payees)
            {
                faculty.Pay();
            }
            /*
                OR:
                teacher1.Pay();
                teacher2.Pay();
                principal1.Pay();
            */
        }

    }
}
