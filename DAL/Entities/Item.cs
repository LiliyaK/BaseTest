using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /// <summary>
    /// class for item
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The date
        /// </summary>
        private DateTime date;
        /// <summary>
        /// The brand name
        /// </summary>
        private string brandName;
        /// <summary>
        /// The price
        /// </summary>
        private int price;
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
        { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="brandName">Name of the brand.</param>
        /// <param name="price">The price.</param>
        public Item(DateTime date, string brandName, int price)
        {
            this.date = date;
            this.brandName = brandName;
            this.price = price;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="date">The date.</param>
        /// <param name="brandName">Name of the brand.</param>
        /// <param name="price">The price.</param>
        public Item(int id, DateTime date, string brandName, int price)
        {
            this.id = id;
            this.date = date;
            this.brandName = brandName;
            this.price = price;
        }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id
        {
            get { return this.id; }
            set
            {
                if (id == 0)
                    this.id = 1;
            }
        }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime Date
        {
            get { return this.date; }
            set
            {
                if (this.date.Day < 0 || this.date.Day > 31)
                    this.date = value;
            }
        }
        /// <summary>
        /// Gets or sets the name of the brand.
        /// </summary>
        /// <value>
        /// The name of the brand.
        /// </value>
        public string BrandName
        {
            get { return this.brandName; }
            set
            {
                this.brandName = value;
            }
        }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public int Price
        {
            get { return this.price; }
            set
            {
                if (this.price < 0)
                    this.price = value;
            }
        }
        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        /// true if the specified object  is equal to the current object; otherwise, false.
        /// </returns>
        public override bool Equals(Object obj)
        {
            if (obj == null) return false;
           Item item = obj as Item;
            if (item.Date == this.Date)
                if (this.BrandName == item.BrandName)
                    if (this.Price == item.Price)
                        return true;
                     return false;
        }

    }
}

