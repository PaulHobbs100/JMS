using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{   /*************************************************************************
     * Table: tblClient_Contract
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class tblClient_Contract
    {
        public int fldClientID;
        public int fldContactGroupID;
        public string fldTitle;
        public string fldContact;
        public string fldContactLastName;
        public int fldContactID;
        public string fldPhone;
        public string fldPosition;
        public DateTime fldLastUpdate;
        public bool fldDeleted;
        public string fldAddress1;
        public string fldAddress2;
        public string fldTown;
        public string fldCounty;
        public string fldPostcode;
        public string fldCountry;
        public bool fldArchived;
        public DateTime fldDateArchived;
        public string fldMobile;
        public string fldEmail;
        public string fldFAX;
        public bool fldSendTimesheet;
    }
}
