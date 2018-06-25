using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateLib
{
    /// <summary>
    /// Operations on int
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Add two numbers
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>v1 + v2</returns>
        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>v1 * v2</returns>
        public static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }
    }
}
