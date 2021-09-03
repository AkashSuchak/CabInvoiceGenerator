using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    //Class For Custom Exception Handlling
    class CabInvoiceException : Exception
    {
        /// <summary>
        /// Enum for Exception Type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVLID_DISTANCE,
            INVALID_TIME,
            INVALID_RIDES,
            INVALID_USER_ID,
            NULL_RIDES
        }
        ExceptionType type;

        /// <summary>
        /// Parameter  Constructor for Setting Exception Type and Throwing Exception
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}