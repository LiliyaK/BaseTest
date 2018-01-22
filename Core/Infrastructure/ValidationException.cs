using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure
{
    /// <summary>
    /// class for specify the exception type
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ValidationException : Exception
    {
        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        /// <value>
        /// The property.
        /// </value>
        public string Property { get; protected set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="prop">The property.</param>
        public ValidationException(string message, string prop) : base(message)
        {
            Property = prop;
        }

    }

}
