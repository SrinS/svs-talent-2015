using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public interface IBike
    {
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

        /// <summary>
        /// Paints the bike
        /// </summary>
        /// <param name="paintColour"></param>
        /// <returns></returns>
        int PaintBike(int paintColour);

       
    }
}
