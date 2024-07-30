using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp.Core.DTOs
{
    /// <summary>
    /// Response model
    /// </summary>
    public partial class ResponseModel
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Href")]
        public string Href { get; set; }

        /// <summary>
        /// Returns the Id of the saved record
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Indicates if the Context was saved during the execution of the request.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Saved")]
        public bool? Saved { get; set; }

        /// <summary>
        /// Gets or sets the calculation data.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CalculationData")]
        public MemberCalculationViewModel CalculationData { get; set; }

        /// <summary>
        /// Gets or sets the validation messages.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ValidationMessages")]
        public System.Collections.Generic.ICollection<ValidationMessage> ValidationMessages { get; set; }

        /// <summary>
        /// Gets or sets the display rule results.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DisplayRuleResults")]
        public System.Collections.Generic.ICollection<DisplayRuleResult> DisplayRuleResults { get; set; }

        /// <summary>
        /// Indicates for which benefits a Declaration is required due to Comparable Coverage.
        /// <br/>The declaration may be required for Member, Dependent or both.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ComparableCoverageRequired")]
        public System.Collections.Generic.ICollection<ComparableCoverageRequiredDeclaration> ComparableCoverageRequired { get; set; }

        /// <summary>
        /// Gets or sets the dependent type rules.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DependentTypeRules")]
        public System.Collections.Generic.ICollection<DependentTypeRule> DependentTypeRules { get; set; }

        /// <summary>
        /// This contains a list of option pending approval for benefits. Only populated when pendingApproval=true is requested.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PendingApproval")]
        public System.Collections.Generic.ICollection<PendingApprovalViewModel> PendingApproval { get; set; }
    }

    // <summary>
    /// Class MemberCalculationViewModel.
    /// </summary>
    public partial class MemberCalculationViewModel
    {
        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberId")]
        public int? MemberId { get; set; }

        /// <summary>
        /// Gets or sets the empl flex credits amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmplFlexCreditsAmt")]
        public double? EmplFlexCreditsAmt { get; set; }

        /// <summary>
        /// Gets or sets the empl opt credits amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmplOptCreditsAmt")]
        public double? EmplOptCreditsAmt { get; set; }

        /// <summary>
        /// Gets the funding pool1 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool1Amt")]
        public double? FundingPool1Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool5 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool5Amt")]
        public double? FundingPool5Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool6 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool6Amt")]
        public double? FundingPool6Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool7 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool7Amt")]
        public double? FundingPool7Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool8 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool8Amt")]
        public double? FundingPool8Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool9 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool9Amt")]
        public double? FundingPool9Amt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool10 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool10Amt")]
        public double? FundingPool10Amt { get; set; }

        /// <summary>
        /// Gets or sets the flex balance amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FlexBalanceAmt")]
        public double? FlexBalanceAmt { get; set; }

        /// <summary>
        /// Gets or sets the memb funded pool amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MembFundedPoolAmt")]
        public double? MembFundedPoolAmt { get; set; }

        /// <summary>
        /// Gets or sets the suppl flex credit amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SupplFlexCreditAmt")]
        public double? SupplFlexCreditAmt { get; set; }

        /// <summary>
        /// Gets the remaining pool1 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool1Amt")]
        public double? RemainingPool1Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool5 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool5Amt")]
        public double? RemainingPool5Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool6 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool6Amt")]
        public double? RemainingPool6Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool7 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool7Amt")]
        public double? RemainingPool7Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool8 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool8Amt")]
        public double? RemainingPool8Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool9 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool9Amt")]
        public double? RemainingPool9Amt { get; set; }

        /// <summary>
        /// Gets the remaining pool10 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RemainingPool10Amt")]
        public double? RemainingPool10Amt { get; set; }

        /// <summary>
        /// Gets or sets the prem tot amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PremTotAmt")]
        public double? PremTotAmt { get; set; }

        /// <summary>
        /// Gets or sets the prem memb amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PremMembAmt")]
        public double? PremMembAmt { get; set; }

        /// <summary>
        /// Gets or sets the core tot amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoreTotAmt")]
        public double? CoreTotAmt { get; set; }

        /// <summary>
        /// Gets or sets the core tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoreTaxAmt")]
        public double? CoreTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the sales tax tot amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SalesTaxTotAmt")]
        public double? SalesTaxTotAmt { get; set; }

        /// <summary>
        /// Gets or sets the sales tax memb amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SalesTaxMembAmt")]
        public double? SalesTaxMembAmt { get; set; }

        /// <summary>
        /// Gets or sets the fed taxbl amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FedTaxblAmt")]
        public double? FedTaxblAmt { get; set; }

        /// <summary>
        /// Gets or sets the prov taxbl amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ProvTaxblAmt")]
        public double? ProvTaxblAmt { get; set; }

        /// <summary>
        /// Gets or sets the prov taxbl j amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ProvTaxblJAmt")]
        public double? ProvTaxblJAmt { get; set; }

        /// <summary>
        /// Gets or sets the prov taxbl l amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ProvTaxblLAmt")]
        public double? ProvTaxblLAmt { get; set; }

        /// <summary>
        /// Gets or sets the ind payroll amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IndPayrollAmt")]
        public double? IndPayrollAmt { get; set; }

        /// <summary>
        /// Gets or sets the ind tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IndTaxAmt")]
        public double? IndTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the price tag amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PriceTagAmt")]
        public double? PriceTagAmt { get; set; }

        /// <summary>
        /// Gets or sets all credits amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("AllCreditsAmt")]
        public double? AllCreditsAmt { get; set; }

        /// <summary>
        /// Gets or sets the tax free life amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TaxFreeLifeAmt")]
        public double? TaxFreeLifeAmt { get; set; }

        /// <summary>
        /// Gets or sets the direct payroll amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DirectPayrollAmt")]
        public double? DirectPayrollAmt { get; set; }

        /// <summary>
        /// Gets or sets the direct tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DirectTaxAmt")]
        public double? DirectTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the total payroll amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalPayrollAmt")]
        public double? TotalPayrollAmt { get; set; }

        /// <summary>
        /// Gets or sets the price tag tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PriceTagTaxAmt")]
        public double? PriceTagTaxAmt { get; set; }

        /// <summary>
        /// Gets the total option cost.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalOptionCost")]
        public double? TotalOptionCost { get; set; }

        /// <summary>
        /// Gets the total option cost tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalOptionCostTax")]
        public double? TotalOptionCostTax { get; set; }

        /// <summary>
        /// Gets the total credit allocation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalCreditAllocation")]
        public double? TotalCreditAllocation { get; set; }

        /// <summary>
        /// Gets the total credit allocation tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalCreditAllocationTax")]
        public double? TotalCreditAllocationTax { get; set; }

        /// <summary>
        /// Gets the total member cost.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalMemberCost")]
        public double? TotalMemberCost { get; set; }

        /// <summary>
        /// Gets the total member cost tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("TotalMemberCostTax")]
        public double? TotalMemberCostTax { get; set; }

        /// <summary>
        /// Gets the grand total option cost.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GrandTotalOptionCost")]
        public double? GrandTotalOptionCost { get; set; }

        /// <summary>
        /// Gets the grand total credit allocation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GrandTotalCreditAllocation")]
        public double? GrandTotalCreditAllocation { get; set; }

        /// <summary>
        /// Gets the grand total member cost.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GrandTotalMemberCost")]
        public double? GrandTotalMemberCost { get; set; }

        /// <summary>
        /// Gets the grand total employer premium (premium + tax).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GrandTotalEmployerPremium")]
        public double? GrandTotalEmployerPremium { get; set; }

        /// <summary>
        /// Gets the grand total premium (premium + tax).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("GrandTotalPremium")]
        public double? GrandTotalPremium { get; set; }

        /// <summary>
        /// Gets or sets the member benefit calculation.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberBenefitCalculation")]
        public System.Collections.Generic.ICollection<MemberBenefitCalculation> MemberBenefitCalculation { get; set; }

        /// <summary>
        /// Group MemberBenefitCalculation by BillingTypeCd (resolved based on the BillTypeCd)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CalcByBillingTypes")]
        public System.Collections.Generic.ICollection<CalcByBillingType> CalcByBillingTypes { get; set; }

    }
    public partial class ValidationMessage
    {
        /// <summary>
        /// Validation error number
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Number")]
        public int? Number { get; set; }

        /// <summary>
        /// Error message in the indicated Language from the Accept-Language header
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Severity value for the error message.  255 is the system default severity
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Severity")]
        public int? Severity { get; set; }

        /// <summary>
        /// Indicates the source of the validation message.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Source")]
        public string Source { get; set; }

    }
    public partial class DisplayRuleResult
    {
        /// <summary>
        /// Represents the type of the rule.  either "benefit" or "option"
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Type")]
        public string Type { get; set; }

        /// <summary>
        /// Contains the key for the display rule item
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Key")]
        public string Key { get; set; }

        /// <summary>
        /// The type for the key.  This will denote the field name the key represents
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("KeyType")]
        public string KeyType { get; set; }

        /// <summary>
        /// Indicates if the item in question should be displayed.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Display")]
        public bool? Display { get; set; }

        /// <summary>
        /// This indicates how the item in question should be displayed
        /// <br/> 1 - Show
        /// <br/> 2 - Disable
        /// <br/> 3 - Hide
        /// <br/> 4 - Hide with Message
        /// <br/> 5 - Disable with Message
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DisplayCd")]
        public int? DisplayCd { get; set; }

        /// <summary>
        /// Message number for the display rule if applicable
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MessageNumber")]
        public int? MessageNumber { get; set; }

        /// <summary>
        /// The associated message if one was set in the display rule.  The language will be returned according to the Accept Header
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Child display rule results
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ChildRuleResults")]
        public System.Collections.Generic.ICollection<DisplayRuleResult> ChildRuleResults { get; set; }

    }
    public partial class ComparableCoverageRequiredDeclaration
    {
        /// <summary>
        /// Gets or sets the member benefit identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberBenefitId")]
        public int? MemberBenefitId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [member required].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberRequired")]
        public bool? MemberRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [dependent required].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DependentRequired")]
        public bool? DependentRequired { get; set; }

        /// <summary>
        /// Gets or sets the extra information cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ExtraInfoCd")]
        public int? ExtraInfoCd { get; set; }

    }
    public partial class DependentTypeRule
    {
        /// <summary>
        /// Gets or sets the dep type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DepTypeCd")]
        public int? DepTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the error message nm cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ErrorMessageNmCd")]
        public int? ErrorMessageNmCd { get; set; }

        /// <summary>
        /// Gets or sets the error message nm text.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ErrorMessageNmTxt")]
        public string ErrorMessageNmTxt { get; set; }

        /// <summary>
        /// Gets or sets the covered dep required cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoveredDepRequiredCd")]
        public int? CoveredDepRequiredCd { get; set; }

        /// <summary>
        /// Gets or sets the validate cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ValidateCd")]
        public int? ValidateCd { get; set; }

        /// <summary>
        /// Gets or sets the rule text.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RuleTxt")]
        public string RuleTxt { get; set; }

    }
    public partial class PendingApprovalViewModel
    {
        /// <summary>
        /// Primary key of Pending approval record for this benefit
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PendingApprovalId")]
        public int? PendingApprovalId { get; set; }

        /// <summary>
        /// Member benefit priamry key that this pending approval record is for.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberBenefitId")]
        public int? MemberBenefitId { get; set; }

        /// <summary>
        /// Current option id that the benefit is currently in.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CurrentOptionId")]
        public int? CurrentOptionId { get; set; }

        /// <summary>
        /// Option Id for the option the member is requesting.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestingOptionId")]
        public int? RequestingOptionId { get; set; }

        /// <summary>
        /// Current volume amt of the member benefit. Null if not changed by option change.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CurrentVolumeAmt")]
        public int? CurrentVolumeAmt { get; set; }

        /// <summary>
        /// Volume Amt the member is requesting. Null if not changed by option change.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestingVolumeAmt")]
        public int? RequestingVolumeAmt { get; set; }

        /// <summary>
        /// Current requested amt of the member benefit. Null if not changed by option change.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CurrentRequestedAmt")]
        public int? CurrentRequestedAmt { get; set; }

        /// <summary>
        /// Requested Amt the member is requesting. Null if not changed by option change.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestingRequestedAmt")]
        public int? RequestingRequestedAmt { get; set; }

        /// <summary>
        /// Approval type, to indicate if this is assume approved or assume not approved.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PendingApprovalTypeCd")]
        public int? PendingApprovalTypeCd { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("CreateDt")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? CreateDt { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDt")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EffectiveDt { get; set; }

    }
    public partial class MemberBenefitCalculation
    {
        /// <summary>
        /// Gets or sets the member benefit identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberBenefitId")]
        public int? MemberBenefitId { get; set; }

        /// <summary>
        /// Gets or sets the client plan ben opt identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ClientPlanBenOptId")]
        public int? ClientPlanBenOptId { get; set; }

        /// <summary>
        /// Gets or sets the client plan bene identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ClientPlanBeneId")]
        public int? ClientPlanBeneId { get; set; }

        /// <summary>
        /// Gets or sets the client bene identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ClientBeneId")]
        public int? ClientBeneId { get; set; }

        /// <summary>
        /// Gets or sets the bene type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BeneTypeCd")]
        public int? BeneTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the dep type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DepTypeCd")]
        public int? DepTypeCd { get; set; }

        /// <summary>
        /// Gets or sets effective date.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDt")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EffectiveDt { get; set; }

        /// <summary>
        /// Gets or sets the volume amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("VolumeAmt")]
        public double? VolumeAmt { get; set; }

        /// <summary>
        /// Gets or sets the prem total amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PremTotalAmt")]
        public double? PremTotalAmt { get; set; }

        /// <summary>
        /// Gets or sets the direct contrib amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("DirectContribAmt")]
        public double? DirectContribAmt { get; set; }

        /// <summary>
        /// Gets or sets the sales tax total amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SalesTaxTotalAmt")]
        public double? SalesTaxTotalAmt { get; set; }

        /// <summary>
        /// Gets or sets the sales tax direct amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("SalesTaxDirectAmt")]
        public double? SalesTaxDirectAmt { get; set; }

        /// <summary>
        /// Gets or sets the core total amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoreTotalAmt")]
        public double? CoreTotalAmt { get; set; }

        /// <summary>
        /// Gets or sets the core tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoreTaxAmt")]
        public double? CoreTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the cred to price amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CredToPriceAmt")]
        public double? CredToPriceAmt { get; set; }

        /// <summary>
        /// Gets or sets the cred to price tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CredToPriceTaxAmt")]
        public double? CredToPriceTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the indirect payroll amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IndirectPayrollAmt")]
        public double? IndirectPayrollAmt { get; set; }

        /// <summary>
        /// Gets or sets the indirect tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IndirectTaxAmt")]
        public double? IndirectTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the price tag amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PriceTagAmt")]
        public double? PriceTagAmt { get; set; }

        /// <summary>
        /// Gets or sets the price tag tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PriceTagTaxAmt")]
        public double? PriceTagTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the requested amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedAmt")]
        public double? RequestedAmt { get; set; }

        /// <summary>
        /// Gets or sets the approval cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ApprovalCd")]
        public int? ApprovalCd { get; set; }

        /// <summary>
        /// Gets or sets the approval reason cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ApprovalReasonCd")]
        public int? ApprovalReasonCd { get; set; }

        /// <summary>
        /// Gets or sets the approval amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ApprovalAmt")]
        public double? ApprovalAmt { get; set; }

        /// <summary>
        /// Gets or sets the requested units amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedUnitsAmt")]
        public double? RequestedUnitsAmt { get; set; }

        /// <summary>
        /// Gets or sets the covered salary amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoveredSalaryAmt")]
        public double? CoveredSalaryAmt { get; set; }

        /// <summary>
        /// Gets or sets the fed tax benft amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FedTaxBenftAmt")]
        public double? FedTaxBenftAmt { get; set; }

        /// <summary>
        /// Gets or sets the fed tax benft tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FedTaxBenftTaxAmt")]
        public double? FedTaxBenftTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the box j amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BoxJAmt")]
        public double? BoxJAmt { get; set; }

        /// <summary>
        /// Gets or sets the box j tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BoxJTaxAmt")]
        public double? BoxJTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the box l amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BoxLAmt")]
        public double? BoxLAmt { get; set; }

        /// <summary>
        /// Gets or sets the box l tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BoxLTaxAmt")]
        public double? BoxLTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the lock in date.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("LockInDt")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? LockInDt { get; set; }

        /// <summary>
        /// Gets or sets the emplyr cost amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmplyrCostAmt")]
        public double? EmplyrCostAmt { get; set; }

        /// <summary>
        /// Gets or sets the emplyr cost tax amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmplyrCostTaxAmt")]
        public double? EmplyrCostTaxAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool1 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool1AllocationAmt")]
        public double? FundingPool1AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool5 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool5AllocationAmt")]
        public double? FundingPool5AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool6 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool6AllocationAmt")]
        public double? FundingPool6AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool7 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool7AllocationAmt")]
        public double? FundingPool7AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool8 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool8AllocationAmt")]
        public double? FundingPool8AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool9 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool9AllocationAmt")]
        public double? FundingPool9AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the funding pool10 allocation amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("FundingPool10AllocationAmt")]
        public double? FundingPool10AllocationAmt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool1 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool1Amt")]
        public double? RequestedPool1Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool5 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool5Amt")]
        public double? RequestedPool5Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool6 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool6Amt")]
        public double? RequestedPool6Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool7 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool7Amt")]
        public double? RequestedPool7Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool8 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool8Amt")]
        public double? RequestedPool8Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool9 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool9Amt")]
        public double? RequestedPool9Amt { get; set; }

        /// <summary>
        /// Gets or sets the requested pool10 amt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("RequestedPool10Amt")]
        public double? RequestedPool10Amt { get; set; }

        /// <summary>
        /// Gets or sets the v billing type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("VBillingTypeCd")]
        public int? VBillingTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the v bene code txt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("VBeneCodeTxt")]
        public string VBeneCodeTxt { get; set; }

        /// <summary>
        /// Gets or sets the v option flex code txt.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("VOptionFlexCodeTxt")]
        public string VOptionFlexCodeTxt { get; set; }

        /// <summary>
        /// Gets or sets the status cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("StatusCd")]
        public int? StatusCd { get; set; }

        /// <summary>
        /// Gets the option cost.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("OptionCost")]
        public double? OptionCost { get; set; }

        /// <summary>
        /// Gets the option cost tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("OptionCostTax")]
        public double? OptionCostTax { get; set; }

        /// <summary>
        /// Gets the member cost (employee premium).
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberCost")]
        public double? MemberCost { get; set; }

        /// <summary>
        /// Gets the member cost tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberCostTax")]
        public double? MemberCostTax { get; set; }

        /// <summary>
        /// Gets the member cost with tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("MemberCostWithTax")]
        public double? MemberCostWithTax { get; set; }

        /// <summary>
        /// Gets the employer premium.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmployerPremium")]
        public double? EmployerPremium { get; set; }

        /// <summary>
        /// Gets the employer premium tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmployerPremiumTax")]
        public double? EmployerPremiumTax { get; set; }

        /// <summary>
        /// Gets the employer premium with tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EmployerPremiumWithTax")]
        public double? EmployerPremiumWithTax { get; set; }

        /// <summary>
        /// Gets the premium total with tax.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PremTotalWithTax")]
        public double? PremTotalWithTax { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("IsBeneficiaryRequired")]
        public bool? IsBeneficiaryRequired { get; set; }

        /// <summary>
        /// Gets or sets the calculation result items.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CalculationResultItems")]
        public System.Collections.Generic.ICollection<CalcResultItem> CalculationResultItems { get; set; }

        /// <summary>
        /// Gets or sets the calculation information.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CalculationInfo")]
        public BenefitCalculationInfo CalculationInfo { get; set; }

        /// <summary>
        /// Gets the waiting period information.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("WaitingPeriodInformation")]
        public WaitingPeriod WaitingPeriodInformation { get; set; }

        /// <summary>
        /// Gets the client plan ben opt status cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IsHierTerminated")]
        public bool? IsHierTerminated { get; set; }

    }
    public partial class CalcByBillingType
    {
        /// <summary>
        /// Gets or sets the billing type cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("BillingTypeCd")]
        public int? BillingTypeCd { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Amount")]
        public double? Amount { get; set; }

    }
    public partial class CalcResultItem
    {

        [System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Value")]
        public object Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("Applied")]
        public bool? Applied { get; set; }

    }
    public partial class BenefitCalculationInfo
    {

        [System.Text.Json.Serialization.JsonPropertyName("MinimumApplied")]
        public bool? MinimumApplied { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("IsVolumeBasedNewHireNem")]
        public bool? IsVolumeBasedNewHireNem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [overall maximum applied].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("OverallMaxApplied")]
        public bool? OverallMaxApplied { get; set; }

        /// <summary>
        /// Gets or sets the overall maximum.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("OverallMax")]
        public double? OverallMax { get; set; }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Minimum")]
        public double? Minimum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [combined maximum applied].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CombinedMaxApplied")]
        public bool? CombinedMaxApplied { get; set; }

        /// <summary>
        /// Gets or sets the combined maximum.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CombinedMax")]
        public double? CombinedMax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [combined nem applied].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CombinedNemApplied")]
        public bool? CombinedNemApplied { get; set; }

        /// <summary>
        /// Gets or sets the combined nem.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CombinedNem")]
        public double? CombinedNem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [coverage reduced].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("CoverageReduced")]
        public bool? CoverageReduced { get; set; }

        /// <summary>
        /// Gets or sets the reduction amount.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ReductionAmount")]
        public double? ReductionAmount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is on waiver.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IsOnWaiver")]
        public bool? IsOnWaiver { get; set; }

        /// <summary>
        /// Gets or sets the evidence.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Evidence")]
        public EvidenceInfo Evidence { get; set; }

        /// <summary>
        /// Gets or sets the excess approval.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ExcessApproval")]
        public double? ExcessApproval { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is benefit over allocated.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("IsBenefitOverAllocated")]
        public bool? IsBenefitOverAllocated { get; set; }

        /// <summary>
        /// Gets or sets the pool over allocations.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PoolOverAllocations")]
        public System.Collections.Generic.ICollection<PoolOverAllocation> PoolOverAllocations { get; set; }

    }
    public partial class WaitingPeriod
    {
        /// <summary>
        /// Gets the effective date based on apply date.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDateBasedOnApplyDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EffectiveDateBasedOnApplyDate { get; set; }

        /// <summary>
        /// Gets the effective date based on billing date.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDateBasedOnBillingDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EffectiveDateBasedOnBillingDate { get; set; }

        /// <summary>
        /// Gets the effective date based on employment date.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EffectiveDateBasedOnEmploymentDate")]
        [System.Text.Json.Serialization.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTimeOffset? EffectiveDateBasedOnEmploymentDate { get; set; }

    }
    public partial class EvidenceInfo
    {

        [System.Text.Json.Serialization.JsonPropertyName("OptionBasedEvidenceRequired")]
        public bool? OptionBasedEvidenceRequired { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [volume based evidence required].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("VolumeBasedEvidenceRequired")]
        public bool? VolumeBasedEvidenceRequired { get; set; }

        /// <summary>
        /// Gets the type of the evidence. returns the following values (none, volume, option or both)
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("EvidenceType")]
        public string EvidenceType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [option changed].
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("OptionChanged")]
        public bool? OptionChanged { get; set; }

        /// <summary>
        /// Gets or sets the previous option identifier.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PreviousOptionId")]
        public int? PreviousOptionId { get; set; }

        /// <summary>
        /// Gets or sets the approval cd.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ApprovalCd")]
        public int? ApprovalCd { get; set; }

        /// <summary>
        /// Gets or sets the approved amount.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("ApprovedAmount")]
        public double? ApprovedAmount { get; set; }

    }
    public partial class PoolOverAllocation
    {
        /// <summary>
        /// Gets or sets the pool number.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("PoolNumber")]
        public int? PoolNumber { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("Amount")]
        public double? Amount { get; set; }

    }
    internal class DateFormatConverter : System.Text.Json.Serialization.JsonConverter<System.DateTimeOffset>
    {
        public override System.DateTimeOffset Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
        {
            var dateTime = reader.GetString();
            if (dateTime == null)
            {
                throw new System.Text.Json.JsonException("Unexpected JsonTokenType.Null");
            }

            return System.DateTimeOffset.Parse(dateTime);
        }

        public override void Write(System.Text.Json.Utf8JsonWriter writer, System.DateTimeOffset value, System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
        }
    }
}
