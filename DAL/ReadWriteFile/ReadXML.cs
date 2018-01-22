using DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DAL.Interfaces;

namespace DAL.ReadWriteFile
{
    /// <summary>
    /// class inmplementing interface for reading from xml file
    /// </summary>
    /// <seealso cref="DAL.Interfaces.IRead" />
    public class ReadXML:IRead
    {
        /// <summary>
        /// The xdoc
        /// </summary>
        XDocument xdoc;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadXML"/> class.
        /// </summary>
        /// <param name="fs">The fs.</param>
        public ReadXML(FileStream fs)
        {
           fs.Seek(0, SeekOrigin.Begin);
            this.xdoc = XDocument.Load(fs);
        }
        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public IEnumerable<Item> Items
        {
           get
            {
                return this.Read();
            }
        }
        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> Read()
        {
            List<Item> items = new List<Item>();
            foreach (XElement phoneElement in xdoc.Element("Cars").Elements("Car"))
            {
                XElement date = phoneElement.Element("Date");
                XElement brand = phoneElement.Element("BrandName");
                XElement price = phoneElement.Element("Price");
                items.Add(new Item(DateTime.ParseExact(date.Value, "dd.MM.yyyy", null).Date, brand.Value, Int32.Parse(price.Value)));
            }
            return items;
        }

    }
}
