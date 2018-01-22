using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    /// <summary>
    /// class data tranfer object for file information
    /// </summary>
    public class FileDTO
    {
        /// <summary>
        /// The file root
        /// </summary>
        private string root;
        /// <summary>
        /// Gets or sets the file stream.
        /// </summary>
        /// <value>
        /// The file stream.
        /// </value>
        public FileStream fileStream { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDTO"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public FileDTO(string root)
        {
            this.root = root;
        }
        /// <summary>
        /// Gets or sets the file root.
        /// </summary>
        /// <value>
        /// The file root.
        /// </value>
        public string FileRoot
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
        /// <summary>
        /// Gets the extention.
        /// </summary>
        /// <value>
        /// The extention.
        /// </value>
        public string Extention
        {
            get { return Path.GetExtension(this.root); }
        }
    }
}
