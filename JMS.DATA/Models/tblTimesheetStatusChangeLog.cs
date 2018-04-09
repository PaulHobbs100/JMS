using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblTimesheetStatusChangeLog
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class tblTimesheetStatusChangeLog
    {
        public int fldLogID;
        public int fldWorksheetDetailID;
        public int fldTimesheetStatus;
        public string fldUsername;
        public DateTime fldDateTime;
    }
}
