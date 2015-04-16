using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    /// <summary>
    /// car configurations
    /// </summary>
    public class Car
    {
        private ComputerState computerState = new ComputerState();
        public LockState IsLocked { get; private set; }

        public void Lock()
        {
            try
            {
                //
                this.IsLocked = LockState.Locked;
                //log state change in computer
                computerState.ComputerLogChangeState("CarLocked");

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
                computerState.ComputerLogChangeState("CarUnlocked");
            }
            catch (Exception)
            {
                Console.WriteLine("There was an error unlocking the car!");
            }

        }
    }
}
