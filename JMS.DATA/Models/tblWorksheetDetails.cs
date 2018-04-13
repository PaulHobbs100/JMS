using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblWorksheetDetails
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblWorksheetDetails
    {
        public string fldNotes;
        public decimal fldOvrChg;
        public decimal fldOvrPay;
        public int fldRateID;
        public int fldStaffID;
        public decimal fldStdChg;
        public decimal fldStdPay;
        public decimal fldSunChg;
        public decimal fldSunPay;
        public int fldWorksheetDetailID;
        public int fldWorksheetHeaderID;
        public DateTime fldLastUpdate;
        public bool fldDeleted;
        public bool fldTimesheetReceived;
        public int fldTimesheetStatus;
        public bool fldArchived;
        public DateTime fldDateArchived;
        public int fldBatchID;
        public decimal fldOvr2Chg;
        public decimal fldOvr2Pay;
    }
}
