using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Repository
{
    /// <summary>
    /// class implemanting interface for editing items
    /// </summary>
    /// <seealso cref="DAL.Interfaces.IRepository" />
    public class ItemRepository : IRepository
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public List<Item> items { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRepository"/> class.
        /// </summary>
        /// <param name="items">The items.</param>
        public ItemRepository(IEnumerable<Item> items)
        {
            this.items = items.ToList<Item>();
        }

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Add(Item item)
        {
            this.items.Add(item);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Delete(Item item)
        {
            this.items.Remove(item);
        }
    }
}
