using System;
using System.Collections.Generic;
using System.Text;

namespace JMS.DATA.Models
{
    /*************************************************************************
     * Table: tblActions
     * Notes: 
     * Version: 0.1, Initial conversion of Access97 table
     *************************************************************************/
    class tblActions
    {
        public int fldActionID;
        public int fldActionType;
        public int fldActionStatus;
        public string fldNotes;
        public DateTime fldActionDate;
        public string fldActionCreatedBy;
        public string fldActionFor;
        public int fldClientID;
        public string fldClientContact;
    }
}
