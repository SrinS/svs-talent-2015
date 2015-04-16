using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    /// <summary>
    /// computer state logs
    /// </summary>
    public class ComputerState
    {
        public void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("==============Car changed state:{0}", stateChangeInfo);
        }
    }
}
