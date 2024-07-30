using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.DTOs
{  
    public class CWIContextModel
    {
        public int ContextId { get; set; }
        public string ContextTag { get; set; }
        public int DBTableId { get; set; }
        public int DBRowId { get; set; }
        public MemberEvent MemberEvent { get; set; }
    }
    public class MemberEvent
    {
        public int MemberEventId { get; set; }
        public int MemberId { get; set; }
        public int FutureBatchSetId { get; set; }
        public int StatusCd { get; set; }
        public int EventTypeCd { get; set; }
        public int EventSubTypeCd { get; set; }
        public string CommitDt { get; set; }
        public string BillingDt { get; set; }
        public string EffectiveDt { get; set; }
        public string WorkFlowKeyTxt { get; set; }
        public int StageCd { get; set; }
        public string SupplementalInfoTxt { get; set; }
        public string StartDt { get; set; }
        public FutureBatchSet FutureBatchSet { get; set; }
    }

    public class ContextToVoKeyMap
    {
        public int ContextKey { get; set; }
        public int VoKey { get; set; }
    }

    public class CommitContextModel
    {
        public List<ContextToVoKeyMap> ContextToVoKeyMap { get; set; }
        public bool IsCommitted { get; set; }
        public List<ValidationMessage> ValidationMessages { get; set; }
    }

    public class FutureBatchSet
    {
        public int FutureBatchSetId { get; set; }
        public int ClientId { get; set; }
        public int OperProfileId { get; set; }
        public string ToBeAppliedDt { get; set; }
        public bool AppliedFlg { get; set; }
        public string BillingDt { get; set; }
        public bool HoldFlg { get; set; }
        public int FutBatchSetNmCd { get; set; }
        public string BatchSetStartDt { get; set; }
        public string BatchSetEndDt { get; set; }
        public string ExtensionDt { get; set; }
        public string LabelTxt { get; set; }
    }
}
