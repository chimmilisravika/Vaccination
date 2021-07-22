using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Vaccination;

namespace Vaccination_NUnit
{
    public class Tests
    {
        public string xmlString = string.Empty;
       [SetUp]
        public void Setup()
        {
            Vaccination_Details objVac = new Vaccination_Details();
            //Test data
            objVac.userName = "Chimmili Sravika";
            objVac.Gender = "Female";
            objVac.contactNumber = "9344460245";
            objVac.Age = "27";
            objVac.vaccineName = "Covishield";
            objVac.Address = "AP";
            objVac.addressProof = "Pan Card";
            List<Vaccination_Details> vacDetails1 = new List<Vaccination_Details>();
            //adding Object to list
            vacDetails1.Add(objVac);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Vaccination_Details>));
            using (TextWriter writer = new StreamWriter(Environment.CurrentDirectory+@"\\test.xml"))
            {
                serializer.Serialize(writer, vacDetails1);
            }
           xmlString = System.IO.File.ReadAllText(Environment.CurrentDirectory + @"\\test.xml");
        }
        //getting actual data from XML
        public string getActualData(String nodeData)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlString);

            XmlNodeList nodeList = xmldoc.GetElementsByTagName(nodeData);
            string actualData = string.Empty;
            foreach (XmlNode node in nodeList)
            {
                actualData = node.InnerText;
            }
            return actualData;
        }

        // Test Method for UserName
        [Test]
        public void userNameTest()
        {
            var actualRes = getActualData("userName");
            string Expetedresult = "Chimmili Sravika"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        //Test Method for Gender
        [Test]
        public void genderTest()
        {
            var actualRes = getActualData("Gender");
            string Expetedresult = "Female"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        //Test Method for Contact Number
        [Test]
        public void contactNumberTest()
        {
            var actualRes = getActualData("contactNumber");
            string Expetedresult = "9344460245"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        //Test Method for Age
        [Test]
        public void ageTest()
        {
            var actualRes = getActualData("Age");
            string Expetedresult = "27"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        // Test Method for Vaccine Name
        [Test]
        public void vaccineNameTest()
        {
            var actualRes = getActualData("vaccineName");
            string Expetedresult = "Covishield"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        // Test Method for Address
        [Test]
        public void addressTest()
        {
            var actualRes = getActualData("Address");
            string Expetedresult = "AP"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
        // Test Method for AddressProof
        [Test]
        public void addressProofTest()
        {
            var actualRes = getActualData("addressProof");
            string Expetedresult = "Pan Card"; ;
            Assert.AreEqual(Expetedresult, actualRes);
        }
    }
}