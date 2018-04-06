using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{   /*************************************************************************
     * Table: tblBookings
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class tblBookings
    {
        public int fldBookingID;
        public DateTime fldWeekStartDate;
        public int fldClientID;
        public int fldRateID;
        public string fldContact;
        public int fldMon;
        public int fldTue;
        public int fldWed;
        public int fldThu;
        public int fldFri;
        public int fldSat;
        public int fldSun;
        public int fldNotes;
        public DateTime fldLastUpdated;
        public string fldLastUpdatedBy;
        public string fldPurchaseOrder;
    }
}
