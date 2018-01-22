using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    /// <summary>
    /// interface for editing items
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        List<Item> items { get; set; }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Add(Item item);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="item">The item.</param>
        void Delete(Item item);

        /// <summary>
        /// Finds the name by unique.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>T.</returns>
      
    }
}
