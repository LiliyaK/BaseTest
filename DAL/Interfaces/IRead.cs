using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    /// <summary>
    /// inteface for reading from file
    /// </summary>
    public interface IRead
    {
        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Item> Read();
    }
}
