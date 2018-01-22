using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    /// <summary>
    ///  inteface for writing to file
    /// </summary>
    public interface IWrite
    {
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        void Write(IEnumerable<Item> items);
    }
}
