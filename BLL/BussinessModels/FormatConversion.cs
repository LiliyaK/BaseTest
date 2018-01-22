using BLL.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BussinessModels
{
    /// <summary>
    /// The class for format conversion
    /// </summary>
    public class FormatConversion
    {
        /// <summary>
        /// The file
        /// </summary>
        FileDTO file;
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatConversion"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public FormatConversion(FileDTO file)
        {
            this.file = file;
        }
        /// <summary>
        /// Converses this instance.
        /// </summary>
        /// <returns></returns>
        public string Converse()
        {
            if (this.file.Extention == ".xml")
                return Path.ChangeExtension(this.file.FileRoot, ".bin");
            else
                return Path.ChangeExtension(this.file.FileRoot, ".xml");
        }
    }
}
