using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// interface for choosing methods for reading and writing
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ItemDTO> Read();
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="IsConverted">if set to <c>true</c> [is converted].</param>
        void Write(IEnumerable<ItemDTO> items, bool IsConverted);
    }
}
