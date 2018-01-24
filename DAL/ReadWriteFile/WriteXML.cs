using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using System.Xml.Linq;
using System.IO;

namespace DAL.ReadWriteFile
{
    /// <summary>
    /// class implementing interface for writing to  xml file
    /// </summary>
    /// <seealso cref="DAL.Interfaces.IWrite" />
    public class WriteXML : IWrite
    {
        /// <summary>
        /// The filestream
        /// </summary>
        FileStream filestream;
        /// <summary>
        /// The xdoc
        /// </summary>
        XDocument xdoc;
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteXML"/> class.
        /// </summary>
        /// <param name="fs">The fs.</param>
        public WriteXML(FileStream fs)
        {
            this.filestream = fs;
            fs.Seek(0, SeekOrigin.Begin);
        }
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void Write(IEnumerable<Item> items)
        {
            xdoc = new XDocument(
                   new XElement("Cars", items.Select(x =>
              new XElement("Car",
                  new XElement("BrandName", x.BrandName),
                   new XElement("Price", x.Price),
                  new XElement("Date", x.Date.ToShortDateString())))));
            xdoc.Save(this.filestream);
        }
    }
}
