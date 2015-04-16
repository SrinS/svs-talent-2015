using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleIsp.TheBad;

namespace ExampleIsp.TheGood
{
    /// <summary>
    /// Company make bikes, cars, motocycles
    /// </summary>
    public class Company : IProduct
    {
        public int Shift { get; private set; }

        public int StartShift()
        {
            this.Shift = Shift + 1;
            if (this.Shift > 3)
            {
                this.Shift = 3;
                throw new Exception("Maximum 3 shifts can be started!");
            }
            Console.WriteLine("Shift started!");
            return this.Shift;
        }

        public int CloseShift()
        {
            this.Shift = Shift - 1;
            if (this.Shift < 0)
            {
                this.Shift = 0;
                throw new Exception("Atleast one shift needs to be started in order to close it!");
            }

            Console.WriteLine("Shift closed!");
            return this.Shift;
        }

        public int StartProductionLane()
        {
            throw new NotImplementedException();
        }

        public int StopProductionLane()
        {
            throw new NotImplementedException();
        }

        public int ProduceBody()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngine()
        {
            throw new NotImplementedException();
        }

        public int ProduceGears()
        {
            throw new NotImplementedException();
        }

        public int ProduceHeadLamps()
        {
            throw new NotImplementedException();
        }

        public int ProduceElectronics()
        {
            throw new NotImplementedException();
        }

        public int ProduceTank()
        {
            throw new NotImplementedException();
        }

        public int ProduceFrame()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandles()
        {
            throw new NotImplementedException();
        }

        public int ProduceTankMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceEngineMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsMoto()
        {
            throw new NotImplementedException();
        }

        public int ProduceFrameBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceHandlesBike()
        {
            throw new NotImplementedException();
        }

        public int ProduceGearsBike()
        {
            throw new NotImplementedException();
        }

        public int Paint(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int PaintMoto(int paintColour)
        {
            throw new NotImplementedException();
        }

        public int PaintBike(int paintColour)
        {
            throw new NotImplementedException();
        }
    }
}
