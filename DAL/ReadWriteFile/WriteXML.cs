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
            if (filestream.Length == 0)
            {
                xdoc = new XDocument();
                xdoc.Add(new XElement("Cars"));
                xdoc.Save(this.filestream);
            }
            fs.Seek(0, SeekOrigin.Begin);
        }
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void Write(IEnumerable<Item> items)
        {
            xdoc = new XDocument(XDocument.Load(filestream));
            XElement cars = xdoc.Element("Cars");
            foreach (Item item in items)
            {
                XElement car = new XElement("Car");
                XElement carBrandNameElem = new XElement("BrandName", item.BrandName);
                XElement carPriceElem = new XElement("Price", item.Price);
                XElement carDateElem = new XElement("Date", item.Date);
                car.Add(carBrandNameElem);
                car.Add(carPriceElem);
                car.Add(carDateElem);
                cars.Add(car);
                xdoc.Save(this.filestream);
            }
        }
    }
}
