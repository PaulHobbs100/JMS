using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{ /*************************************************************************
     * Table: tblExportAuditTrail
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblExportAuditTrail
    {
        public int fldBatchID;
        public DateTime fldExportDate;
        public int fldTimesheetCount;
        public string fldExportedBy;
        public string fldExportFilename;
    }
}
