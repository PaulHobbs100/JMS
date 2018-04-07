using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{   /*************************************************************************
     * Table: tblClient_Rate
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class tblClient_Rate
    {
        public int fldID;
        public int fldClientID;
        public int fldCostCentreID;
        public decimal fldBasicCharge;
        public string fldBasicDayHours;
        public decimal fldBasicPay;
        public string fldName;
        public decimal fldNightAllowance;
        public string fldNote;
        public decimal fldOvertimeCharge;
        public string fldOvertimeHours;
        public decimal fldOvertimePay;
        public int fldPartOfDay;
        public decimal fldSundayCharge;
        public string fldSundayHours;
        public decimal fldSundayPay;
        public string fldWorkingHours;
        public DateTime fldLastUpdate;
        public bool fldInactive;
        public bool fldArchived;
        public DateTime fldDateArcived;
        public decimal fldTransportCharge;
        public bool fldOverideDefaultTransportCharge;
        public decimal fldOvr2Chg;
        public string fldOvr2Hrs;
        public decimal fldOvr2Pay;
        public string fldNote2;
        public string fldNote3;


    }
}
