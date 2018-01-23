using BLL.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.ReadWriteFile;
using AutoMapper;
using DAL.Entities;
using BLL.BussinessModels;
using Core.Infrastructure;

namespace BLL.Services
{
    /// <summary>
    /// class implementing interface for choosing methods for reading and writing the file 
    /// </summary>
    /// <seealso cref="BLL.IFileService" />
    public class FileService:  IFileService,IDisposable
    {
        /// <summary>
        /// The reader
        /// </summary>
        IRead reader;
        /// <summary>
        /// The writer
        /// </summary>
        IWrite writer;
        /// <summary>
        /// The file
        /// </summary>
        FileDTO file;
        /// <summary>
        /// Initializes a new instance of the <see cref="FileService"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public FileService(string root)
        {
            this.file = new FileDTO(root);
        }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ItemDTO> Read()
        {
            if (this.file.fileStream.Length == 0)
            {
                return new List<ItemDTO>();
            }
            else
            if (this.file.Extention == ".xml")
                reader = new ReadXML(this.file.fileStream);
            if (this.file.Extention == ".bin")
                reader = new ReadBinary(this.file.fileStream);
            return Mapper.Map<IEnumerable<Item>, IEnumerable<ItemDTO>>(reader.Read());
        }
        /// <summary>
        /// Writes the specified items.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="IsConverted">if set to <c>true</c> [is converted].</param>
        /// <exception cref="ValidationException">Id is not initialized</exception>
        public void Write(IEnumerable<ItemDTO> items, bool IsConverted)
        {
            if (items == null)
            {
                throw new ValidationException("Item is not initialized", System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            if (IsConverted == true)
                this.file = new FileDTO(new FormatConversion(this.file).Converse());
            if (this.file.Extention == ".xml")
                writer = new WriteXML(this.file.fileStream);
            if (this.file.Extention == ".bin")
                writer = new WriteBinary(this.file.fileStream);
            writer.Write(Mapper.Map<IEnumerable<ItemDTO>, IEnumerable<Item>>(items));
        }

        public void Dispose()
        {
            this.file.fileStream.Close();
        }
    }
}
