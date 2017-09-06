using System;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace Assignment4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static XmlNode returnNode;
        private static Boolean reportError = false;
        private static string status = "";
        public string verification(string xmlURL, string xsdURL)
        {
            status = "";
            XmlSchemaSet schSet = new XmlSchemaSet();
            try
            {
                schSet.Add(null, xsdURL);
                XmlReaderSettings rdrStng = new XmlReaderSettings();
                rdrStng.ValidationType = ValidationType.Schema;
                rdrStng.Schemas = schSet;
                rdrStng.ValidationEventHandler += new ValidationEventHandler(ValidateReaderSetting);
                XmlReader rdr = XmlReader.Create(xmlURL, rdrStng);
                reportError = false;
                while (rdr.Read()) ;
                if (reportError == false)
                {
                    status = "No Error";
                }

                return status;
            }
            catch(Exception Ex)
            {
                status = Ex.Message;
            }
            return status;
        }

        private void ValidateReaderSetting(object sender, ValidationEventArgs e)
        {
            reportError = true;
            status = status + "Error in ReaderSettings : " + e.Message;
        }

        public string search(string xmlURL, string keyName)
        {
            string nodeContent = null;
            returnNode = null;
            XmlDocument XMLDoc = new XmlDocument();
            try
            {
                FileStream fs = new FileStream(xmlURL, FileMode.Open, FileAccess.Read);
                XMLDoc.Load(fs);
                XmlElement root = XMLDoc.DocumentElement;

                findNode(root.ChildNodes, keyName);

                if (returnNode == null)
                    nodeContent = "Couldn't find any record matching to : " + keyName;
                else
                {
                    //Loop to find the parent node 
                    while (returnNode.Name != "Person")
                        returnNode = returnNode.ParentNode;

                    foreach (XmlNode x in returnNode)
                    {
                        if (x.Name == "Name")
                        {
                            nodeContent = "Name : " + x.FirstChild.InnerText + " " + x.FirstChild.NextSibling.InnerText + " ";
                        }
                        if (x.Name == "Credential")
                        {
                            if (x.FirstChild.NextSibling.Attributes["Encryption"].Value == "Yes")
                            {
                                nodeContent += " \"PASSWORD is ENCRYPTED\" ";
                            }

                            nodeContent += x.FirstChild.NextSibling.Name + " : " + x.FirstChild.NextSibling.InnerText + " ";
                        }
                        if (x.Name == "Phone")
                        {
                            nodeContent += x.FirstChild.Name + " : " + x.FirstChild.InnerText + " " + x.FirstChild.NextSibling.Name + " : " + x.FirstChild.NextSibling.InnerText + " ";
                            if (x.FirstChild.NextSibling.Attributes.Count != 0 && x.FirstChild.NextSibling.Attributes["Provider"].Value != "")
                            {
                                nodeContent += " Provider : " + x.FirstChild.NextSibling.Attributes["Provider"].Value + " ";
                            }
                        }
                        if (x.Name == "Category")
                        {
                            nodeContent += x.Name + " : " + x.InnerText;
                        }
                    }
                }
            }

            catch(Exception Ex)
            {
                nodeContent = Ex.Message;
            }

            return nodeContent;
        }

        /// <summary>
        /// Function to get complete node of the searched element
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="keyName"></param>
        public void findNode(XmlNodeList nodeList,string keyName)
        {
            foreach (XmlNode x in nodeList)
            {
                if (x.InnerText == keyName)
                {
                    returnNode = x;
                    return;
                }
                else if (x.ChildNodes.Count > 0)
                    findNode(x.ChildNodes, keyName);
            }
        }
    }
}
