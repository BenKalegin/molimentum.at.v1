﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LumiSoft.Net.IMAP.Client
{
    /// <summary>
    /// This class represents FETCH RFC822.SIZE data item. Defined in RFC 3501.
    /// </summary>
    public class IMAP_Client_FetchArg_Rfc822Size : IMAP_Client_FetchArg
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public IMAP_Client_FetchArg_Rfc822Size()
        {
        }


        #region override method ToString

        /// <summary>
        /// Returns this as string.
        /// </summary>
        /// <returns>Returns this as string.</returns>
        public override string ToString()
        {
            return "RFC822.SIZE";
        }

        #endregion
    }
}
