using System.Collections.Generic;
using System.Text;

namespace OSC.AzureFunction.Model
{
    public class WhistleblowerModel
    {
        public WhistleblowerModel()
        {
            showInsiderTradingQuestions = false;
            showFraudQuestions = false;
            showCorpDisclosureQuestions = false;
            showIllegalDistribQuestions = false;
            showOtherQuestions = false;
        }

        // PAGES CONFIGURATION
        public string submissionID { get; set; }
        public string AnonymousFlag { get; set; }

        // MULTIPLE OPTIONS
        private string misconductType { get; set; }
        /// <summary>
        /// What type of securities-related misconduct do you believe has occurred, is presently occurring, or will occur? Check all that apply.
        /// </summary>
        public string MisconductType() { return misconductType; }
        public void MisconductTypeAppend(MisconductTypeEnum type)
        {
            if (string.IsNullOrEmpty(misconductType))
            {
                misconductType = type.ToString();
                switch (type)
                {
                    case MisconductTypeEnum.InsiderTrading:
                        showInsiderTradingQuestions = true;
                        break;
                    case MisconductTypeEnum.Fraud:
                        showFraudQuestions = true;
                        break;
                    case MisconductTypeEnum.CorpDisclosure:
                        showCorpDisclosureQuestions = true;
                        break;
                    case MisconductTypeEnum.IllegalDistrib:
                        showIllegalDistribQuestions = true;
                        break;
                    case MisconductTypeEnum.Other:
                        showOtherQuestions = true;
                        break;
                }
            }
            else
                misconductType = $"{misconductType} {type.ToString()}";
        }
        public string misconductTypeOther { get; set; }

        // MILTIPLE CHILD QUESTIONS
        private Dictionary<MisconductTypeEnum, string> whenOccurred = new Dictionary<MisconductTypeEnum, string>();

        public string WhenOccurred(MisconductTypeEnum type)
        {
            if (whenOccurred.ContainsKey(type))
                return whenOccurred[type];
            else
                return string.Empty;
        }
        public void WhenOccurredAppend(MisconductTypeEnum type, WhenOccurredEnum whenOccurredEnum)
        {
            if (!whenOccurred.ContainsKey(type))
                whenOccurred.Add(type, whenOccurredEnum.ToString());
            else
                whenOccurred[type] = $"{whenOccurred[type]} {whenOccurredEnum.ToString()}";
        }

        public bool showInsiderTradingQuestions { get; set; }
        public bool showFraudQuestions { get; set; }
        public bool showCorpDisclosureQuestions { get; set; }
        public bool showIllegalDistribQuestions { get; set; }
        public bool showOtherQuestions { get; set; }
        // END MULTIPLE OPTIONS

        // DATES FIELDS
        public List<Dates> dates = new List<Dates>();

        public List<Whistleblowers> Whistleblowers = new List<Whistleblowers>();
        public List<Individuals> Individuals = new List<Individuals>();
        public List<Entities> Entities = new List<Entities>();
    }

