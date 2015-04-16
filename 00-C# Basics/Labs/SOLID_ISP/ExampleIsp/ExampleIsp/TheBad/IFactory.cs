using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheBad
{
    public interface IFactory
    {
        int StartShift();

        int CloseShift();

        int StartProductionLane();

        int StopProductionLane();

        int ProduceBody();

        int ProduceEngine();

        int ProduceGears();

        int ProduceHeadLamps();

        int ProduceElectronics();

        /// <summary>
        /// Produce tanks for the car
        /// </summary>
        /// <returns></returns>
        int ProduceTank();

        /// <summary>
        /// Produces the frame for the motorcycles
        /// </summary>
        /// <returns></returns>
        int ProduceFrame();

        /// <summary>
        /// Produce handles for the motorcycles
        /// </summary>
        /// <returns></returns>
        int ProduceHandles();

        /// <summary>
        /// Produces the tank for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceTankMoto();

        /// <summary>
        /// Produces the tank for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceEngineMoto();

        /// <summary>
        /// Produce the gears for the motorcycle
        /// </summary>
        /// <returns></returns>
        int ProduceGearsMoto();

        /// <summary>
        /// Produces the frame for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceFrameBike();

        /// <summary>
        /// Produce handles for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceHandlesBike();

        /// <summary>
        /// Produce gears for the bikes
        /// </summary>
        /// <returns></returns>
        int ProduceGearsBike();

        //the painters
        int Paint(int paintColour);

        /// <summary>
        /// Paints the motorcycle
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintMoto(int paintColour);

        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintBike(int paintColour);


    }
}
