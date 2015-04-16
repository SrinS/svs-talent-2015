using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public interface ICar
    {
        /// <summary>
        /// Produce tanks for the car
        /// </summary>
        /// <returns></returns>
        int ProduceTank();
    }
}