    // WHISTLEBLOWERS
    public class Whistleblowers
    {
        public string Wb_DisplayNM { get; set; }
        public string Wb_FName { get; set; }
        public string Wb_MidName { get; set; }
        public string Wb_LName { get; set; }
        public string wb_EntityRel_rows
        {
            get
            {
                return wb_EntityRel_rows;
            }
            set
            {
                wb_EntityRel_rows = "<Wb_EntityRel_rows><Wb_EntityRel_rowemptyAttr=\"\"rowNum=\"1\"selectedRoleCount=\"0\"><Entity_DisplayNM>ABCCompany</Entity_DisplayNM><EntityRel_HaveRelWith>no</EntityRel_HaveRelWith><!--Spacedelimitedlistofinternalrolesselected--><EntityRel_IntRoles/><EntityRel_IntRoleOther/><!--Spacedelimitedlistofexternalrolesselected--><EntityRel_ExtRoles/><EntityRel_ExtRoleOther/><!--InternalRoles-RelevantDependingonlistinEntityRel_IntRoles.--><EntityRel_Role_rowdesc=\"Currentemployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CurrentEmp\"/><EntityRel_Role_rowdesc=\"Formeremployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"FormerEmp\"/><EntityRel_Role_rowdesc=\"Officer\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Officer\"/><EntityRel_Role_rowdesc=\"Director(boardofdirectors)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Director\"/><EntityRel_Role_rowdesc=\"ChiefComplianceOfficer(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CCO\"/><EntityRel_Role_rowdesc=\"InternalAuditor(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntAuditor\"/><EntityRel_Role_rowdesc=\"In-housecounselattheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntCounsel\"/><EntityRel_Role_rowdesc=\"Other(Internal)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntOther\"/><!--ExternalRoles-RelevantDependingonlistinEntityRel_ExtRoles.--><EntityRel_Role_rowdesc=\"Analyst\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Analyst\"/><EntityRel_Role_rowdesc=\"ExternalAuditor(orfunctionalequivalent)(i.e.providingassuranceservicestotheentity)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtAuditor\"/><EntityRel_Role_rowdesc=\"Externallegalcounseltotheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtCounsel\"/><EntityRel_Role_rowdesc=\"Consultant\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Consultant\"/><EntityRel_Role_rowdesc=\"Contractor\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Contractor\"/><EntityRel_Role_rowdesc=\"Other(External)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtOther\"/><EntityRel_CounselDiscComments/><EntityRel_AuditorDiscComments/><EntityRel_IntReportedFlag/><EntityRel_ReportedTo_row><ReportedTo_Name/><ReportedTo_JobTitle/><ReportedTo_DateYr/><ReportedTo_DateMnth/><ReportedTo_DateDay/></EntityRel_ReportedTo_row><EntityRel_ActionTakenFlag/><EntityRel_ActionTaken_DESC/></Wb_EntityRel_row><Wb_EntityRel_rowemptyAttr=\"\"rowNum=\"2\"selectedRoleCount=\"2\"><Entity_DisplayNM>DEFCompany</Entity_DisplayNM><EntityRel_HaveRelWith>yes</EntityRel_HaveRelWith><!--Spacedelimitedlistofinternalrolesselected--><EntityRel_IntRoles>FormerEmp</EntityRel_IntRoles><EntityRel_IntRoleOther/><!--Spacedelimitedlistofexternalrolesselected--><EntityRel_ExtRoles>Contractor</EntityRel_ExtRoles><EntityRel_ExtRoleOther/><!--InternalRoles-RelevantDependingonlistinEntityRel_IntRoles.--><EntityRel_Role_rowdesc=\"Currentemployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CurrentEmp\"/><EntityRel_Role_rowdesc=\"Formeremployee\"fromMnth=\"2\"fromYr=\"2007\"intExt=\"int\"selected=\"true\"toMnth=\"8\"toYr=\"2008\"type=\"FormerEmp\"/><EntityRel_Role_rowdesc=\"Officer\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Officer\"/><EntityRel_Role_rowdesc=\"Director(boardofdirectors)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Director\"/><EntityRel_Role_rowdesc=\"ChiefComplianceOfficer(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CCO\"/><EntityRel_Role_rowdesc=\"InternalAuditor(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntAuditor\"/><EntityRel_Role_rowdesc=\"In-housecounselattheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntCounsel\"/><EntityRel_Role_rowdesc=\"Other(Internal)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntOther\"/><!--ExternalRoles-RelevantDependingonlistinEntityRel_ExtRoles.--><EntityRel_Role_rowdesc=\"Analyst\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Analyst\"/><EntityRel_Role_rowdesc=\"ExternalAuditor(orfunctionalequivalent)(i.e.providingassuranceservicestotheentity)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtAuditor\"/><EntityRel_Role_rowdesc=\"Externallegalcounseltotheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtCounsel\"/><EntityRel_Role_rowdesc=\"Consultant\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Consultant\"/><EntityRel_Role_rowdesc=\"Contractor\"fromMnth=\"5\"fromYr=\"2005\"intExt=\"ext\"selected=\"true\"toMnth=\"11\"toYr=\"2007\"type=\"Contractor\"/><EntityRel_Role_rowdesc=\"Other(External)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtOther\"/><EntityRel_CounselDiscComments/><EntityRel_AuditorDiscComments/><EntityRel_IntReportedFlag>yes</EntityRel_IntReportedFlag><EntityRel_ReportedTo_row><ReportedTo_Name>ttesting</ReportedTo_Name><ReportedTo_JobTitle>hgvhhhhhgvh</ReportedTo_JobTitle><ReportedTo_DateYr>2019</ReportedTo_DateYr><ReportedTo_DateMnth>8</ReportedTo_DateMnth><ReportedTo_DateDay>20</ReportedTo_DateDay></EntityRel_ReportedTo_row><EntityRel_ActionTakenFlag>yes</EntityRel_ActionTakenFlag><EntityRel_ActionTaken_DESC>jhfvgkgiygiiihihiuhuihiuhiuhiuhihoiuhoiuhiouhiouhiuhiulhiuhuihuhoiuhiuhoi</EntityRel_ActionTaken_DESC></Wb_EntityRel_row></Wb_EntityRel_rows><Wb_Declaration>yes</Wb_Declaration></WbInfo_row><WbInfo_row><!--Calculated--><Wb_DisplayNM>Daniela2Test1</Wb_DisplayNM><Wb_FName>Daniela2</Wb_FName><Wb_MidName/><Wb_LName>Test1</Wb_LName><Wb_Address>55JohnSt</Wb_Address><Wb_City>Vaugn</Wb_City><Wb_Province>ON</Wb_Province><Wb_Country>Canada</Wb_Country><Wb_Phone>3334445555</Wb_Phone><Wb_Email>dtest2@yahoo.com</Wb_Email><Wb_Occupation/><Wb_EntityRel_rows><Wb_EntityRel_rowemptyAttr=\"\"rowNum=\"3\"selectedRoleCount=\"2\"><Entity_DisplayNM>ABCCompany</Entity_DisplayNM><EntityRel_HaveRelWith>yes</EntityRel_HaveRelWith><!--Spacedelimitedlistofinternalrolesselected--><EntityRel_IntRoles>Officer</EntityRel_IntRoles><EntityRel_IntRoleOther/><!--Spacedelimitedlistofexternalrolesselected--><EntityRel_ExtRoles>Analyst</EntityRel_ExtRoles><EntityRel_ExtRoleOther/><!--InternalRoles-RelevantDependingonlistinEntityRel_IntRoles.--><EntityRel_Role_rowdesc=\"Currentemployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CurrentEmp\"/><EntityRel_Role_rowdesc=\"Formeremployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"FormerEmp\"/><EntityRel_Role_rowdesc=\"Officer\"fromMnth=\"9\"fromYr=\"2008\"intExt=\"int\"selected=\"true\"toMnth=\"9\"toYr=\"2017\"type=\"Officer\"/><EntityRel_Role_rowdesc=\"Director(boardofdirectors)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Director\"/><EntityRel_Role_rowdesc=\"ChiefComplianceOfficer(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CCO\"/><EntityRel_Role_rowdesc=\"InternalAuditor(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntAuditor\"/><EntityRel_Role_rowdesc=\"In-housecounselattheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntCounsel\"/><EntityRel_Role_rowdesc=\"Other(Internal)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntOther\"/><!--ExternalRoles-RelevantDependingonlistinEntityRel_ExtRoles.--><EntityRel_Role_rowdesc=\"Analyst\"fromMnth=\"9\"fromYr=\"2004\"intExt=\"ext\"selected=\"true\"toMnth=\"8\"toYr=\"2009\"type=\"Analyst\"/><EntityRel_Role_rowdesc=\"ExternalAuditor(orfunctionalequivalent)(i.e.providingassuranceservicestotheentity)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtAuditor\"/><EntityRel_Role_rowdesc=\"Externallegalcounseltotheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtCounsel\"/><EntityRel_Role_rowdesc=\"Consultant\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Consultant\"/><EntityRel_Role_rowdesc=\"Contractor\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Contractor\"/><EntityRel_Role_rowdesc=\"Other(External)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtOther\"/><EntityRel_CounselDiscComments/><EntityRel_AuditorDiscComments/><EntityRel_IntReportedFlag>yes</EntityRel_IntReportedFlag><EntityRel_ReportedTo_row><ReportedTo_Name>gvjjkhbhjkggh</ReportedTo_Name><ReportedTo_JobTitle>jhbjbjbjhbjhbjh</ReportedTo_JobTitle><ReportedTo_DateYr>2018</ReportedTo_DateYr><ReportedTo_DateMnth>12</ReportedTo_DateMnth><ReportedTo_DateDay>15</ReportedTo_DateDay></EntityRel_ReportedTo_row><EntityRel_ActionTakenFlag>yes</EntityRel_ActionTakenFlag><EntityRel_ActionTaken_DESC>jgyuuihgihihiuhiuhiuhiouhouhouhouhouhiu</EntityRel_ActionTaken_DESC></Wb_EntityRel_row><Wb_EntityRel_rowemptyAttr=\"\"rowNum=\"4\"selectedRoleCount=\"2\"><Entity_DisplayNM>DEFCompany</Entity_DisplayNM><EntityRel_HaveRelWith>yes</EntityRel_HaveRelWith><!--Spacedelimitedlistofinternalrolesselected--><EntityRel_IntRoles>CCO</EntityRel_IntRoles><EntityRel_IntRoleOther/><!--Spacedelimitedlistofexternalrolesselected--><EntityRel_ExtRoles>Consultant</EntityRel_ExtRoles><EntityRel_ExtRoleOther/><!--InternalRoles-RelevantDependingonlistinEntityRel_IntRoles.--><EntityRel_Role_rowdesc=\"Currentemployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"CurrentEmp\"/><EntityRel_Role_rowdesc=\"Formeremployee\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"FormerEmp\"/><EntityRel_Role_rowdesc=\"Officer\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Officer\"/><EntityRel_Role_rowdesc=\"Director(boardofdirectors)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Director\"/><EntityRel_Role_rowdesc=\"ChiefComplianceOfficer(orfunctionalequivalent)\"fromMnth=\"4\"fromYr=\"2007\"intExt=\"int\"selected=\"true\"toMnth=\"2\"toYr=\"2014\"type=\"CCO\"/><EntityRel_Role_rowdesc=\"InternalAuditor(orfunctionalequivalent)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntAuditor\"/><EntityRel_Role_rowdesc=\"In-housecounselattheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntCounsel\"/><EntityRel_Role_rowdesc=\"Other(Internal)\"fromMnth=\"\"fromYr=\"\"intExt=\"int\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"IntOther\"/><!--ExternalRoles-RelevantDependingonlistinEntityRel_ExtRoles.--><EntityRel_Role_rowdesc=\"Analyst\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Analyst\"/><EntityRel_Role_rowdesc=\"ExternalAuditor(orfunctionalequivalent)(i.e.providingassuranceservicestotheentity)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtAuditor\"/><EntityRel_Role_rowdesc=\"Externallegalcounseltotheentity\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtCounsel\"/><EntityRel_Role_rowdesc=\"Consultant\"fromMnth=\"10\"fromYr=\"2010\"intExt=\"ext\"selected=\"true\"toMnth=\"11\"toYr=\"2016\"type=\"Consultant\"/><EntityRel_Role_rowdesc=\"Contractor\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"Contractor\"/><EntityRel_Role_rowdesc=\"Other(External)\"fromMnth=\"\"fromYr=\"\"intExt=\"ext\"selected=\"false\"toMnth=\"\"toYr=\"\"type=\"ExtOther\"/><EntityRel_CounselDiscComments/><EntityRel_AuditorDiscComments/><EntityRel_IntReportedFlag>no</EntityRel_IntReportedFlag><EntityRel_ReportedTo_row><ReportedTo_Name/><ReportedTo_JobTitle/><ReportedTo_DateYr/><ReportedTo_DateMnth/><ReportedTo_DateDay/></EntityRel_ReportedTo_row><EntityRel_ActionTakenFlag/><EntityRel_ActionTaken_DESC/></Wb_EntityRel_row></Wb_EntityRel_rows><Wb_Declaration>yes</Wb_Declaration>";
            }
        }

