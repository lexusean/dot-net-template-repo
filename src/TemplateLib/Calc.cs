using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLib
{
    /// <summary>
    /// Calculator interface
    /// </summary>
    public interface ICalc
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        int Add(int v1, int v2);
        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        int Multiply(int v1, int v2);
    }

    /// <summary>
    /// Concrete Calculator
    /// </summary>
    public class Calc : ICalc
    {
        /// <inheritdoc />
        public int Add(int v1, int v2)
        {
            return Operations.Add(v1, v2);
        }

        /// <inheritdoc />
        public int Multiply(int v1, int v2)
        {
            return Operations.Multiply(v1, v2);
        }
    }
}
