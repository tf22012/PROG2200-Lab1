﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    internal class Marketing
    {
        public void Finished()
        {
            Program.Posted += HasPosted;
        }
        void HasPosted()
        {
            Console.WriteLine("Thank you for completing the survey. You are now subscribed to ten of our newsletters.");
        }
    }
}
