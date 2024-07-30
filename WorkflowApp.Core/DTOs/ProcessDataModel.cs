using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.DTOs
{
    public class ProcessDataModel
    {  
            public int TransactionID { get; set; }
            public int SystemID { get; set; }
            public int ClientID { get; set; }
            public int MemberID { get; set; }
            public int MemberStatus { get; set; }
            public string TransformedJson { get; set; }
            public int TransctionCategory { get; set; }  //1 : Dependent Add
                                                         //2: Dependent Update
                                                         //3: Member transfer
            public DateTime TranscationDate { get; set; }
            public string CreatedDate { get; set; }
    }
}
