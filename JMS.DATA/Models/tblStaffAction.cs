using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{/*************************************************************************
     * Table: tblStaffAction
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/

    class tblStaffAction
    {
        public int fldStaffActionID;
        public string fldStaffActionType;
        public DateTime fldStaffActionDate;
        public string fldStaffActionCreatedBy;
        public int fldStaffID;
        public int fldActionStatus;
        public string fldStaffActionNotes;
        public DateTime fldActionEditDate;
    }
}
