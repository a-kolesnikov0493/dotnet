using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            #region JSON NEWTON
            var json = "{\"CardNumber\":\"6666666666666665\",\"ExpiryDate\":\"11/11\",\"Cvv\":\"333\",\"CardHolderName\":\"test test\",\"BillingAddressSameAsResidence\": true}";
            var json2 = "{\"BillingAddressSameAsResidence\": true}";
            var json3 = "{\"CardNumb3r\":\"6666666666666665\",\"ExpuryDate\":\"11/11\",\"Cevv\":\"333\",\"CardHold3rName\":\"test test\",\"BillingAddressSameAsResidence\": true}";
            var json4 = "{\"CardNumb3r\":\"6666666666666665\",\"ExpuryDate\":\"11/11\",\"Cevv\":\"333\",\"CardHolderName\":\"test test\",\"BillingAddressSameAsResidence\": true}";
            var json5 = "{\"CardNumber\":\"6666666666666665\",\"ExpiryDate\":\"11/11\",\"Cvv\":\"333\",\"CardHolderName\":\"test test\",\"BillingAddressSameAsResidence\": true," +
                "\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\"}}}}";

            var json6 = "{\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\"}}},\"CardNumber\":\"6666666666666665\",\"ExpiryDate\":\"11/11\",\"Cvv\":\"333\",\"CardHolderName\":\"test test\",\"BillingAddressSameAsResidence\": true}";

            var json7 = "{\"CardNumber\":\"6666666666666665\",\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\"}}},\"ExpiryDate\":\"11/11\",\"Cvv\":\"333\",\"CardHolderName\":\"test test\",\"BillingAddressSameAsResidence\": true}";

            var json8 = "{\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\"}}}, \"BillingAddressSameAsResidence\": true}";

            var json9 = "{\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\"}}}, \"BillingAddressSameAsResidence\": true}";

            var json10 = "{\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\",\"ExpiryDate\": \"notifications@hiqo-solutions.com\"}}}}";

            var json11 = "{\"ExternalProviders\": {\"MailKit\": {\"SMTP\": {\"Address\": \"mail.hiqo-solutions.com\",\"Port\": \"465\",\"Password\":\"somepassword\",\"SenderEmail\":\"noreply@hiqo-solutions.com\",\"SenderName\": \"Redbutton\"}}}, \"SomeDate\":\"date\"}";

            var array = new[] { json, json2, json3, json4, json5, json6, json7, json8, json9, json10, json11 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = ExcludeRestrictedDataFromRequestBody(array[i]);
            //    Console.WriteLine(array[i]);
            //    Console.WriteLine();
            //}

            var notJson = "<note>< to > Tove </ to >< from > Jani </ from >< heading > Reminder </ heading >< body > Don't forget me this weekend!</body>   </ note > ";


            notJson = ExcludeRestrictedDataFromRequestBody(notJson);

            Console.WriteLine(notJson);
            #endregion

            #region XML
            //var xmlExample1 = @"clecID=191&request=<?xml version=""1.0"" encoding=""utf - 16""?>< BeQuick xmlns: xsd = ""http://www.w3.org/2001/XMLSchema"" xmlns: xsi = ""http://www.w3.org/2001/XMLSchema-instance"" product = ""OSS"" >< session >< clec >< id > 191 </ id >< user >< firstName > CGM </ firstName >< lastName > App </ lastName ></ user ></ clec ></ session >< request type = ""PlanList"" >< companyId > 4 </ companyId >< zipcode > 30075 </ zipcode >< state > GA </ state >< agentAccount > 123123123 </ agentAccount ></ request ></ BeQuick >";

            //var xmlExample1 = @"<?xml version=""1.0"" encoding=""utf-16""?><BeQuick xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""  product = ""OSS"" > <session ><clec ><id > 191 </id ><user ><firstName > CGM </firstName ><lastName > App </lastName ></user ></clec ></session ><request type = ""PlanList"" ><companyId > 4 </companyId ><zipcode > 30075 </zipcode ><state > GA </state ><agentAccount > 123123123 </agentAccount ></request ></BeQuick >";


            //var jsonExample1 = @"{""CustomerId"":199,""AssociatedCustomerIds"":[],""FirstName"":""qwetestlogger"",""LastName"":""qwetestlogger"",""SecondLastName"":"""",""MiddleName"":"""",""DateOfBirth"":""2004 - 01 - 01T00: 00:00"",""Ssn"":""3333"",""ResidenceAddress01"":""qwetestlogger"",""ResidenceAddress02"":"""",""ResidenceCity"":""qwetestlogger"",""ResidenceState"":""GA"",""ResidenceZip"":""30075"",""SecondLastNameValidationEnabled"":false,""StartPeriodDate"":null}";


            //var xmlExample2 = "<EtcReservationRequestV001 xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"><ApiVersion>V1.0</ApiVersion><VendorCode>BQ</VendorCode><ClientCode>EAS</ClientCode><UserCode>kolesnikovEAS</UserCode><AgentCode>kolesnikovEAS</AgentCode><RequestTransactionCode>2e2fdc36-8cec-ec11-810e-005056a91489</RequestTransactionCode><FirstName>qwetestlogger</FirstName><LastName>qwetestlogger</LastName><DateOfBirth>2004-01-01</DateOfBirth><SocialSecurityNo>3333</SocialSecurityNo><StateEligibilityCode>GAMCAID</StateEligibilityCode><ResidenceAddress01>qwetestlogger</ResidenceAddress01><ResidenceCity>qwetestlogger</ResidenceCity><ResidenceState>GA</ResidenceState><ResidenceZip>30075</ResidenceZip></EtcReservationRequestV001>";

            //var newExample = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<BeQuick xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" product=\"OSS\">\r\n  <session>\r\n    <clec>\r\n      <id>208</id>\r\n      <user>\r\n        <firstName>cgm</firstName>\r\n        <lastName>app</lastName>\r\n      </user>\r\n    </clec>\r\n  </session>\r\n  <request type=\"PlanList\">\r\n    <companyId>6</companyId>\r\n    <zipcode>30075</zipcode>\r\n    <state>GA</state>\r\n    <agentAccount>0</agentAccount>\r\n    <lifelineCertificationId>11</lifelineCertificationId>\r\n    <ebbTypeId>3</ebbTypeId>\r\n  </request>\r\n</BeQuick>";

            //var withBankCaccount = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<BeQuick xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" product=\"OSS\">\r\n  <session>\r\n    <clec>\r\n      <id>208</id>\r\n      <user>\r\n        <firstName>cgm</firstName>\r\n        <lastName>app</lastName>\r\n      </user>\r\n    </clec>\r\n  </session>\r\n  <request type=\"PlanList\">\r\n    <companyId>6</companyId>\r\n    <zipcode>30075</zipcode>\r\n    <state>GA</state>\r\n    <agentAccount>0</agentAccount>\r\n    <lifelineCertificationId>11</lifelineCertificationId>\r\n    <ebbTypeId>3</ebbTypeId>\r\n  <bankAccount/>\r\n  </request>\r\n</BeQuick>";

            var hasToTrim = "Random text";
            var hasToTrimEnd = "More ranodm text";

            var bqPostCustomerPaymentString = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<BeQuick xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" product=\"OSS\">\r\n  <session>\r\n    <clec>\r\n      <id>208</id>\r\n      <user>\r\n        <firstName>cgm</firstName>\r\n        <lastName>app</lastName>\r\n      </user>\r\n    </clec>\r\n  </session>\r\n  <request type=\"PostCustomerPayment\">\r\n      <isDeposit>Y|N</isDeposit>\r\n      <notes>Partial Payment</notes>\r\n      <agentId>1000</agentId>\r\n      <tillId>1</tillId>\r\n      <requireValidAgentAccount>Y</requireValidAgentAccount>\r\n          <customerId>2000</customerId>\r\n      <confirmationNumber>V53AOA33O381</confirmationNumber>\r\n      <receiptNumber>432</receiptNumber>\r\n      <paymentTotal>678.90</paymentTotal>\r\n      <paymentType>Credit Card</paymentType>\r\n      <paymentSource>QUICKTEL</paymentSource>\r\n      <bankAccount/>\r\n      <bankRouting/>\r\n      <bankName/>\r\n      <bankCity/>\r\n      <bankState/>\r\n      <bankZip/>\r\n      <bankTellerNumber/>\r\n      <checkNumber>123456789012323</checkNumber>\r\n      <checkName/>\r\n      <checkAddress1>Palm Beach Gardens</checkAddress1>\r\n      <checkAddress2>The Corner Store</checkAddress2>\r\n      <checkCity>New York</checkCity>\r\n      <checkState>NY</checkState>\r\n      <checkZip>37023</checkZip>\r\n      <checkPhone>3456789012</checkPhone>\r\n      <driverLicenseNumber>23456</driverLicenseNumber>\r\n      <driverLicenseNumberState>NY</driverLicenseNumberState>\r\n      <noDuplicateDetection>Y</noDuplicateDetection>\r\n      <useCustomerAutoPayProfile>Y</useCustomerAutoPayProfile>\r\n      <mtcn/>\r\n      <moneyOrderNumber/>\r\n      <lookupPaymentFees>Y</lookupPaymentFees>\r\n      <suppressPaymentFees>Y</suppressPaymentFees>\r\n      <paymentUnpostedID/>\r\n      <skipReconnectionOrdering>Y</skipReconnectionOrdering>\r\n      <processElectronicPayment>Y</processElectronicPayment>\r\n      <useCustomerAutoPayProfile>Y</useCustomerAutoPayProfile>\r\n      <addPaymentFeeToPayment>Y</addPaymentFeeToPayment>\r\n      <originalReferenceNumber/>\r\n      <ccType>Master Card</ccType>\r\n      <ccTypeCode>MC</ccTypeCode>\r\n      <ccNumber>2345678998765432</ccNumber>\r\n      <ccHolderName>Steve</ccHolderName>\r\n      <ccExp>05/2008</ccExp>\r\n      <ccCV>350</ccCV>\r\n      <billingZip>37023</billingZip>\r\n      <billingStreetAddress>Park Avenue</billingStreetAddress>\r\n      <pinNumber>12345</pinNumber>\r\n      <buyAirTimeSkuID>100</buyAirTimeSkuID>\r\n      <mdn>5558675309</mdn>\r\n      <buyInventorySkuID>100</buyInventorySkuID>\r\n      <changePlanId>39</changePlanId>\r\n      <transactionDate>\r\n      <year>2006</year>\r\n      <month>05</month>\r\n      <day>12</day>\r\n      </transactionDate>\r\n      <dateOfBirth>\r\n      <year>1983</year>\r\n      <month>03</month>\r\n      <day>06</day>\r\n      </dateOfBirth>\r\n      <invoices>\r\n      <invoice>\r\n      <invId>123</invId>\r\n      <id>12</id>\r\n      <appliedAmount>543.00</appliedAmount>\r\n      </invoice>\r\n      </invoices>\r\n      </request>\r\n</BeQuick>";


            var bqString = "<BeQuick product=\"OSS\">\r\n      <session>\r\n      <clec>\r\n      <id>101</id>\r\n      <user>\r\n      <firstName>FirstName</firstName>\r\n      <lastName>Lastname</lastName>\r\n      </user>\r\n      </clec>\r\n      </session>\r\n      <request type=\"PostCustomerPayment\">\r\n      <customerId>1000000</customerId>\r\n      <paymentType>PIN Number</paymentType>\r\n      <changePlanId>29</changePlanId>                \r\n      <pinNumber>293049587</pinNumber>\r\n      </request>\r\n      </BeQuick>";



            var data = hasToTrim + bqPostCustomerPaymentString + hasToTrimEnd;

            bool contains = data.Contains("<request type=\"PostCustomerPayment\">");

            if (contains)
            {
                var startXml = "<?xml";
                //var startXml = "<BeQuick";
                var endXml = "</BeQuick>";
                var startIndexOfXmlString = data.IndexOf(startXml);
                var endIndexOfXmlString = data.IndexOf(endXml);
                var length = endIndexOfXmlString - startIndexOfXmlString;


                var xmlString = data.Substring(startIndexOfXmlString, length) + endXml;

                data = data.Remove(startIndexOfXmlString, length + endXml.Length);

                BeQuickXml bqx;
                bqx = BeQuickXmlSerializer<BeQuickXml>.Deserialize(xmlString);

                if (bqx.Request.PaymentType.Equals("Credit card", StringComparison.InvariantCultureIgnoreCase))
                {
                    bqx.Request.CcNumber = new string('X', bqx.Request.CcNumber.Length);
                    bqx.Request.CcCV = new string('X', bqx.Request.CcCV.Length);
                    bqx.Request.CcExp = new string('X', bqx.Request.CcExp.Length);
                    bqx.Request.CcHolderName = new string('X', bqx.Request.CcHolderName.Length);
                }

                var result = BeQuickXmlSerializer<BeQuickXml>.Serialize(bqx);

                data = data.Insert(startIndexOfXmlString, result);
            }


            Console.WriteLine(data);

            #endregion
        }

        #region JSON2
        public static string RemoveRestrictedData(string requestBody)
        {
            foreach (var kvp in Restricted2.keyValuePairs)
            {
                Regex regex = new Regex(kvp.Key);
                requestBody = regex.Replace(requestBody, kvp.Value);
            }

            return requestBody;
        }

        #endregion


        #region JSON NEWTON
        private static string ExcludeRestrictedDataFromRequestBody(string requestBody)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<JObject>(requestBody);
                var restrictedData = GetRestrictedDataList(typeof(RestrictedData));

                if (ContainsRestrictedData(jsonObject, restrictedData))
                {
                    HideRestrictedDataRecursive(jsonObject, restrictedData);
                }

                return JsonConvert.SerializeObject(jsonObject);
            }
            catch
            {
                return requestBody;
            }
        }

        private static bool ContainsRestrictedData(JObject jsonObject, List<string> RestrictedData)
        {
            return ContrainsRestrictedDataRecursive(jsonObject, RestrictedData);
        }

        private static bool ContrainsRestrictedDataRecursive(JObject jsonObject, List<string> RestrictedData)
        {
            foreach (var result in jsonObject)
            {
                if (result.Value.HasValues)
                {
                    return ContrainsRestrictedDataRecursive((JObject)result.Value, RestrictedData);
                }
                else
                {
                    foreach (var restricted in RestrictedData)
                    {
                        if (result.Key == restricted)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static void HideRestrictedDataRecursive(JObject jsonObject, List<string> RestrictedData)
        {
            foreach (var result in jsonObject)
            {
                if (result.Value.HasValues)
                {
                    HideRestrictedDataRecursive((JObject)result.Value, RestrictedData);
                }
                else
                {
                    continue;
                }
            }

            foreach (var restricted in RestrictedData)
            {
                if ((string)jsonObject[restricted] != null)
                {
                    jsonObject[restricted] = $"[{restricted}]";
                }
            }
        }

        private static List<string> GetRestrictedDataList(Type type)
        {
            var list = new List<string>();
            var fields = type.GetFields();

            foreach (var fieldInfo in fields)
            {
                var field = type.GetField(fieldInfo.Name);
                var fieldValue = field.GetValue(type).ToString();
                list.Add(fieldValue);
            }

            return list;
        }
    }

    public static class RestrictedData
    {
        public const string CardNumber = "CardNumber";
        public const string ExpiryDate = "ExpiryDate";
        public const string Cvv = "Cvv";
        public const string CardHolderName = "CardHolderName";
        public const string Port = "Port";
        public const string Address = "Address";
    }
}




//        private static string GetRequestBodyWithoutRestrictedData(string requestBody)
//        {
//            var jsonObject = JsonConvert.DeserializeObject<JObject>(requestBody);
//            var restrictedData = new[] { RestrictedData.CardNumber, RestrictedData.ExpiryDate, RestrictedData.Cvv, RestrictedData.CardHolderName };
//            if (ContainsRestrictedData(jsonObject, restrictedData))
//            {
//                HideRestrictedDataRecursive(jsonObject, restrictedData);
//            }

//            return JsonConvert.SerializeObject(jsonObject);
//        }

//        private static bool ContainsRestrictedData(JObject jsonObject, string[] RestrictedData)
//        {
//            return ContrainsRestrictedDataRecursive(jsonObject, RestrictedData);
//        }

//        private static bool ContrainsRestrictedDataRecursive(JObject jsonObject, string[] RestrictedData)
//        {
//            foreach (var result in jsonObject)
//            {
//                if (result.Value.HasValues)
//                {
//                    return ContrainsRestrictedDataRecursive((JObject)result.Value, RestrictedData);
//                }
//                else
//                {
//                    foreach (var restricted in RestrictedData)
//                    {
//                        if (result.Key == restricted)
//                        {
//                            return true;
//                        }
//                    }
//                }
//            }

//            return false;
//        }

//        private static void HideRestrictedDataRecursive(JObject jsonObject, string[] RestrictedData)
//        {
//            foreach (var result in jsonObject)
//            {
//                if (result.Value.HasValues)
//                {
//                    HideRestrictedDataRecursive((JObject)result.Value, RestrictedData);
//                }
//                else
//                {
//                    continue;
//                }
//            }

//            foreach (var restricted in RestrictedData)
//            {
//                if ((string)jsonObject[restricted] != null)
//                {
//                    jsonObject[restricted] = $"[{restricted}]";
//                }
//            }
//        }
//    }
//}
//public class RestrictedData
//{
//    public const string CardNumber = "CardNumber";
//    public const string ExpiryDate = "ExpiryDate";
//    public const string Cvv = "Cvv";
//    public const string CardHolderName = "CardHolderName";
//}
#endregion

#region JSON2
public static class Restricted
{
    public const string CardNumberPattern = @"<ccNumber>[0-9]{16}<\/ccNumber>";
    public const string ExpiryDatePattern = @"<ccExp>\d\d.\d\d\<\/ccExp>";
    public const string CvvPattern = @"<ccCV>[0-9]{3,4}<\/ccCv>";
    public const string CardHolderNamePattern = @"<ccHolderName>[a-zA-Z\-'` ]{0,}<\/ccHolderName>";

    public const string CardNumberTarget = @"<ccNumber>ccNumber<\/ccNumber>";
    public const string ExpiryDateTarget = @"<ccExp>ccExp<\/ccExp>";
    public const string CvvTarget = @"<ccCV>ccCv<\/ccCv>";
    public const string CardHolderNameTarget = @"<ccHolderName>ccHolderName<\/ccHolderName>";

    public static Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { @"<ccNumber>.*<\/ccNumber>", "<ccNumber>[ccNumber]</ccNumber>" },
                { @"<ccExp>.*<\/ccExp>", "<ccExp>[ccExp]</ccExp>" },
                { @"<ccCV>.*<\/ccCV>", "<ccCV>[ccCV]</ccCV>" },
                { @"<ccHolderName>.*<\/ccHolderName>", "<ccHolderName>[ccHolderName]</ccHolderName>" }
            };
}

public static class Restricted2
{
    private const string cardNumberPattern = @"<ccNumber>.*<\/ccNumber>";
    private const string expiryDatePattern = @"<ccExp>.*<\/ccExp>";
    private const string cvvPattern = @"<ccCV>.*<\/ccCV>";
    private const string cardHolderNamePattern = @"<ccHolderName>.*<\/ccHolderName>";

    public const string cardNumberTarget = "<ccNumber>[ccNumber]</ccNumber>";
    public const string expiryDateTarget = "<ccExp>[ccExp]</ccExp>";
    public const string cvvTarget = "<ccCV>[ccCV]</ccCV>";
    public const string cardHolderNameTarget = "<ccHolderName>[ccHolderName]</ccHolderName>";

    public static readonly Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { cardNumberPattern, cardNumberTarget },
                { expiryDatePattern, expiryDateTarget },
                { cvvPattern, cvvTarget },
                { cardHolderNamePattern, cardHolderNameTarget }
            };
}


//public const string CardNumberPattern = @"<ccNumber>[0-9]{16}<\/ccNumber>";
//public const string ExpiryDatePattern = @"<ccExp>\d\d.\d\d\<\/ccExp>";
//public const string CvvPattern = @"<ccCV>[0-9]{3,4}<\/ccCv>";
//public const string CardHolderNamePattern = @"<ccHolderName>[a-zA-Z\-'` ]{0,}<\/ccHolderName>";

//public const string CardNumberTarget = @"<ccNumber>ccNumber<\/ccNumber>";
//public const string ExpiryDateTarget = @"<ccExp>ccExp<\/ccExp>";
//public const string CvvTarget = @"<ccCV>ccCv<\/ccCv>";
//public const string CardHolderNameTarget = @"<ccHolderName>ccHolderName<\/ccHolderName>";
#endregion