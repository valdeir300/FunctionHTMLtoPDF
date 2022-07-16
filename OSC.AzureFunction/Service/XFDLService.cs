using OSC.AzureFunction.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace OSC.AzureFunction.Service
{
    public class XFDLService
    {
        /// <summary>
        /// AJUST THE NUMBER OF RECORDS IN THE XFDL FILE
        /// </summary>
        /// <param name="document"></param>
        /// <param name="node"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        public static XmlDocument UpdateNumberOfNodes(XmlDocument document, string node, int times)
        {
            bool changed = false;
            var elements = document.SelectNodes($"//{node}");

            // REMOVE NULL OBJECT
            for (int i = 0; i < elements.Count; i++)
            {
                XmlNode element = elements[i];
                if (string.IsNullOrEmpty(element.FirstChild.NextSibling.InnerXml))
                {
                    element.ParentNode.RemoveChild(element);
                    changed = true;
                }
            }

            if (changed)
                elements = document.SelectNodes($"//{node}");

            // REMOVE NODES
            if (elements.Count > times)
            {
                times = elements.Count - times;
                int index = elements.Count - 1;
                for (int i = 0; i < times; i++)
                {
                    XmlNode element = elements[index];
                    element.ParentNode.RemoveChild(element);
                    index--;
                }
            }
            else if (elements.Count < times)
            {
                times = times - elements.Count;
                int valueNumber = elements.Count + 1;
                for (int i = 0; i < times; i++)
                {
                    XmlNode element = elements[0].Clone();
                    if (element.Attributes["number"] != null)
                    {
                        element.Attributes["number"].Value = $"E{valueNumber}";
                        valueNumber++;
                    }
                    elements[0].ParentNode.AppendChild(element);
                }
            }
            return document;
        }

        /// <summary>
        /// UPDATE ANY NODE OF XFDL FILE
        /// </summary>
        /// <param name="document"></param>
        /// <param name="index"></param>
        /// <param name="XFDL_Field"></param>
        /// <param name="value"></param>
        /// <returns>XmlDocument RECORD</returns>
        public static XmlDocument UpdateXFDLTemplate(XmlDocument document, int index, string XFDL_Field, string value, string attr = null)
        {
            var elements = document.SelectNodes($"//{XFDL_Field}");
            for (int i = 0; i < elements.Count; i++)
            {
                XmlNode element = elements[index];
                element.InnerText = value;

                if (!string.IsNullOrEmpty(attr) && element.Attributes[attr] != null)
                    element.Attributes[attr].Value = $"{value}";
            }
            return document;
        }

        public static XmlDocument UpdateSpecificXFDLTemplate(XmlDocument document, string XFDL_Field, string ParentAttr, string ParentAttrLookup, string attr, string value, DatesEnum whenParam)
        {
            var elements = document.SelectNodes($"//{XFDL_Field}");
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Attributes[ParentAttr].Value == ParentAttrLookup)
                {
                    XmlNode element = elements[i];
                    var childNodes = element.ChildNodes;
                    element.SelectNodes(whenParam.ToString())[0].SelectNodes("Period")[0].Attributes[attr].Value = value;
                }
            }
            return document;
        }

        /// <summary>
        /// UPDATE SHOW/HIDE SECTION NODE
        /// </summary>
        /// <param name="document"></param>
        /// <param name="XFDL_Field"></param>
        /// <param name="index"></param>
        /// <param name="attr"></param>
        /// <param name="lookupField"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static XmlDocument UpdateHideShowNode(XmlDocument document, string XFDL_Field, string attr, string lookupField, string value)
        {
            var elements = document.SelectNodes($"//{XFDL_Field}");
            for (int i = 0; i < elements.Count; i++)
            {
                XmlNode element = elements[i];

                if (!string.IsNullOrEmpty(attr) && element.Attributes[attr] != null && element.Attributes[attr].Value == lookupField)
                    element.Attributes["selected"].Value = value;
            }
            return document;
        }

        /// <summary>
        /// THIS METHOD WILL RETURN THE XML TEMPLATE RELATED TO THE XFDL FILE
        /// </summary>
        /// <param name="templateName"></param>
        /// <returns>XmlDocument RECORD</returns>
        public static XmlDocument GetTemplate(string templateName)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            executableLocation = Path.GetFullPath(Path.Combine(executableLocation, @"..\"));
            string path = Path.Combine(executableLocation, $"{templateName}.xml");
            XmlDocument document = new XmlDocument();
            document.Load(path);
            return document;
        }

        /// <summary>
        /// SAVE THE RECORD INTO A DIRECTORY
        /// </summary>
        /// <param name="document"></param>
        /// <param name="newFileName"></param>
        public static XmlDocument SaveXFDL(XmlDocument document, string newFileName)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            executableLocation = Path.GetFullPath(Path.Combine(executableLocation, @"..\"));
            string path = Path.Combine(executableLocation, $"{newFileName}.xfdl");
            document.Save(path);
            return document;
        }
    }
}
