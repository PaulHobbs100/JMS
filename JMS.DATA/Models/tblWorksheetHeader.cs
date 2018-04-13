using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblWorksheetHeader
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblWorksheetHeader
    {
        public int fldClientID;
        public int fldCostCentreID;
        public DateTime fldJobWeek;
        public string fldNotes;
        public int fldWorksheetHeaderID;
        public DateTime fldLAstUpdate;
        public bool fldDeleted;
        public bool fldTimesheetsReceived;
        public bool fldArchived;
        public DateTime fldDAteArchived;

    }
}
