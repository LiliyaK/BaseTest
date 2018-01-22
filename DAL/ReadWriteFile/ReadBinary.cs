using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ReadWriteFile
{
    /// <summary>
    /// class implementing interface for reading from binary files
    /// </summary>
    /// <seealso cref="DAL.Interfaces.IRead" />
    /// <seealso cref="System.IDisposable" />
    public class ReadBinary:IRead,IDisposable
    {

        /// <summary>
        /// The binary reader
        /// </summary>
        BinaryReader binaryReader;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadBinary"/> class.
        /// </summary>
        /// <param name="fs">The fs.</param>
        public ReadBinary(FileStream fs)
        {
            fs.Seek(0, SeekOrigin.Begin);
               binaryReader = new BinaryReader(fs);
        }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Item> Read()
        {
            List<Item> items = new List<Item>();
            binaryReader.ReadString();
            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {
                Item item = new Item();
                item.Date = DateTime.Parse(binaryReader.ReadString());
                binaryReader.ReadInt32();
                item.BrandName = binaryReader.ReadString();
                item.Price = binaryReader.ReadInt32();
                items.Add(item);
                items.Add(item);
            }
            return items;
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.binaryReader.Close();
        }

    }
}
