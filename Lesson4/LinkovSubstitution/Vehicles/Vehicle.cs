using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LiskovSubstitution.Vehicles
{
    public class Vehicle
    {
        private string Choice { get; set; }

        public string UserChoice()
        {
            return Choice;
        }
        public virtual void StartEngine()
        {
            Console.WriteLine("The engine is starting");
        }
    }
}
