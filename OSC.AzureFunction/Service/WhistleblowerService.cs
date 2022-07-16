using OSC.AzureFunction.JsonModel;
using OSC.AzureFunction.Model;
using System.Collections.Generic;
using System.Xml;

namespace OSC.AzureFunction.Service
{
    public class WhistleblowerService
    {
        public static XmlDocument Whistleblower(Root jsonObject)
        {
            WhistleblowerModel model = FillRecord(jsonObject);
            XmlDocument document = XFDLService.GetTemplate("WBTemplate");

            // MAIN FIELDS
            document = XFDLService.UpdateXFDLTemplate(document, 0, "submissionID", model.submissionID);
            document = XFDLService.UpdateXFDLTemplate(document, 0, "AnonymousFlag", model.AnonymousFlag);
            document = XFDLService.UpdateXFDLTemplate(document, 0, "WbNo_CNT", model.Whistleblowers.Count.ToString());
            document = XFDLService.UpdateXFDLTemplate(document, 0, "IndividualNo_CNT", model.Individuals.Count.ToString());
            document = XFDLService.UpdateXFDLTemplate(document, 0, "EntityNo_CNT", model.Entities.Count.ToString());

            // CLEANING THE MISCONDUCT FIELD
            XFDLService.UpdateXFDLTemplate(document, 0, "MisconductType", string.Empty);

            // FILL THE MULTIPLE CHOICES FIELDS
            XFDLService.UpdateXFDLTemplate(document, 0, "MisconductType", model.MisconductType(), "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 0, "MisconductTypeOther", model.misconductTypeOther);

            // CHILD QUESTIONS HIDE SHOW SECTION
            XFDLService.UpdateHideShowNode(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), model.showInsiderTradingQuestions.ToString());
            XFDLService.UpdateHideShowNode(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), model.showFraudQuestions.ToString());
            XFDLService.UpdateHideShowNode(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), model.showCorpDisclosureQuestions.ToString());
            XFDLService.UpdateHideShowNode(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), model.showIllegalDistribQuestions.ToString());
            XFDLService.UpdateHideShowNode(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), model.showOtherQuestions.ToString());

            // CLEANING THE CHILD QUESTIONS
            XFDLService.UpdateXFDLTemplate(document, 0, "WhenOccurred", "", "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 1, "WhenOccurred", "", "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 2, "WhenOccurred", "", "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 3, "WhenOccurred", "", "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 4, "WhenOccurred", "", "oldValue");

            // CHILD QUESTIONS
            XFDLService.UpdateXFDLTemplate(document, 0, "WhenOccurred", model.WhenOccurred(MisconductTypeEnum.InsiderTrading), "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 1, "WhenOccurred", model.WhenOccurred(MisconductTypeEnum.Fraud), "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 2, "WhenOccurred", model.WhenOccurred(MisconductTypeEnum.CorpDisclosure), "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 3, "WhenOccurred", model.WhenOccurred(MisconductTypeEnum.IllegalDistrib), "oldValue");
            XFDLService.UpdateXFDLTemplate(document, 4, "WhenOccurred", model.WhenOccurred(MisconductTypeEnum.Other), "oldValue");

            #region :: CLEANING DATES ::
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "fromMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "fromYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "toMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "toYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "fromMnth", "", DatesEnum.Ongoing);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.InsiderTrading.ToString(), "fromYr", "", DatesEnum.Ongoing);

            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "fromMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "fromYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "toMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "toYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "fromMnth", "", DatesEnum.Ongoing);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Fraud.ToString(), "fromYr", "", DatesEnum.Ongoing);

            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "fromMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "fromYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "toMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "toYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "fromMnth", "", DatesEnum.Ongoing);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "fromYr", "", DatesEnum.Ongoing);

            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "fromMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "fromYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "toMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "toYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "fromMnth", "", DatesEnum.Ongoing);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.IllegalDistrib.ToString(), "fromYr", "", DatesEnum.Ongoing);

            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "fromMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "fromYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "toMnth", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "toYr", "", DatesEnum.Past);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "fromMnth", "", DatesEnum.Ongoing);
            XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.Other.ToString(), "fromYr", "", DatesEnum.Ongoing);
            #endregion

            // CHILD QUESTION NODE 2 DATES
            foreach (Dates date in model.dates)
            {
                XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", date.relatedTo.ToString(), "fromMnth", ((int)date.fromMnth).ToString(), date.whenDate);
                XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", date.relatedTo.ToString(), "fromYr", date.fromYr.ToString(), date.whenDate);

                if (date.toMnth != null)
                    XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", date.relatedTo.ToString(), "toMnth", ((int)date.toMnth).ToString(), date.whenDate);
                if (date.toYr != null)
                    XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", date.relatedTo.ToString(), "toYr", date.toYr, date.whenDate);
            }

            //XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "fromYr", "2022");
            //XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "toMnth", "5");
            //XFDLService.UpdateSpecificXFDLTemplate(document, "MisconductDetail", "type", MisconductTypeEnum.CorpDisclosure.ToString(), "toYr", "2022");

            // AJUST THE NUMBER OF NODES FROM XFDL TEMPLATE
            document = XFDLService.UpdateNumberOfNodes(document, "WbInfo_row", model.Whistleblowers.Count);
            document = XFDLService.UpdateNumberOfNodes(document, "Individual_row", model.Individuals.Count);
            document = XFDLService.UpdateNumberOfNodes(document, "Entity_row", model.Entities.Count);

            for (int i = 0; i < model.Whistleblowers.Count; i++)
            {
                Whistleblowers whistleblower = model.Whistleblowers[i];

                document = XFDLService.UpdateXFDLTemplate(document, i, "Wb_DisplayNM", whistleblower.Wb_DisplayNM);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Wb_FName", whistleblower.Wb_FName);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Wb_MidName", whistleblower.Wb_MidName);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Wb_LName", whistleblower.Wb_LName);
            }
            for (int i = 0; i < model.Individuals.Count; i++)
            {
                Individuals individuals = model.Individuals[i];
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_FName", individuals.Individual_FName);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_LName", individuals.Individual_LName);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_DisplayNM", individuals.Individual_DisplayNM);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_JobTitle", individuals.Individual_JobTitle);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_Address", individuals.Individual_Address);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_City", individuals.Individual_City);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_Province", individuals.Individual_Province);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_Country", individuals.Individual_Country);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_Phone", individuals.Individual_Phone);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_Email", individuals.Individual_Email);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_EmpOfEntityFlag", individuals.Individual_EmpOfEntityFlag);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_OtherEmplyrName", individuals.Individual_OtherEmplyrName);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Individual_EmpOfEntityList", individuals.Individual_EmpOfEntityList);
            }
            for (int i = 0; i < model.Entities.Count; i++)
            {
                Entities entities = model.Entities[i];
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_DisplayNM", entities.Entity_DisplayNM);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_NM", entities.Entity_NM);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_Address", entities.Entity_Address);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_City", entities.Entity_City);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_Province", entities.Entity_Province);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_Country", entities.Entity_Country);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_Phone", entities.Entity_Phone);
                document = XFDLService.UpdateXFDLTemplate(document, i, "Entity_Website", entities.Entity_Website);
            }

            return document; //XFDLService.SaveXFDL(document, "WBTemplate_GeneratedByCode");
        }

        // MODEL FILE FIILING
        private static WhistleblowerModel FillRecord(Root jsonObjectModel)
        {
            WhistleblowerModel WBM = new WhistleblowerModel();
            WBM.submissionID = jsonObjectModel.body.value.D365GUID;
            CrmdOwbwebform webForm = jsonObjectModel.body.value.crmd_owbwebforms.Count > 0 ? jsonObjectModel.body.value.crmd_owbwebforms[0] : null;

            if (webForm == null)
                return null;

            WBM.AnonymousFlag = ((crmd_tell_us_about_yourself)webForm.crmd_tell_us_about_yourself).ToString();

            // WHISTLEBLOWERS
            for (int i = 0; i < jsonObjectModel.body.value.crmd_owbcontactor.Count; i++)
            {
                foreach (Value WBConstructor in jsonObjectModel.body.value.crmd_owbcontactor[i].value)
                {
                    Whistleblowers whistleblowers = new Whistleblowers();

                    if (WBConstructor.crmd_wb_firstname != null)
                    {
                        whistleblowers.Wb_FName = WBConstructor.crmd_wb_firstname;
                        whistleblowers.Wb_MidName = WBConstructor.crmd_wb_middlename;
                        whistleblowers.Wb_LName = WBConstructor.crmd_wb_lastname;

                        if (!string.IsNullOrEmpty(whistleblowers.Wb_MidName))
                            whistleblowers.Wb_DisplayNM = $"{whistleblowers.Wb_FName} {whistleblowers.Wb_MidName} {whistleblowers.Wb_LName}";
                        else
                            whistleblowers.Wb_DisplayNM = $"{whistleblowers.Wb_FName} {whistleblowers.Wb_LName}";

                        WBM.Whistleblowers.Add(whistleblowers);
                    }
                }
            }

            // INDIVIDUALS
            for (int i = 0; i < jsonObjectModel.body.value.crmd_owbindividual.Count; i++)
            {
                foreach (Value owbIndividual in jsonObjectModel.body.value.crmd_owbindividual[i].value)
                {
                    Individuals individuals = new Individuals();

                    if (owbIndividual.crmd_firstname_individual != null)
                    {
                        individuals.Individual_FName = owbIndividual.crmd_firstname_individual;
                        individuals.Individual_LName = owbIndividual.crmd_lastname_individual;
                        individuals.Individual_DisplayNM = $"{individuals.Individual_FName} {individuals.Individual_LName}";

                        individuals.Individual_JobTitle = owbIndividual.crmd_jobposition_individual;

                        individuals.Individual_Address = owbIndividual.crmd_streetaddress_individual;
                        individuals.Individual_City = owbIndividual.crmd_city_individual;
                        individuals.Individual_Province = "ON";  //owbIndividual.crmd_province_individual;
                        individuals.Individual_Country = "Canada"; //owbIndividual.crmd_country_individual;
                        individuals.Individual_Phone = owbIndividual.crmd_phonenumber_individual;
                        individuals.Individual_Email = owbIndividual.crmd_email_individual;

                        individuals.Individual_EmpOfEntityFlag = ((crmd_indiv_employee_officer_director)owbIndividual.crmd_indiv_employee_officer_director).ToString().Replace("_", " ");

                        List<string> entitiesRelated = new List<string>();
                        if (owbIndividual.crmd_individual_employing_entity1)
                            entitiesRelated.Add("E1");
                        if (owbIndividual.crmd_individual_employing_entity2)
                            entitiesRelated.Add("E2");
                        if (owbIndividual.crmd_individual_employing_entity3)
                            entitiesRelated.Add("E3");
                        if (owbIndividual.crmd_individual_employing_entity4)
                            entitiesRelated.Add("E4");
                        if (owbIndividual.crmd_individual_employing_entity5)
                            entitiesRelated.Add("E5");

                        string entitiesRelatedString = string.Empty;
                        foreach (string item in entitiesRelated)
                        {
                            if (string.IsNullOrEmpty(entitiesRelatedString))
                                entitiesRelatedString = item;
                            else
                                entitiesRelatedString = $"{entitiesRelatedString} {item}";
                        }
                        individuals.Individual_EmpOfEntityList = entitiesRelatedString;// crmd_individual_employing_entity1
                        individuals.Individual_OtherEmplyrName = owbIndividual.crmd_indiv_employed_at_time_miscond_text;

                        WBM.Individuals.Add(individuals);
                    }
                }
            }

            // ENTITIES
            for (int i = 0; i < jsonObjectModel.body.value.crmd_owbfirm.Count; i++)
            {
                foreach (Value entitiesWB in jsonObjectModel.body.value.crmd_owbfirm[i].value)
                {
                    // CHECK IT TO CHECK BY NAME
                    if (entitiesWB.crmd_street_entitiies != null)
                    {
                        Entities entities = new Entities();
                        entities.Entity_DisplayNM = "ABC Company"; // entitiesWB.crmd_name_entities;
                        entities.Entity_NM = "ABC Company"; // entitiesWB.crmd_street_entitiies
                        entities.Entity_Address = entitiesWB.crmd_street_entitiies;
                        entities.Entity_City = entitiesWB.crmd_city_entities;
                        entities.Entity_Province = "ON"; // entitiesWB.crmd_name_entities;
                        entities.Entity_Country = "Canada"; // entitiesWB.crmd_name_entities;
                        entities.Entity_Phone = entitiesWB.crmd_phonenumber_entities;
                        entities.Entity_Website = entitiesWB.crmd_website_entities;

                        WBM.Entities.Add(entities);
                    }
                }
            }

            // MULTIPLE OPTION QUESTION
            if (webForm.crmd_miscondcorpdisclfinancialstatem)
                WBM.MisconductTypeAppend(MisconductTypeEnum.CorpDisclosure);

            if (webForm.crmd_misconductillegalinsidertrading)
                WBM.MisconductTypeAppend(MisconductTypeEnum.Fraud);

            if (webForm.crmd_misconductillegalinsidertrading)
                WBM.MisconductTypeAppend(MisconductTypeEnum.IllegalDistrib);
            if (webForm.crmd_misconductillegalinsidertrading)
                WBM.MisconductTypeAppend(MisconductTypeEnum.InsiderTrading);
            if (webForm.crmd_misconductillegalinsidertrading)
                WBM.MisconductTypeAppend(MisconductTypeEnum.Other);

            // CHILD QUESTIONS
            WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.past);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.future);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.ongoing);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.unknown);

            Dates date1 = new Dates(MisconductTypeEnum.CorpDisclosure, DatesEnum.Past, Month.Jan, "2022", Month.Dec, "2022");
            Dates date2 = new Dates(MisconductTypeEnum.CorpDisclosure, DatesEnum.Ongoing, Month.Jan, "2022");
            WBM.dates.Add(date1);
            WBM.dates.Add(date2);

            WBM.misconductTypeOther = string.Empty; // "TEST VAL CRMD AN HSO COMPANY";
            return WBM;
        }
        private static WhistleblowerModel FillRecord()
        {
            WhistleblowerModel WBM = new WhistleblowerModel();
            WBM.submissionID = "WBF1649673077992-725";
            WBM.AnonymousFlag = "no";

            // MULTIPLE OPTION QUESTION
            WBM.MisconductTypeAppend(MisconductTypeEnum.CorpDisclosure);
            //WBM.MisconductTypeAppend(MisconductTypeEnum.Fraud);
            //WBM.MisconductTypeAppend(MisconductTypeEnum.IllegalDistrib);
            //WBM.MisconductTypeAppend(MisconductTypeEnum.InsiderTrading);
            //WBM.MisconductTypeAppend(MisconductTypeEnum.Other);

            // CHILD QUESTIONS
            WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.past);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.future);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.ongoing);
            //WBM.WhenOccurredAppend(MisconductTypeEnum.CorpDisclosure, WhenOccurredEnum.unknown);

            Dates date1 = new Dates(MisconductTypeEnum.CorpDisclosure, DatesEnum.Past, Month.Jan, "2022", Month.Dec, "2022");
            Dates date2 = new Dates(MisconductTypeEnum.CorpDisclosure, DatesEnum.Ongoing, Month.Jan, "2022");
            WBM.dates.Add(date1);
            WBM.dates.Add(date2);


            WBM.misconductTypeOther = string.Empty; // "TEST VAL CRMD AN HSO COMPANY";

            // WHISTLEBLOWERS
            for (int i = 0; i < 3; i++)
            {
                Whistleblowers whistleblowers = new Whistleblowers();

                whistleblowers.Wb_FName = "Denize";
                whistleblowers.Wb_MidName = "Somões de";
                whistleblowers.Wb_LName = "Oliveira";

                if (!string.IsNullOrEmpty(whistleblowers.Wb_MidName))
                    whistleblowers.Wb_DisplayNM = $"{whistleblowers.Wb_FName} {whistleblowers.Wb_MidName} {whistleblowers.Wb_LName}";
                else
                    whistleblowers.Wb_DisplayNM = $"{whistleblowers.Wb_FName} {whistleblowers.Wb_LName}";

                WBM.Whistleblowers.Add(whistleblowers);
            }

            // INDIVIDUALS
            for (int i = 0; i < 3; i++)
            {
                Individuals individuals = new Individuals();

                individuals.Individual_FName = "Caio";
                individuals.Individual_LName = "Stefanes";
                individuals.Individual_DisplayNM = $"{individuals.Individual_FName} {individuals.Individual_LName}";

                individuals.Individual_JobTitle = "Developer";

                individuals.Individual_Address = "2 Lascelles Bolvd";
                individuals.Individual_City = "Toronto";
                individuals.Individual_Province = "ON";
                individuals.Individual_Country = "Canada";
                individuals.Individual_Phone = "11 976973452";
                individuals.Individual_Email = "caio.stefanes@gmail.com";

                individuals.Individual_EmpOfEntityFlag = "no";
                individuals.Individual_OtherEmplyrName = "kljSAGHDFJKHSDGF,KJ.f";

                WBM.Individuals.Add(individuals);
            }

            // ENTITIES
            for (int i = 0; i < 3; i++)
            {
                Entities entities = new Entities();
                entities.Entity_DisplayNM = "ABC Company";
                entities.Entity_NM = "ABC Company";
                entities.Entity_Address = "56 Lakeshore W";
                entities.Entity_City = "Oakville";
                entities.Entity_Province = "ON";
                entities.Entity_Country = "Canada";
                entities.Entity_Phone = "9056667777";
                entities.Entity_Website = "www.abc.com";

                WBM.Entities.Add(entities);
            }

            return WBM;
        }
    }
}