        // HOW DO WE POPULATE THOSE FIELDS FROM OLD FORM
        public string Wb_Address { get; set; }
        public string Wb_City { get; set; }
        public string Wb_Province { get; set; }
        public string Wb_Country { get; set; }
        public string Wb_Phone { get; set; }
        public string Wb_Email { get; set; }
    }
    // INDIVIDUALS
    public class Individuals
    {
        public string Individual_DisplayNM { get; set; }
        public string Individual_FName { get; set; }
        public string Individual_LName { get; set; }
        public string Individual_JobTitle { get; set; }

        // HOW DO WE POPULATE THOSE FIELDS FROM OLD FORM
        public string Individual_Address { get; set; }
        public string Individual_City { get; set; }
        public string Individual_Province { get; set; }
        public string Individual_Country { get; set; }
        public string Individual_Phone { get; set; }
        public string Individual_Email { get; set; }

        /// <summary>
        /// Was or is "INDIVIDUAL" an employee, officer or director (a member of the board of directors) at the entity "Entity #1" at the time of the misconduct?
        /// YOU MUST FILL IT WITH "yes", "no" or "unknown"
        /// </summary>
        public string Individual_EmpOfEntityFlag { get; set; }
        /// <summary>
        /// If you know, please indicate where "teste teste" was employed at the time of the misconduct (max. 75 characters):
        /// </summary>
        public string Individual_OtherEmplyrName { get; set; }

