using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using System.IO;

namespace DAL.ReadWriteFile
{
    /// <summary>
    /// Class implementing interface for writning to binary files
    /// </summary>
    /// <seealso cref="DAL.Interfaces.IWrite" />
    /// <seealso cref="System.IDisposable" />
    public class WriteBinary : IWrite,IDisposable
    {
        /// <summary>
        /// The binary writer
        /// </summary>
        BinaryWriter binaryWriter;
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteBinary"/> class.
        /// </summary>
        /// <param name="fs">The fs.</param>
        public WriteBinary(FileStream fs)
        {
            fs.Seek(0, SeekOrigin.Begin);
            binaryWriter = new BinaryWriter(fs);
            if(fs.Length==0)
                binaryWriter.Write("Cars");
        }
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        public void Write(IEnumerable<Item>items )
        {
            foreach (Item item in items)
            {
                binaryWriter.Write(item.Date.ToBinary());
                binaryWriter.Write(item.BrandName.Length);
                binaryWriter.Write(item.BrandName);
                binaryWriter.Write(item.Price);
            }
        }
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.binaryWriter.Close();
        }

    }
}
