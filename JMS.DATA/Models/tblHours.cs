using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{ /*************************************************************************
     * Table: tblHours
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblHours
    {
        public int fldID;
        public int fldWorksheetHeaderID;
        public int fldWorksheetDetailID;
        public int fldDayNo;
        public bool fldNeedsTransport;
        public int fldOvrHours;
        public int fldState;
        public int fldStdHours;
        public int fldSunHours;
        public DateTime fldLastUpdate;

    }
}
