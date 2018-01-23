using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    /// <summary>
    /// inteface for editing items from view
    /// </summary>
    public interface IItemService
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        List<ItemDTO> GetAll();
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(ItemDTO item);
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="item">The item.</param>
        void Delete(ItemDTO item);
        /// <summary>
        /// Saves the items to file according to its type
        /// </summary>
        /// <param name="IsConverted">if set to <c>true</c> [is converted].</param>
        void Save(bool IsConverted);
    }
}
