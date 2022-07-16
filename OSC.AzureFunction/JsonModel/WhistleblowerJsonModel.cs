using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OSC.AzureFunction.JsonModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CrmdOwbwebform
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("@odata.id")]
        public string OdataId { get; set; }

        [JsonProperty("@odata.etag")]
        public string OdataEtag { get; set; }

        [JsonProperty("@odata.editLink")]
        public string OdataEditLink { get; set; }

        [JsonProperty("crmd_fraudtimingpresent@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingpresentODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingpresent { get; set; }

        [JsonProperty("crmd_fraudtimingpast@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingpastODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingpast { get; set; }

        [JsonProperty("_crmd_wb3_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWb3ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wb3_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWb3ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wb3_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWb3ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wb3_value@odata.type")]
        public string CrmdWb3ValueOdataType { get; set; }
        public string _crmd_wb3_value { get; set; }

        [JsonProperty("crmd_insidertradingpast@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingpastODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingpast { get; set; }

        [JsonProperty("crmd_startyearfraudtimingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartyearfraudtimingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_startyearfraudtimingongoing { get; set; }
        public string crmd_startmonthinsidertradingongoing { get; set; }
        public string crmd_whoyoudealtwithatoscandwhen { get; set; }

        [JsonProperty("crmd_insidertradingnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingnotknown { get; set; }

        [JsonProperty("crmd_filestoupload@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFilestouploadODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_filestoupload { get; set; }

        [JsonProperty("crmd_miscondcorpdisclfinancialstatem@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMiscondcorpdisclfinancialstatemODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_miscondcorpdisclfinancialstatem { get; set; }

        [JsonProperty("crmd_startmiscondotherongoingunknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartmiscondotherongoingunknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_startmiscondotherongoingunknown { get; set; }

        [JsonProperty("crmd_misconductother@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductotherODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductother { get; set; }

        [JsonProperty("crmd_fraudtimingpastdatesnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingpastdatesnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingpastdatesnotknown { get; set; }

        [JsonProperty("crmd_youothersinvolinlegalproceed@OData.Community.Display.V1.FormattedValue")]
        public string CrmdYouothersinvolinlegalproceedODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_youothersinvolinlegalproceed { get; set; }

        [JsonProperty("crmd_startyearmisconductotherongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartyearmisconductotherongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_startyearmisconductotherongoing { get; set; }

        [JsonProperty("crmd_fraudtimingongoingdatenotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingongoingdatenotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingongoingdatenotknown { get; set; }
        public string crmd_additionaldocsandlocationofeach { get; set; }

        [JsonProperty("modifiedon@OData.Community.Display.V1.FormattedValue")]
        public string ModifiedonODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("modifiedon@odata.type")]
        public string ModifiedonOdataType { get; set; }
        public DateTime modifiedon { get; set; }
        public string crmd_startmocorpdisclosuretimingongoing { get; set; }

        [JsonProperty("crmd_illegaldistribunregtradenotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIllegaldistribunregtradenotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_illegaldistribunregtradenotknown { get; set; }

        [JsonProperty("crmd_misconductfraud@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductfraudODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductfraud { get; set; }

        [JsonProperty("crmd_illegaldistribunregtradingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIllegaldistribunregtradingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_illegaldistribunregtradingongoing { get; set; }

        [JsonProperty("crmd_startyrcorpdisclosuretimingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartyrcorpdisclosuretimingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_startyrcorpdisclosuretimingongoing { get; set; }
        public string crmd_describeyourinvolvement { get; set; }

        [JsonProperty("crmd_misconductotherongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductotherongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductotherongoing { get; set; }

        [JsonProperty("crmd_corporatedisclosuretimingfuture@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorporatedisclosuretimingfutureODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corporatedisclosuretimingfuture { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid4_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectindivid4ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid4_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectindivid4ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid4_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectindivid4ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid4_value@odata.type")]
        public string CrmdWbsubjectindivid4ValueOdataType { get; set; }
        public string _crmd_wbsubjectindivid4_value { get; set; }

        [JsonProperty("crmd_whistleblowers_making_submission@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWhistleblowersMakingSubmissionODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_whistleblowers_making_submission { get; set; }

        [JsonProperty("crmd_youlawyerpriorcommwithosconmiscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdYoulawyerpriorcommwithosconmiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_youlawyerpriorcommwithosconmiscond { get; set; }

        [JsonProperty("crmd_obtainwhileinqinv_violationsoflaw@OData.Community.Display.V1.FormattedValue")]
        public string CrmdObtainwhileinqinvViolationsoflawODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_obtainwhileinqinv_violationsoflaw { get; set; }

        [JsonProperty("crmd_docsnotincontroltosupportmisconduct@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDocsnotincontroltosupportmisconductODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_docsnotincontroltosupportmisconduct { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid5_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectindivid5ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid5_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectindivid5ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid5_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectindivid5ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid5_value@odata.type")]
        public string CrmdWbsubjectindivid5ValueOdataType { get; set; }
        public string _crmd_wbsubjectindivid5_value { get; set; }

        [JsonProperty("crmd_insidertradingpastdatesnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingpastdatesnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingpastdatesnotknown { get; set; }

        [JsonProperty("crmd_illegaldistribunregtradingpast@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIllegaldistribunregtradingpastODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_illegaldistribunregtradingpast { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid1_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectindivid1ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid1_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectindivid1ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid1_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectindivid1ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid1_value@odata.type")]
        public string CrmdWbsubjectindivid1ValueOdataType { get; set; }
        public string _crmd_wbsubjectindivid1_value { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid3_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectindivid3ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid3_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectindivid3ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid3_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectindivid3ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid3_value@odata.type")]
        public string CrmdWbsubjectindivid3ValueOdataType { get; set; }
        public string _crmd_wbsubjectindivid3_value { get; set; }

        [JsonProperty("crmd_corporatedisclosuretimingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorporatedisclosuretimingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corporatedisclosuretimingongoing { get; set; }

        [JsonProperty("crmd_startyrillegdistribunregtrdongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartyrillegdistribunregtrdongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_startyrillegdistribunregtrdongoing { get; set; }

        [JsonProperty("crmd_corporatedisclosuretimingnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorporatedisclosuretimingnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corporatedisclosuretimingnotknown { get; set; }

        [JsonProperty("crmd_insidertradingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingongoing { get; set; }

        [JsonProperty("statuscode@OData.Community.Display.V1.FormattedValue")]
        public string StatuscodeODataCommunityDisplayV1FormattedValue { get; set; }
        public int statuscode { get; set; }

        [JsonProperty("createdon@OData.Community.Display.V1.FormattedValue")]
        public string CreatedonODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("createdon@odata.type")]
        public string CreatedonOdataType { get; set; }
        public DateTime createdon { get; set; }
        public string crmd_typeandtimingoflegalproceedings { get; set; }

        [JsonProperty("crmd_misconductdonotknow@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductdonotknowODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductdonotknow { get; set; }

        [JsonProperty("crmd_owbwebformsid@odata.type")]
        public string CrmdOwbwebformsidOdataType { get; set; }
        public string crmd_owbwebformsid { get; set; }

        [JsonProperty("crmd_learnedsecuritiesmisconduct_year@OData.Community.Display.V1.FormattedValue")]
        public string CrmdLearnedsecuritiesmisconductYearODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_learnedsecuritiesmisconduct_year { get; set; }

        [JsonProperty("crmd_illegaldistribunregtradingfuture@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIllegaldistribunregtradingfutureODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_illegaldistribunregtradingfuture { get; set; }

        [JsonProperty("crmd_insidertradingfuture@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingfutureODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingfuture { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm4_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectfirm4ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm4_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectfirm4ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm4_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectfirm4ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm4_value@odata.type")]
        public string CrmdWbsubjectfirm4ValueOdataType { get; set; }
        public string _crmd_wbsubjectfirm4_value { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm5_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectfirm5ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm5_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectfirm5ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm5_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectfirm5ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm5_value@odata.type")]
        public string CrmdWbsubjectfirm5ValueOdataType { get; set; }
        public string _crmd_wbsubjectfirm5_value { get; set; }

        [JsonProperty("crmd_illegdistribunregtradepastdateunkn@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIllegdistribunregtradepastdateunknODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_illegdistribunregtradepastdateunkn { get; set; }

        [JsonProperty("crmd_misconductotherfuture@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductotherfutureODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductotherfuture { get; set; }
        public string crmd_youothersreasoninvolvlegalproceed { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm1_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectfirm1ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm1_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectfirm1ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm1_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectfirm1ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm1_value@odata.type")]
        public string CrmdWbsubjectfirm1ValueOdataType { get; set; }
        public string _crmd_wbsubjectfirm1_value { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm2_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectfirm2ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm2_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectfirm2ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm2_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectfirm2ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm2_value@odata.type")]
        public string CrmdWbsubjectfirm2ValueOdataType { get; set; }
        public string _crmd_wbsubjectfirm2_value { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm3_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectfirm3ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm3_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectfirm3ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm3_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectfirm3ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectfirm3_value@odata.type")]
        public string CrmdWbsubjectfirm3ValueOdataType { get; set; }
        public string _crmd_wbsubjectfirm3_value { get; set; }

        [JsonProperty("crmd_entities_involved_in_misconduct@OData.Community.Display.V1.FormattedValue")]
        public string CrmdEntitiesInvolvedInMisconductODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_entities_involved_in_misconduct { get; set; }

        [JsonProperty("crmd_havephysicaldocstomailtoowb@OData.Community.Display.V1.FormattedValue")]
        public string CrmdHavephysicaldocstomailtoowbODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_havephysicaldocstomailtoowb { get; set; }

        [JsonProperty("versionnumber@OData.Community.Display.V1.FormattedValue")]
        public string VersionnumberODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("versionnumber@odata.type")]
        public string VersionnumberOdataType { get; set; }
        public int versionnumber { get; set; }

        [JsonProperty("crmd_startyearinsidertradingongoing@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartyearinsidertradingongoingODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_startyearinsidertradingongoing { get; set; }

        [JsonProperty("crmd_corporatedisclosuretimingpast@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorporatedisclosuretimingpastODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corporatedisclosuretimingpast { get; set; }

        [JsonProperty("crmd_individuals_involved_misconduct@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualsInvolvedMisconductODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_individuals_involved_misconduct { get; set; }

        [JsonProperty("crmd_communicationwithothersecuritiesorg@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCommunicationwithothersecuritiesorgODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_communicationwithothersecuritiesorg { get; set; }

        [JsonProperty("crmd_startillegldistribunregtradeongunkn@OData.Community.Display.V1.FormattedValue")]
        public string CrmdStartillegldistribunregtradeongunknODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_startillegldistribunregtradeongunkn { get; set; }

        [JsonProperty("crmd_fraudtimingnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingnotknown { get; set; }

        [JsonProperty("crmd_insidertradingongoingdatenotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInsidertradingongoingdatenotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_insidertradingongoingdatenotknown { get; set; }

        [JsonProperty("_crmd_wb1_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWb1ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wb1_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWb1ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wb1_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWb1ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wb1_value@odata.type")]
        public string CrmdWb1ValueOdataType { get; set; }
        public string _crmd_wb1_value { get; set; }

        [JsonProperty("_crmd_wb2_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWb2ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wb2_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWb2ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wb2_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWb2ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wb2_value@odata.type")]
        public string CrmdWb2ValueOdataType { get; set; }
        public string _crmd_wb2_value { get; set; }
        public string crmd_detailsofinqinv_violationsoflaw { get; set; }

        [JsonProperty("_crmd_wb4_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWb4ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wb4_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWb4ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wb4_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWb4ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wb4_value@odata.type")]
        public string CrmdWb4ValueOdataType { get; set; }
        public string _crmd_wb4_value { get; set; }

        [JsonProperty("_crmd_wb5_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWb5ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wb5_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWb5ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wb5_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWb5ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wb5_value@odata.type")]
        public string CrmdWb5ValueOdataType { get; set; }
        public string _crmd_wb5_value { get; set; }
        public string crmd_factsleadingtobelievemisconduct { get; set; }

        [JsonProperty("_modifiedby_value@OData.Community.Display.V1.FormattedValue")]
        public string ModifiedbyValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_modifiedby_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string ModifiedbyValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_modifiedby_value@odata.type")]
        public string ModifiedbyValueOdataType { get; set; }
        public string _modifiedby_value { get; set; }

        [JsonProperty("crmd_tell_us_about_yourself@OData.Community.Display.V1.FormattedValue")]
        public string CrmdTellUsAboutYourselfODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_tell_us_about_yourself { get; set; }

        [JsonProperty("_createdby_value@OData.Community.Display.V1.FormattedValue")]
        public string CreatedbyValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_createdby_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CreatedbyValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_createdby_value@odata.type")]
        public string CreatedbyValueOdataType { get; set; }
        public string _createdby_value { get; set; }
        public string crmd_howlearnedaboutsecuritiesmisconduct { get; set; }

        [JsonProperty("crmd_miscondillegaldistribunregtrading@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMiscondillegaldistribunregtradingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_miscondillegaldistribunregtrading { get; set; }
        public string crmd_othersecuritiesmisconduct { get; set; }

        [JsonProperty("crmd_corpdisclosureongoingdatenotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorpdisclosureongoingdatenotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corpdisclosureongoingdatenotknown { get; set; }

        [JsonProperty("crmd_fraudtimingfuture@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFraudtimingfutureODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_fraudtimingfuture { get; set; }
        public string crmd_startmonthmisconductotherongoing { get; set; }

        [JsonProperty("crmd_misconductotherdatespastnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductotherdatespastnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductotherdatespastnotknown { get; set; }
        public string crmd_mag_securitiesrelatedmisconduct { get; set; }
        public string crmd_learnedsecuritiesmisconduct_month { get; set; }

        [JsonProperty("crmd_misconductothernotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductothernotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductothernotknown { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid2_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbsubjectindivid2ValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid2_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdWbsubjectindivid2ValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid2_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdWbsubjectindivid2ValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_wbsubjectindivid2_value@odata.type")]
        public string CrmdWbsubjectindivid2ValueOdataType { get; set; }
        public string _crmd_wbsubjectindivid2_value { get; set; }
        public string crmd_owbwebformrecordname { get; set; }

        [JsonProperty("crmd_anythingelsetomentionowb@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnythingelsetomentionowbODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_anythingelsetomentionowb { get; set; }
        public string crmd_additionaldetailsmentiondtoowb { get; set; }

        [JsonProperty("crmd_misconductotherinpast@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductotherinpastODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductotherinpast { get; set; }

        [JsonProperty("statecode@OData.Community.Display.V1.FormattedValue")]
        public string StatecodeODataCommunityDisplayV1FormattedValue { get; set; }
        public int statecode { get; set; }
        public string crmd_startmonthfraudtimingongoing { get; set; }
        public string crmd_startmoillegaldistribunregtrdong { get; set; }

        [JsonProperty("_organizationid_value@OData.Community.Display.V1.FormattedValue")]
        public string OrganizationidValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_organizationid_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string OrganizationidValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_organizationid_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string OrganizationidValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_organizationid_value@odata.type")]
        public string OrganizationidValueOdataType { get; set; }
        public string _organizationid_value { get; set; }

        [JsonProperty("crmd_providedocstosupportmisconduct@OData.Community.Display.V1.FormattedValue")]
        public string CrmdProvidedocstosupportmisconductODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_providedocstosupportmisconduct { get; set; }

        [JsonProperty("crmd_corpdisclosurepastdatesnotknown@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCorpdisclosurepastdatesnotknownODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_corpdisclosurepastdatesnotknown { get; set; }

        [JsonProperty("crmd_misconductillegalinsidertrading@OData.Community.Display.V1.FormattedValue")]
        public string CrmdMisconductillegalinsidertradingODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_misconductillegalinsidertrading { get; set; }

        [JsonProperty("crmd_wb3@odata.associationLink")]
        public string CrmdWb3OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb3@odata.navigationLink")]
        public string CrmdWb3OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid4@odata.associationLink")]
        public string CrmdWbsubjectindivid4OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid4@odata.navigationLink")]
        public string CrmdWbsubjectindivid4OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid5@odata.associationLink")]
        public string CrmdWbsubjectindivid5OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid5@odata.navigationLink")]
        public string CrmdWbsubjectindivid5OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid1@odata.associationLink")]
        public string CrmdWbsubjectindivid1OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid1@odata.navigationLink")]
        public string CrmdWbsubjectindivid1OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid3@odata.associationLink")]
        public string CrmdWbsubjectindivid3OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid3@odata.navigationLink")]
        public string CrmdWbsubjectindivid3OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm4@odata.associationLink")]
        public string CrmdWbsubjectfirm4OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm4@odata.navigationLink")]
        public string CrmdWbsubjectfirm4OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm5@odata.associationLink")]
        public string CrmdWbsubjectfirm5OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm5@odata.navigationLink")]
        public string CrmdWbsubjectfirm5OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm1@odata.associationLink")]
        public string CrmdWbsubjectfirm1OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm1@odata.navigationLink")]
        public string CrmdWbsubjectfirm1OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm2@odata.associationLink")]
        public string CrmdWbsubjectfirm2OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm2@odata.navigationLink")]
        public string CrmdWbsubjectfirm2OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm3@odata.associationLink")]
        public string CrmdWbsubjectfirm3OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectfirm3@odata.navigationLink")]
        public string CrmdWbsubjectfirm3OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wb1@odata.associationLink")]
        public string CrmdWb1OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb1@odata.navigationLink")]
        public string CrmdWb1OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wb2@odata.associationLink")]
        public string CrmdWb2OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb2@odata.navigationLink")]
        public string CrmdWb2OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wb4@odata.associationLink")]
        public string CrmdWb4OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb4@odata.navigationLink")]
        public string CrmdWb4OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wb5@odata.associationLink")]
        public string CrmdWb5OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb5@odata.navigationLink")]
        public string CrmdWb5OdataNavigationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid2@odata.associationLink")]
        public string CrmdWbsubjectindivid2OdataAssociationLink { get; set; }

        [JsonProperty("crmd_wbsubjectindivid2@odata.navigationLink")]
        public string CrmdWbsubjectindivid2OdataNavigationLink { get; set; }

        [JsonProperty("organizationid@odata.associationLink")]
        public string OrganizationidOdataAssociationLink { get; set; }

        [JsonProperty("organizationid@odata.navigationLink")]
        public string OrganizationidOdataNavigationLink { get; set; }

        [JsonProperty("createdby@odata.associationLink")]
        public string CreatedbyOdataAssociationLink { get; set; }

        [JsonProperty("createdby@odata.navigationLink")]
        public string CreatedbyOdataNavigationLink { get; set; }

        [JsonProperty("createdonbehalfby@odata.associationLink")]
        public string CreatedonbehalfbyOdataAssociationLink { get; set; }

        [JsonProperty("createdonbehalfby@odata.navigationLink")]
        public string CreatedonbehalfbyOdataNavigationLink { get; set; }

        [JsonProperty("modifiedby@odata.associationLink")]
        public string ModifiedbyOdataAssociationLink { get; set; }

        [JsonProperty("modifiedby@odata.navigationLink")]
        public string ModifiedbyOdataNavigationLink { get; set; }

        [JsonProperty("modifiedonbehalfby@odata.associationLink")]
        public string ModifiedonbehalfbyOdataAssociationLink { get; set; }

        [JsonProperty("modifiedonbehalfby@odata.navigationLink")]
        public string ModifiedonbehalfbyOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_SyncErrors@odata.associationLink")]
        public string CrmdOwbwebformsSyncErrorsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_SyncErrors@odata.navigationLink")]
        public string CrmdOwbwebformsSyncErrorsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_AsyncOperations@odata.associationLink")]
        public string CrmdOwbwebformsAsyncOperationsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_AsyncOperations@odata.navigationLink")]
        public string CrmdOwbwebformsAsyncOperationsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_MailboxTrackingFolders@odata.associationLink")]
        public string CrmdOwbwebformsMailboxTrackingFoldersOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_MailboxTrackingFolders@odata.navigationLink")]
        public string CrmdOwbwebformsMailboxTrackingFoldersOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_UserEntityInstanceDatas@odata.associationLink")]
        public string CrmdOwbwebformsUserEntityInstanceDatasOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_UserEntityInstanceDatas@odata.navigationLink")]
        public string CrmdOwbwebformsUserEntityInstanceDatasOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_ProcessSession@odata.associationLink")]
        public string CrmdOwbwebformsProcessSessionOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_ProcessSession@odata.navigationLink")]
        public string CrmdOwbwebformsProcessSessionOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_BulkDeleteFailures@odata.associationLink")]
        public string CrmdOwbwebformsBulkDeleteFailuresOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_BulkDeleteFailures@odata.navigationLink")]
        public string CrmdOwbwebformsBulkDeleteFailuresOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_PrincipalObjectAttributeAccesses@odata.associationLink")]
        public string CrmdOwbwebformsPrincipalObjectAttributeAccessesOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_PrincipalObjectAttributeAccesses@odata.navigationLink")]
        public string CrmdOwbwebformsPrincipalObjectAttributeAccessesOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owb_contactor_webform@odata.associationLink")]
        public string CrmdOwbContactorWebformOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owb_contactor_webform@odata.navigationLink")]
        public string CrmdOwbContactorWebformOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owb_firm_webform@odata.associationLink")]
        public string CrmdOwbFirmWebformOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owb_firm_webform@odata.navigationLink")]
        public string CrmdOwbFirmWebformOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owb_formdates_webform@odata.associationLink")]
        public string CrmdOwbFormdatesWebformOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owb_formdates_webform@odata.navigationLink")]
        public string CrmdOwbFormdatesWebformOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owb_individual_webform@odata.associationLink")]
        public string CrmdOwbIndividualWebformOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owb_individual_webform@odata.navigationLink")]
        public string CrmdOwbIndividualWebformOdataNavigationLink { get; set; }
    }

    public class MicrosoftDynamicsCRMDeleteMultiple
    {
        public string title { get; set; }
        public string target { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("@odata.id")]
        public string OdataId { get; set; }

        [JsonProperty("@odata.etag")]
        public string OdataEtag { get; set; }

        [JsonProperty("@odata.editLink")]
        public string OdataEditLink { get; set; }

        [JsonProperty("crmd_didindivhaverelationentity4_miscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDidindivhaverelationentity4MiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_didindivhaverelationentity4_miscond { get; set; }

        [JsonProperty("versionnumber@OData.Community.Display.V1.FormattedValue")]
        public string VersionnumberODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("versionnumber@odata.type")]
        public string VersionnumberOdataType { get; set; }
        public int versionnumber { get; set; }

        [JsonProperty("crmd_externalrole4consultant_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole4consultantE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole4consultant_e5 { get; set; }

        [JsonProperty("crmd_externalrole4consultant_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole4consultantE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole4consultant_e4 { get; set; }

        [JsonProperty("crmd_externalrole5contactor_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole5contactorE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole5contactor_e2 { get; set; }

        [JsonProperty("crmd_externalrole4consultant_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole4consultantE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole4consultant_e3 { get; set; }

        [JsonProperty("crmd_externalrole4consultant_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole4consultantE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole4consultant_e2 { get; set; }

        [JsonProperty("crmd_externalrole1analyst_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole1analystE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole1analyst_e3 { get; set; }

        [JsonProperty("crmd_internalrole7inhousecounsel_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole7inhousecounselE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole7inhousecounsel_e5 { get; set; }

        [JsonProperty("crmd_internalrole7inhousecounsel_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole7inhousecounselE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole7inhousecounsel_e4 { get; set; }

        [JsonProperty("crmd_internalrole7inhousecounsel_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole7inhousecounselE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole7inhousecounsel_e3 { get; set; }

        [JsonProperty("_modifiedby_value@OData.Community.Display.V1.FormattedValue")]
        public string ModifiedbyValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_modifiedby_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string ModifiedbyValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_modifiedby_value@odata.type")]
        public string ModifiedbyValueOdataType { get; set; }
        public string _modifiedby_value { get; set; }

        [JsonProperty("crmd_externalrole1analyst@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole1analystODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole1analyst { get; set; }

        [JsonProperty("crmd_internalrole5chiefcomplianceoff_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole5chiefcomplianceoffE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole5chiefcomplianceoff_e2 { get; set; }

        [JsonProperty("crmd_internalrole5chiefcomplianceoff_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole5chiefcomplianceoffE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole5chiefcomplianceoff_e3 { get; set; }

        [JsonProperty("crmd_internalrole5chiefcomplianceoff_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole5chiefcomplianceoffE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole5chiefcomplianceoff_e4 { get; set; }

        [JsonProperty("crmd_internalrole5chiefcomplianceoff_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole5chiefcomplianceoffE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole5chiefcomplianceoff_e5 { get; set; }

        [JsonProperty("createdon@OData.Community.Display.V1.FormattedValue")]
        public string CreatedonODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("createdon@odata.type")]
        public string CreatedonOdataType { get; set; }
        public DateTime createdon { get; set; }

        [JsonProperty("crmd_externalrole3legalcounsel_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole3legalcounselE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole3legalcounsel_e5 { get; set; }

        [JsonProperty("crmd_externalrole3legalcounsel_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole3legalcounselE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole3legalcounsel_e4 { get; set; }

        [JsonProperty("_owningbusinessunit_value@OData.Community.Display.V1.FormattedValue")]
        public string OwningbusinessunitValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_owningbusinessunit_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string OwningbusinessunitValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_owningbusinessunit_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string OwningbusinessunitValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_owningbusinessunit_value@odata.type")]
        public string OwningbusinessunitValueOdataType { get; set; }
        public string _owningbusinessunit_value { get; set; }

        [JsonProperty("_owninguser_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string OwninguserValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_owninguser_value@odata.type")]
        public string OwninguserValueOdataType { get; set; }
        public string _owninguser_value { get; set; }

        [JsonProperty("crmd_externalrole5contactor@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole5contactorODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole5contactor { get; set; }
        public string crmd_name { get; set; }

        [JsonProperty("crmd_internalrole3officer_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole3officerE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole3officer_e4 { get; set; }

        [JsonProperty("_createdby_value@OData.Community.Display.V1.FormattedValue")]
        public string CreatedbyValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_createdby_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CreatedbyValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_createdby_value@odata.type")]
        public string CreatedbyValueOdataType { get; set; }
        public string _createdby_value { get; set; }

        [JsonProperty("crmd_externalrole5contactor_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole5contactorE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole5contactor_e4 { get; set; }

        [JsonProperty("_crmd_owb_webform_value@OData.Community.Display.V1.FormattedValue")]
        public string CrmdOwbWebformValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_crmd_owb_webform_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string CrmdOwbWebformValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_crmd_owb_webform_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string CrmdOwbWebformValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_crmd_owb_webform_value@odata.type")]
        public string CrmdOwbWebformValueOdataType { get; set; }
        public string _crmd_owb_webform_value { get; set; }

        [JsonProperty("statecode@OData.Community.Display.V1.FormattedValue")]
        public string StatecodeODataCommunityDisplayV1FormattedValue { get; set; }
        public int statecode { get; set; }

        [JsonProperty("crmd_internalrole6internalauditor_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole6internalauditorE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole6internalauditor_e3 { get; set; }

        [JsonProperty("crmd_internalrole6internalauditor_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole6internalauditorE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole6internalauditor_e2 { get; set; }

        [JsonProperty("crmd_externalrole3legalcounsel@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole3legalcounselODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole3legalcounsel { get; set; }

        [JsonProperty("crmd_didindivhavearelationentity_miscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDidindivhavearelationentityMiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_didindivhavearelationentity_miscond { get; set; }

        [JsonProperty("crmd_internalrole7inhousecounsel@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole7inhousecounselODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole7inhousecounsel { get; set; }

        [JsonProperty("crmd_internalrole2fe@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole2feODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole2fe { get; set; }

        [JsonProperty("crmd_wbagreetooscpolicy@OData.Community.Display.V1.FormattedValue")]
        public string CrmdWbagreetooscpolicyODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_wbagreetooscpolicy { get; set; }

        [JsonProperty("crmd_owbcontactorid@odata.type")]
        public string CrmdOwbcontactoridOdataType { get; set; }
        public string crmd_owbcontactorid { get; set; }

        [JsonProperty("_ownerid_value@OData.Community.Display.V1.FormattedValue")]
        public string OwneridValueODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("_ownerid_value@Microsoft.Dynamics.CRM.associatednavigationproperty")]
        public string OwneridValueMicrosoftDynamicsCRMAssociatednavigationproperty { get; set; }

        [JsonProperty("_ownerid_value@Microsoft.Dynamics.CRM.lookuplogicalname")]
        public string OwneridValueMicrosoftDynamicsCRMLookuplogicalname { get; set; }

        [JsonProperty("_ownerid_value@odata.type")]
        public string OwneridValueOdataType { get; set; }
        public string _ownerid_value { get; set; }

        [JsonProperty("crmd_internalrole5chiefcomplianceofficer@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole5chiefcomplianceofficerODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole5chiefcomplianceofficer { get; set; }

        [JsonProperty("crmd_didindivhaverelationentity5_miscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDidindivhaverelationentity5MiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_didindivhaverelationentity5_miscond { get; set; }

        [JsonProperty("crmd_didindivhaverelationentity2_miscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDidindivhaverelationentity2MiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_didindivhaverelationentity2_miscond { get; set; }

        [JsonProperty("crmd_externalrole3legalcounsel_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole3legalcounselE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole3legalcounsel_e3 { get; set; }

        [JsonProperty("crmd_externalrole3legalcounsel_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole3legalcounselE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole3legalcounsel_e2 { get; set; }

        [JsonProperty("crmd_internalrole1ce_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole1ceE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole1ce_e3 { get; set; }

        [JsonProperty("crmd_internalrole1ce_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole1ceE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole1ce_e2 { get; set; }

        [JsonProperty("crmd_internalrole3officer_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole3officerE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole3officer_e5 { get; set; }

        [JsonProperty("crmd_internalrole1ce_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole1ceE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole1ce_e5 { get; set; }

        [JsonProperty("crmd_internalrole1ce_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole1ceE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole1ce_e4 { get; set; }

        [JsonProperty("crmd_externalrole5contactor_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole5contactorE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole5contactor_e5 { get; set; }

        [JsonProperty("crmd_externalrole2extauditor@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole2extauditorODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole2extauditor { get; set; }

        [JsonProperty("crmd_externalrole5contactor_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole5contactorE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole5contactor_e3 { get; set; }

        [JsonProperty("crmd_internalrole3officer_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole3officerE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole3officer_e3 { get; set; }

        [JsonProperty("crmd_internalrole3officer_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole3officerE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole3officer_e2 { get; set; }

        [JsonProperty("crmd_internalrole2fe_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole2feE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole2fe_e5 { get; set; }

        [JsonProperty("crmd_internalrole2fe_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole2feE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole2fe_e4 { get; set; }

        [JsonProperty("crmd_internalrole2fe_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole2feE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole2fe_e3 { get; set; }

        [JsonProperty("crmd_internalrole1ce@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole1ceODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole1ce { get; set; }

        [JsonProperty("crmd_internalrole6internalauditor_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole6internalauditorE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole6internalauditor_e5 { get; set; }

        [JsonProperty("crmd_internalrole6internalauditor_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole6internalauditorE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole6internalauditor_e4 { get; set; }

        [JsonProperty("crmd_externalrole2extauditor_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole2extauditorE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole2extauditor_e5 { get; set; }

        [JsonProperty("crmd_externalrole2extauditor_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole2extauditorE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole2extauditor_e4 { get; set; }

        [JsonProperty("crmd_externalrole2extauditor_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole2extauditorE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole2extauditor_e3 { get; set; }

        [JsonProperty("crmd_externalrole2extauditor_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole2extauditorE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole2extauditor_e2 { get; set; }

        [JsonProperty("crmd_internalrole2fe_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole2feE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole2fe_e2 { get; set; }

        [JsonProperty("crmd_internalrole3officer@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole3officerODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole3officer { get; set; }

        [JsonProperty("crmd_externalrole1analyst_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole1analystE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole1analyst_e2 { get; set; }

        [JsonProperty("crmd_externalrole1analyst_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole1analystE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole1analyst_e5 { get; set; }

        [JsonProperty("crmd_externalrole1analyst_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole1analystE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole1analyst_e4 { get; set; }

        [JsonProperty("crmd_externalrole6other@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole6otherODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole6other { get; set; }

        [JsonProperty("crmd_externalrole4consultant@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole4consultantODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole4consultant { get; set; }

        [JsonProperty("statuscode@OData.Community.Display.V1.FormattedValue")]
        public string StatuscodeODataCommunityDisplayV1FormattedValue { get; set; }
        public int statuscode { get; set; }

        [JsonProperty("crmd_internalrole8other_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole8otherE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole8other_e2 { get; set; }

        [JsonProperty("crmd_internalrole8other_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole8otherE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole8other_e3 { get; set; }

        [JsonProperty("crmd_internalrole8other_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole8otherE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole8other_e4 { get; set; }

        [JsonProperty("crmd_internalrole8other_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole8otherE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole8other_e5 { get; set; }

        [JsonProperty("crmd_internalrole4director@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole4directorODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole4director { get; set; }

        [JsonProperty("crmd_internalrole6internalauditor@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole6internalauditorODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole6internalauditor { get; set; }

        [JsonProperty("crmd_internalrole8other@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole8otherODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole8other { get; set; }

        [JsonProperty("crmd_internalrole7inhousecounsel_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole7inhousecounselE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole7inhousecounsel_e2 { get; set; }

        [JsonProperty("crmd_didindivhaverelationentity3_miscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdDidindivhaverelationentity3MiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_didindivhaverelationentity3_miscond { get; set; }

        [JsonProperty("modifiedon@OData.Community.Display.V1.FormattedValue")]
        public string ModifiedonODataCommunityDisplayV1FormattedValue { get; set; }

        [JsonProperty("modifiedon@odata.type")]
        public string ModifiedonOdataType { get; set; }
        public DateTime modifiedon { get; set; }

        [JsonProperty("crmd_internalrole4director_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole4directorE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole4director_e2 { get; set; }

        [JsonProperty("crmd_internalrole4director_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole4directorE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole4director_e3 { get; set; }

        [JsonProperty("crmd_internalrole4director_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole4directorE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole4director_e4 { get; set; }

        [JsonProperty("crmd_internalrole4director_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdInternalrole4directorE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_internalrole4director_e5 { get; set; }

        [JsonProperty("crmd_externalrole6other_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole6otherE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole6other_e4 { get; set; }

        [JsonProperty("crmd_externalrole6other_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole6otherE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole6other_e5 { get; set; }

        [JsonProperty("crmd_externalrole6other_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole6otherE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole6other_e2 { get; set; }

        [JsonProperty("crmd_externalrole6other_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdExternalrole6otherE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_externalrole6other_e3 { get; set; }

        [JsonProperty("owningbusinessunit@odata.associationLink")]
        public string OwningbusinessunitOdataAssociationLink { get; set; }

        [JsonProperty("owningbusinessunit@odata.navigationLink")]
        public string OwningbusinessunitOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owb_webform@odata.associationLink")]
        public string CrmdOwbWebformOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owb_webform@odata.navigationLink")]
        public string CrmdOwbWebformOdataNavigationLink { get; set; }

        [JsonProperty("ownerid@odata.associationLink")]
        public string OwneridOdataAssociationLink { get; set; }

        [JsonProperty("ownerid@odata.navigationLink")]
        public string OwneridOdataNavigationLink { get; set; }

        [JsonProperty("createdby@odata.associationLink")]
        public string CreatedbyOdataAssociationLink { get; set; }

        [JsonProperty("createdby@odata.navigationLink")]
        public string CreatedbyOdataNavigationLink { get; set; }

        [JsonProperty("createdonbehalfby@odata.associationLink")]
        public string CreatedonbehalfbyOdataAssociationLink { get; set; }

        [JsonProperty("createdonbehalfby@odata.navigationLink")]
        public string CreatedonbehalfbyOdataNavigationLink { get; set; }

        [JsonProperty("modifiedby@odata.associationLink")]
        public string ModifiedbyOdataAssociationLink { get; set; }

        [JsonProperty("modifiedby@odata.navigationLink")]
        public string ModifiedbyOdataNavigationLink { get; set; }

        [JsonProperty("modifiedonbehalfby@odata.associationLink")]
        public string ModifiedonbehalfbyOdataAssociationLink { get; set; }

        [JsonProperty("modifiedonbehalfby@odata.navigationLink")]
        public string ModifiedonbehalfbyOdataNavigationLink { get; set; }

        [JsonProperty("owninguser@odata.associationLink")]
        public string OwninguserOdataAssociationLink { get; set; }

        [JsonProperty("owninguser@odata.navigationLink")]
        public string OwninguserOdataNavigationLink { get; set; }

        [JsonProperty("owningteam@odata.associationLink")]
        public string OwningteamOdataAssociationLink { get; set; }

        [JsonProperty("owningteam@odata.navigationLink")]
        public string OwningteamOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_SyncErrors@odata.associationLink")]
        public string CrmdOwbcontactorSyncErrorsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_SyncErrors@odata.navigationLink")]
        public string CrmdOwbcontactorSyncErrorsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_AsyncOperations@odata.associationLink")]
        public string CrmdOwbcontactorAsyncOperationsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_AsyncOperations@odata.navigationLink")]
        public string CrmdOwbcontactorAsyncOperationsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_MailboxTrackingFolders@odata.associationLink")]
        public string CrmdOwbcontactorMailboxTrackingFoldersOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_MailboxTrackingFolders@odata.navigationLink")]
        public string CrmdOwbcontactorMailboxTrackingFoldersOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_UserEntityInstanceDatas@odata.associationLink")]
        public string CrmdOwbcontactorUserEntityInstanceDatasOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_UserEntityInstanceDatas@odata.navigationLink")]
        public string CrmdOwbcontactorUserEntityInstanceDatasOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_ProcessSession@odata.associationLink")]
        public string CrmdOwbcontactorProcessSessionOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_ProcessSession@odata.navigationLink")]
        public string CrmdOwbcontactorProcessSessionOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_BulkDeleteFailures@odata.associationLink")]
        public string CrmdOwbcontactorBulkDeleteFailuresOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_BulkDeleteFailures@odata.navigationLink")]
        public string CrmdOwbcontactorBulkDeleteFailuresOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_PrincipalObjectAttributeAccesses@odata.associationLink")]
        public string CrmdOwbcontactorPrincipalObjectAttributeAccessesOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbcontactor_PrincipalObjectAttributeAccesses@odata.navigationLink")]
        public string CrmdOwbcontactorPrincipalObjectAttributeAccessesOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_owbcontactor@odata.associationLink")]
        public string CrmdOwbformdatesOwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_owbcontactor@odata.navigationLink")]
        public string CrmdOwbformdatesOwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb1_owbcontactor@odata.associationLink")]
        public string CrmdOwbwebformsWb1OwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb1_owbcontactor@odata.navigationLink")]
        public string CrmdOwbwebformsWb1OwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb2_owbcontactor@odata.associationLink")]
        public string CrmdOwbwebformsWb2OwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb2_owbcontactor@odata.navigationLink")]
        public string CrmdOwbwebformsWb2OwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb3_owbcontactor@odata.associationLink")]
        public string CrmdOwbwebformsWb3OwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb3_owbcontactor@odata.navigationLink")]
        public string CrmdOwbwebformsWb3OwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb4_owbcontactor@odata.associationLink")]
        public string CrmdOwbwebformsWb4OwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb4_owbcontactor@odata.navigationLink")]
        public string CrmdOwbwebformsWb4OwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb5_owbcontactor@odata.associationLink")]
        public string CrmdOwbwebformsWb5OwbcontactorOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_wb5_owbcontactor@odata.navigationLink")]
        public string CrmdOwbwebformsWb5OwbcontactorOdataNavigationLink { get; set; }

        [JsonProperty("crmd_contactornumber@OData.Community.Display.V1.FormattedValue")]
        public string CrmdContactornumberODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_contactornumber { get; set; }

        [JsonProperty("crmd_anystepstakenppldeptreportmiscon_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnystepstakenppldeptreportmisconE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anystepstakenppldeptreportmiscon_e5 { get; set; }

        [JsonProperty("crmd_anysteptakentoescalteconcernsint_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnysteptakentoescalteconcernsintE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anysteptakentoescalteconcernsint_e3 { get; set; }
        public string crmd_infopermittedunderprofessconduct_e2 { get; set; }
        public string crmd_describeotherexternalrole { get; set; }
        public string crmd_internalrole8othertext_e5 { get; set; }
        public string crmd_wb_firstname { get; set; }

        [JsonProperty("crmd_anystepstakenppldeptreportmiscon_e3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnystepstakenppldeptreportmisconE3ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anystepstakenppldeptreportmiscon_e3 { get; set; }

        [JsonProperty("crmd_anystepstakenppldeptreportmiscond@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnystepstakenppldeptreportmiscondODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anystepstakenppldeptreportmiscond { get; set; }
        public string crmd_wbdaytimephone { get; set; }
        public string crmd_infopermlawyequalrulesotherjuris_e3 { get; set; }
        public string crmd_wbcity { get; set; }
        public string crmd_internalrole8othertext_e4 { get; set; }
        public string crmd_wbemail { get; set; }
        public string crmd_describeotherexternalrole_e4 { get; set; }

        [JsonProperty("crmd_anysteptakentoescalteconcernsint_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnysteptakentoescalteconcernsintE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anysteptakentoescalteconcernsint_e4 { get; set; }
        public string crmd_infopermlawyequalrulesotherjuris_e2 { get; set; }
        public string crmd_descriptionofstepstaken { get; set; }
        public string crmd_infopermlawyequalrulesotherjurisdtn { get; set; }
        public string crmd_wb_middlename { get; set; }
        public string crmd_describeotherexternalrole_e5 { get; set; }
        public string crmd_descriptionofstepstaken_e3 { get; set; }
        public string crmd_describeotherexternalrole_e3 { get; set; }

        [JsonProperty("crmd_anystepstakenppldeptreportmiscon_e4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnystepstakenppldeptreportmisconE4ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anystepstakenppldeptreportmiscon_e4 { get; set; }
        public string crmd_infopermittedunderprofessconduct_e4 { get; set; }
        public string crmd_descriptionofstepstaken_e4 { get; set; }
        public string crmd_descriptionofstepstaken_e2 { get; set; }
        public string crmd_internalrole8othertext_e3 { get; set; }
        public string crmd_infopermittedunderprofessconduct_e3 { get; set; }
        public string crmd_wboccupation { get; set; }
        public string crmd_infopermlawyequalrulesotherjuris_e4 { get; set; }
        public string crmd_infopermlawyequalrulesotherjuris_e5 { get; set; }
        public string crmd_infopermittedunderprofessconduct_e5 { get; set; }
        public string crmd_internalrole8othertext_e2 { get; set; }

        [JsonProperty("crmd_anysteptakentoescalteconcernsint_e5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnysteptakentoescalteconcernsintE5ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anysteptakentoescalteconcernsint_e5 { get; set; }

        [JsonProperty("crmd_anysteptakentoescalteconcernsintern@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnysteptakentoescalteconcernsinternODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anysteptakentoescalteconcernsintern { get; set; }
        public string crmd_descriptionofstepstaken_e5 { get; set; }
        public string crmd_describeotherexternalrole_e2 { get; set; }

        [JsonProperty("crmd_anystepstakenppldeptreportmiscon_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnystepstakenppldeptreportmisconE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anystepstakenppldeptreportmiscon_e2 { get; set; }
        public string crmd_wbstreetaddress { get; set; }
        public string crmd_internalrole8othertext { get; set; }
        public string crmd_wb_lastname { get; set; }

        [JsonProperty("crmd_anysteptakentoescalteconcernsint_e2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdAnysteptakentoescalteconcernsintE2ODataCommunityDisplayV1FormattedValue { get; set; }
        public int? crmd_anysteptakentoescalteconcernsint_e2 { get; set; }
        public string crmd_infopermittedunderprofessconduct { get; set; }

        [JsonProperty("crmd_individualnumber@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualnumberODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_individualnumber { get; set; }

        [JsonProperty("crmd_owbindividualid@odata.type")]
        public string CrmdOwbindividualidOdataType { get; set; }
        public string crmd_owbindividualid { get; set; }
        public string crmd_indiv_employed_at_time_miscond_text { get; set; }
        public string crmd_city_individual { get; set; }
        public string crmd_email_individual { get; set; }

        [JsonProperty("crmd_individual_employing_entity5@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualEmployingEntity5ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_individual_employing_entity5 { get; set; }
        public string crmd_lastname_individual { get; set; }

        [JsonProperty("crmd_individual_employing_entity1@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualEmployingEntity1ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_individual_employing_entity1 { get; set; }

        [JsonProperty("crmd_individual_employing_entity3@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualEmployingEntity3ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_individual_employing_entity3 { get; set; }

        [JsonProperty("crmd_individual_employing_entity2@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualEmployingEntity2ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_individual_employing_entity2 { get; set; }
        public string crmd_phonenumber_individual { get; set; }
        public string crmd_firstname_individual { get; set; }

        [JsonProperty("crmd_individual_employing_entity4@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndividualEmployingEntity4ODataCommunityDisplayV1FormattedValue { get; set; }
        public bool crmd_individual_employing_entity4 { get; set; }

        [JsonProperty("crmd_indiv_employee_officer_director@OData.Community.Display.V1.FormattedValue")]
        public string CrmdIndivEmployeeOfficerDirectorODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_indiv_employee_officer_director { get; set; }
        public string crmd_jobposition_individual { get; set; }
        public string crmd_streetaddress_individual { get; set; }

        [JsonProperty("crmd_owbindividual_SyncErrors@odata.associationLink")]
        public string CrmdOwbindividualSyncErrorsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_SyncErrors@odata.navigationLink")]
        public string CrmdOwbindividualSyncErrorsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_AsyncOperations@odata.associationLink")]
        public string CrmdOwbindividualAsyncOperationsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_AsyncOperations@odata.navigationLink")]
        public string CrmdOwbindividualAsyncOperationsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_MailboxTrackingFolders@odata.associationLink")]
        public string CrmdOwbindividualMailboxTrackingFoldersOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_MailboxTrackingFolders@odata.navigationLink")]
        public string CrmdOwbindividualMailboxTrackingFoldersOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_UserEntityInstanceDatas@odata.associationLink")]
        public string CrmdOwbindividualUserEntityInstanceDatasOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_UserEntityInstanceDatas@odata.navigationLink")]
        public string CrmdOwbindividualUserEntityInstanceDatasOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_ProcessSession@odata.associationLink")]
        public string CrmdOwbindividualProcessSessionOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_ProcessSession@odata.navigationLink")]
        public string CrmdOwbindividualProcessSessionOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_BulkDeleteFailures@odata.associationLink")]
        public string CrmdOwbindividualBulkDeleteFailuresOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_BulkDeleteFailures@odata.navigationLink")]
        public string CrmdOwbindividualBulkDeleteFailuresOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbindividual_PrincipalObjectAttributeAccesses@odata.associationLink")]
        public string CrmdOwbindividualPrincipalObjectAttributeAccessesOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbindividual_PrincipalObjectAttributeAccesses@odata.navigationLink")]
        public string CrmdOwbindividualPrincipalObjectAttributeAccessesOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid1@odata.associationLink")]
        public string CrmdOwbwebformsSubjectindivid1OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid1@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectindivid1OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid2@odata.associationLink")]
        public string CrmdOwbwebformsSubjectindivid2OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid2@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectindivid2OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid3@odata.associationLink")]
        public string CrmdOwbwebformsSubjectindivid3OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid3@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectindivid3OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid4@odata.associationLink")]
        public string CrmdOwbwebformsSubjectindivid4OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid4@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectindivid4OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid5@odata.associationLink")]
        public string CrmdOwbwebformsSubjectindivid5OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectindivid5@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectindivid5OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdatesid@odata.type")]
        public string CrmdOwbformdatesidOdataType { get; set; }
        public string crmd_owbformdatesid { get; set; }

        [JsonProperty("crmd_owbformdates_SyncErrors@odata.associationLink")]
        public string CrmdOwbformdatesSyncErrorsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_SyncErrors@odata.navigationLink")]
        public string CrmdOwbformdatesSyncErrorsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_AsyncOperations@odata.associationLink")]
        public string CrmdOwbformdatesAsyncOperationsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_AsyncOperations@odata.navigationLink")]
        public string CrmdOwbformdatesAsyncOperationsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_MailboxTrackingFolders@odata.associationLink")]
        public string CrmdOwbformdatesMailboxTrackingFoldersOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_MailboxTrackingFolders@odata.navigationLink")]
        public string CrmdOwbformdatesMailboxTrackingFoldersOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_UserEntityInstanceDatas@odata.associationLink")]
        public string CrmdOwbformdatesUserEntityInstanceDatasOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_UserEntityInstanceDatas@odata.navigationLink")]
        public string CrmdOwbformdatesUserEntityInstanceDatasOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_ProcessSession@odata.associationLink")]
        public string CrmdOwbformdatesProcessSessionOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_ProcessSession@odata.navigationLink")]
        public string CrmdOwbformdatesProcessSessionOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_BulkDeleteFailures@odata.associationLink")]
        public string CrmdOwbformdatesBulkDeleteFailuresOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_BulkDeleteFailures@odata.navigationLink")]
        public string CrmdOwbformdatesBulkDeleteFailuresOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbformdates_PrincipalObjectAttributeAccesses@odata.associationLink")]
        public string CrmdOwbformdatesPrincipalObjectAttributeAccessesOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbformdates_PrincipalObjectAttributeAccesses@odata.navigationLink")]
        public string CrmdOwbformdatesPrincipalObjectAttributeAccessesOdataNavigationLink { get; set; }

        [JsonProperty("crmd_wb@odata.associationLink")]
        public string CrmdWbOdataAssociationLink { get; set; }

        [JsonProperty("crmd_wb@odata.navigationLink")]
        public string CrmdWbOdataNavigationLink { get; set; }
        public string crmd_city_entities { get; set; }
        public string crmd_street_entitiies { get; set; }

        [JsonProperty("crmd_firmnumber@OData.Community.Display.V1.FormattedValue")]
        public string CrmdFirmnumberODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_firmnumber { get; set; }
        public string crmd_actiontaken { get; set; }

        [JsonProperty("crmd_owbfirmtype@OData.Community.Display.V1.FormattedValue")]
        public string CrmdOwbfirmtypeODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_owbfirmtype { get; set; }
        public string crmd_phonenumber_entities { get; set; }
        public string crmd_jobposition { get; set; }

        [JsonProperty("crmd_commyearcontacted@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCommyearcontactedODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_commyearcontacted { get; set; }

        [JsonProperty("crmd_commdaycontacted@OData.Community.Display.V1.FormattedValue")]
        public string CrmdCommdaycontactedODataCommunityDisplayV1FormattedValue { get; set; }
        public int crmd_commdaycontacted { get; set; }
        public string crmd_website_entities { get; set; }
        public string crmd_contactedpersonatorganization { get; set; }

        [JsonProperty("crmd_owbfirmid@odata.type")]
        public string CrmdOwbfirmidOdataType { get; set; }
        public string crmd_owbfirmid { get; set; }
        public string crmd_commmonthcontacted { get; set; }

        [JsonProperty("crmd_owbfirm_SyncErrors@odata.associationLink")]
        public string CrmdOwbfirmSyncErrorsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_SyncErrors@odata.navigationLink")]
        public string CrmdOwbfirmSyncErrorsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_AsyncOperations@odata.associationLink")]
        public string CrmdOwbfirmAsyncOperationsOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_AsyncOperations@odata.navigationLink")]
        public string CrmdOwbfirmAsyncOperationsOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_MailboxTrackingFolders@odata.associationLink")]
        public string CrmdOwbfirmMailboxTrackingFoldersOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_MailboxTrackingFolders@odata.navigationLink")]
        public string CrmdOwbfirmMailboxTrackingFoldersOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_UserEntityInstanceDatas@odata.associationLink")]
        public string CrmdOwbfirmUserEntityInstanceDatasOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_UserEntityInstanceDatas@odata.navigationLink")]
        public string CrmdOwbfirmUserEntityInstanceDatasOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_ProcessSession@odata.associationLink")]
        public string CrmdOwbfirmProcessSessionOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_ProcessSession@odata.navigationLink")]
        public string CrmdOwbfirmProcessSessionOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_BulkDeleteFailures@odata.associationLink")]
        public string CrmdOwbfirmBulkDeleteFailuresOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_BulkDeleteFailures@odata.navigationLink")]
        public string CrmdOwbfirmBulkDeleteFailuresOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbfirm_PrincipalObjectAttributeAccesses@odata.associationLink")]
        public string CrmdOwbfirmPrincipalObjectAttributeAccessesOdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbfirm_PrincipalObjectAttributeAccesses@odata.navigationLink")]
        public string CrmdOwbfirmPrincipalObjectAttributeAccessesOdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm1@odata.associationLink")]
        public string CrmdOwbwebformsSubjectfirm1OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm1@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectfirm1OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm2@odata.associationLink")]
        public string CrmdOwbwebformsSubjectfirm2OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm2@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectfirm2OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm3@odata.associationLink")]
        public string CrmdOwbwebformsSubjectfirm3OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm3@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectfirm3OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm4@odata.associationLink")]
        public string CrmdOwbwebformsSubjectfirm4OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm4@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectfirm4OdataNavigationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm5@odata.associationLink")]
        public string CrmdOwbwebformsSubjectfirm5OdataAssociationLink { get; set; }

        [JsonProperty("crmd_owbwebforms_subjectfirm5@odata.navigationLink")]
        public string CrmdOwbwebformsSubjectfirm5OdataNavigationLink { get; set; }
        public string D365Table { get; set; }
        public string eForm { get; set; }
        public string SubmissionID { get; set; }
        public string D365GUID { get; set; }
        public string Date { get; set; }
        public List<CrmdOwbwebform> crmd_owbwebforms { get; set; }
        public List<CrmdOwbcontactor> crmd_owbcontactor { get; set; }
        public List<CrmdOwbindividual> crmd_owbindividual { get; set; }
        public List<CrmdOwbformdate> crmd_owbformdates { get; set; }
        public List<CrmdOwbfirm> crmd_owbfirm { get; set; }
        public List<string> crmd_owbsupportingdocuments { get; set; }
    }

    public class CrmdOwbcontactor
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("#Microsoft.Dynamics.CRM.DeleteMultiple")]
        public MicrosoftDynamicsCRMDeleteMultiple MicrosoftDynamicsCRMDeleteMultiple { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcount")]
        public int MicrosoftDynamicsCRMTotalrecordcount { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcountlimitexceeded")]
        public bool MicrosoftDynamicsCRMTotalrecordcountlimitexceeded { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.globalmetadataversion")]
        public string MicrosoftDynamicsCRMGlobalmetadataversion { get; set; }
        public List<Value> value { get; set; }
    }

    public class CrmdOwbindividual
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("#Microsoft.Dynamics.CRM.DeleteMultiple")]
        public MicrosoftDynamicsCRMDeleteMultiple MicrosoftDynamicsCRMDeleteMultiple { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcount")]
        public int MicrosoftDynamicsCRMTotalrecordcount { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcountlimitexceeded")]
        public bool MicrosoftDynamicsCRMTotalrecordcountlimitexceeded { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.globalmetadataversion")]
        public string MicrosoftDynamicsCRMGlobalmetadataversion { get; set; }
        public List<Value> value { get; set; }
    }

    public class CrmdOwbformdate
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("#Microsoft.Dynamics.CRM.DeleteMultiple")]
        public MicrosoftDynamicsCRMDeleteMultiple MicrosoftDynamicsCRMDeleteMultiple { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcount")]
        public int MicrosoftDynamicsCRMTotalrecordcount { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcountlimitexceeded")]
        public bool MicrosoftDynamicsCRMTotalrecordcountlimitexceeded { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.globalmetadataversion")]
        public string MicrosoftDynamicsCRMGlobalmetadataversion { get; set; }
        public List<Value> value { get; set; }
    }

    public class CrmdOwbfirm
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }

        [JsonProperty("#Microsoft.Dynamics.CRM.DeleteMultiple")]
        public MicrosoftDynamicsCRMDeleteMultiple MicrosoftDynamicsCRMDeleteMultiple { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcount")]
        public int MicrosoftDynamicsCRMTotalrecordcount { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.totalrecordcountlimitexceeded")]
        public bool MicrosoftDynamicsCRMTotalrecordcountlimitexceeded { get; set; }

        [JsonProperty("@Microsoft.Dynamics.CRM.globalmetadataversion")]
        public string MicrosoftDynamicsCRMGlobalmetadataversion { get; set; }
        public List<Value> value { get; set; }
    }

    public class Body
    {
        public string name { get; set; }
        public Value value { get; set; }
    }

    public class Root
    {
        public Body body { get; set; }
    }
}
