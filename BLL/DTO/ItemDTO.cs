using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    /// <summary>
    /// class for item data transfer object
    /// </summary>
    public class ItemDTO
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
        /// Initializes a new instance of the <see cref="ItemDTO"/> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="brandName">Name of the brand.</param>
        /// <param name="price">The price.</param>
        public ItemDTO(DateTime date, string brandName, int price)
        {
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
            set { this.id = value; }
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
                this.price = value;
            }
        }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.date.Date.ToShortDateString() + " " + this.brandName + " " + this.price;
        }
    }
}

