using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblStaffAttributeChangelog
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblStaffAttributeChangelog
    {
        public int fldLogID;
        public int fldStaffID;
        public int fldAttributeID;
        public DateTime fldChangeDate;
        public string fldUserID;
    }
}
