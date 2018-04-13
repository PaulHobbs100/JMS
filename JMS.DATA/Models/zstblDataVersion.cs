using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: zstblDataVersion
     * Notes: only needed for Access tables, rdundant on sql server.
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class zstblDataVersion
    {
        public int fldMajor;
        public int fldMinor;
        public int fldRevision;
        public int fldTweak;
    }
}
