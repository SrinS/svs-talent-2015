using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheBad
{
    public class AcmeCar
    {
        public LockState IsLocked { get; private set; }

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                ComputerLogChangeState("CarLocked");

            }
            catch (Exception)
            {
                Console.WriteLine("There was an error locking the car!");
            }
        }

        public void Unlock()
        {
            try
            {
                //
                this.IsLocked = LockState.Unlocked;
                //
                ComputerLogChangeState("CarUnlocked");
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error unlocking the car!");
            }

        }

        private void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("==============Car changed state:{0}",stateChangeInfo);
        }

    }

    public enum LockState
    {
        Error = 0,
        Locked = 1,
        Unlocked = 2,

    }
}
