using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblUsers
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblUsers
    {
        public int fldUserID;
        public string fldUserName;
        public string fldPassword;
        public string fldAccess;
        public string fldFullName;
        public bool fldDisabled;
        public bool fldCurrentLogOnStatus;
        public bool fldPayrollManager;
        public bool fldSMSUser;
    }
}
