using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open_Closed;

namespace Value
{
    public class MagicValue : Wizard.Magic
    {
        public int AmmounPower { get; set; }
        public string Magic { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"You have {AmmounPower} and your magic is {Magic}");
        }
    }
}