        public string Individual_EmpOfEntityList { get; set; }
    }
    // ENTITIES
    public class Entities
    {
        public string Entity_DisplayNM { get; set; }
        public string Entity_NM { get; set; }
        public string Entity_Address { get; set; }
        public string Entity_City { get; set; }
        public string Entity_Province { get; set; }
        public string Entity_Country { get; set; }
        public string Entity_Phone { get; set; }
        public string Entity_Website { get; set; }
    }

    public class Dates
    {
        public MisconductTypeEnum relatedTo { get; set; }
        public DatesEnum whenDate { get; set; }
        public Month fromMnth { get; set; }
        public string fromYr { get; set; }
        public Month? toMnth { get; set; }
        public string toYr { get; set; }

        public Dates(MisconductTypeEnum relatedTo, DatesEnum whenDate, Month fromMnth, string fromYr, Month? toMnth = null, string toYr = null)
        {
            this.relatedTo = relatedTo;
            this.whenDate = whenDate;
            this.fromMnth = fromMnth;
            this.fromYr = fromYr;
            if (toMnth != null)
                this.toMnth = toMnth.Value;
            else
                this.toMnth = null;
            if (!string.IsNullOrEmpty(toYr))
                this.toYr = toYr;
            else
                this.toYr = null;
        }
    }

    // CONFIGURATION
    public enum MisconductTypeEnum
    {
        InsiderTrading,
        Fraud,
        CorpDisclosure,
        IllegalDistrib,
        Other,
        Unknown,
    }

    public enum WhenOccurredEnum
    {
        past,
        ongoing,
        future,
        unknown,
    }

    public enum Month
    {
        Jan = 1,
        Fev = 2,
        Mar = 3,
        Apr = 4,
        May = 5,
        Jun = 6,
        Jul = 7,
        Aug = 8,
        Sep = 9,
        Oct = 10,
        Nov = 11,
        Dec = 12,
    }
    public enum DatesEnum
    {
        Past,
        Ongoing
    }
    public enum DateType
    {
        fromMnth,
        fromYr,
        toMnth,
        toYr
    }

    public enum crmd_tell_us_about_yourself
    {
        no = 100000000,
        yes = 100000001
    }

    public enum crmd_indiv_employee_officer_director
    {
        yes = 100000000,
        no = 100000001,
        I_don_t_know = 100000002
    }
}