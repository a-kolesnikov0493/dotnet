using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    class XmlSerialization
    {
    }

    public static class BeQuickXmlSerializer<T>
    {
        public static T Deserialize(string xmlString)
        {
            using var reader = new StringReader(xmlString);
            return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
        }

        public static string Serialize(T xml)
        {
            var sb = new StringBuilder();
            using var stream = new StringWriter(sb);
            new XmlSerializer(typeof(T)).Serialize(stream, xml);

            return sb.ToString();
        }
    }

    //[XmlRoot("request")]
    //public class RequestXml
    //{
    //    [XmlAttribute("type")]
    //    public string Type { get; set; }
    //    [XmlElement(ElementName = "companyId")]
    //    public string CompanyId { get; set; }
    //    [XmlElement(ElementName = "zipcode")]
    //    public string ZipCode { get; set; }
    //    [XmlElement(ElementName = "state")]
    //    public string State { get; set; }
    //    [XmlElement(ElementName = "agentAccount")]
    //    public string AgentAccount { get; set; }
    //    [XmlElement(ElementName = "lifelineCertificationId")]
    //    public string LifelineCertificationId { get; set; }
    //    [XmlElement(ElementName = "ebbTypeId")]
    //    public string BankAccount { get; set; }
    //}

    [XmlRoot("BeQuick")]
    public class BeQuickXml
    {
        [XmlAttribute("product")]
        public string Product { get; set; }
        [XmlElement(ElementName = "session")]
        public SessionXml Session { get; set; }
        [XmlElement(ElementName = "request")]
        public PostCustomerPaymentXml Request { get; set; }
    }

    [XmlRoot("session")]
    public class SessionXml
    {
        [XmlElement(ElementName = "clec")]
        public ClecXml Clec { get; set; }
    }

    [XmlRoot("clec")]
    public class ClecXml
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "user")]
        public UserXml User { get; set; }
    }

    [XmlRoot("user")]
    public class UserXml
    {
        [XmlElement(ElementName = "firstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "lastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "token")]
        public string Token { get; set; }
    }

    [XmlRoot("request")]
    public class PostCustomerPaymentXml
    {
        [XmlElement(ElementName = "isDeposit")]
        public string IsDeposit { get; set; }
        [XmlElement(ElementName = "notes")]
        public string Notes { get; set; }
        [XmlElement(ElementName = "agentId")]
        public string AgentId { get; set; }
        [XmlElement(ElementName = "tillId")]
        public string TillId { get; set; }
        [XmlElement(ElementName = "requireValidAgentAccount")]
        public string RequireValidAgentAccount { get; set; }
        [XmlElement(ElementName = "customerId")]
        public string CustomerId { get; set; }
        [XmlElement(ElementName = "confirmationNumber")]
        public string ConfirmationNumber { get; set; }
        [XmlElement(ElementName = "receiptNumber")]
        public string ReceiptNumber { get; set; }
        [XmlElement(ElementName = "paymentTotal")]
        public string PaymentTotal { get; set; }
        [XmlElement(ElementName = "paymentType")]
        public string PaymentType { get; set; }
        [XmlElement(ElementName = "paymentSource")]
        public string PaymentSource { get; set; }
        [XmlElement(ElementName = "bankAccount")]
        public string BankAccount { get; set; }
        [XmlElement(ElementName = "bankRouting")]
        public string BankRouting { get; set; }
        [XmlElement(ElementName = "bankName")]
        public string BankName { get; set; }
        [XmlElement(ElementName = "bankCity")]
        public string BankCity { get; set; }
        [XmlElement(ElementName = "bankState")]
        public string BankState { get; set; }
        [XmlElement(ElementName = "bankZip")]
        public string BankZip { get; set; }
        [XmlElement(ElementName = "bankTellerNumber")]
        public string BankTellerNumber { get; set; }
        [XmlElement(ElementName = "checkNumber")]
        public string CheckNumber { get; set; }
        [XmlElement(ElementName = "checkName")]
        public string CheckName { get; set; }
        [XmlElement(ElementName = "checkAddress1")]
        public string CheckAddress1 { get; set; }
        [XmlElement(ElementName = "checkAddress2")]
        public string CheckAddress2 { get; set; }
        [XmlElement(ElementName = "checkCity")]
        public string CheckCity { get; set; }
        [XmlElement(ElementName = "checkState")]
        public string CheckState { get; set; }
        [XmlElement(ElementName = "checkZip")]
        public string CheckZip { get; set; }
        [XmlElement(ElementName = "checkPhone")]
        public string CheckPhone { get; set; }
        [XmlElement(ElementName = "driverLicenseNumber")]
        public string DriverLicenseNumber { get; set; }
        [XmlElement(ElementName = "driverLicenseNumberState")]
        public string DriverLicenseNumberState { get; set; }
        [XmlElement(ElementName = "noDuplicateDetection")]
        public string NoDuplicateDetection { get; set; }
        [XmlElement(ElementName = "useCustomerAutoPayProfile")]
        public string UseCustomerAutoPayProfile { get; set; }
        [XmlElement(ElementName = "mtcn")]
        public string Mtcn { get; set; }
        [XmlElement(ElementName = "moneyOrderNumber")]
        public string MoneyOrderNumber { get; set; }
        [XmlElement(ElementName = "lookupPaymentFees")]
        public string LookupPaymentFees { get; set; }
        [XmlElement(ElementName = "suppressPaymentFees")]
        public string SuppressPaymentFees { get; set; }
        [XmlElement(ElementName = "paymentUnpostedID")]
        public string PaymentUnpostedID { get; set; }
        [XmlElement(ElementName = "skipReconnectionOrdering")]
        public string SkipReconnectionOrdering { get; set; }
        [XmlElement(ElementName = "processElectronicPayment")]
        public string ProcessElectronicPayment { get; set; }
        //[XmlElement(ElementName = "useCustomerAutoPayProfile")]
        //public string UseCustomerAutoPayProfile { get; set; }
        [XmlElement(ElementName = "addPaymentFeeToPayment")]
        public string AddPaymentFeeToPayment { get; set; }
        [XmlElement(ElementName = "originalReferenceNumber")]
        public string OriginalReferenceNumber { get; set; }
        [XmlElement(ElementName = "ccType")]
        public string CcType { get; set; }
        [XmlElement(ElementName = "ccTypeCode")]
        public string CcTypeCode { get; set; }
        [XmlElement(ElementName = "ccNumber")]
        public string CcNumber { get; set; }
        [XmlElement(ElementName = "ccHolderName")]
        public string CcHolderName { get; set; }
        [XmlElement(ElementName = "ccExp")]
        public string CcExp { get; set; }
        [XmlElement(ElementName = "ccCV")]
        public string CcCV { get; set; }
        [XmlElement(ElementName = "billingZip")]
        public string BillingZip { get; set; }
        [XmlElement(ElementName = "billingStreetAddress")]
        public string BillingStreetAddress { get; set; }
        [XmlElement(ElementName = "pinNumber")]
        public string PinNumber { get; set; }
        [XmlElement(ElementName = "buyAirTimeSkuID")]
        public string BuyAirTimeSkuID { get; set; }
        [XmlElement(ElementName = "mdn")]
        public string Mdn { get; set; }
        [XmlElement(ElementName = "buyInventorySkuID")]
        public string BuyInventorySkuID { get; set; }
        [XmlElement(ElementName = "changePlanId")]
        public string ChangePlanId { get; set; }
        [XmlElement(ElementName = "transactionDate")]
        public TransactionDateXml TransactionDate { get; set; }
        [XmlElement(ElementName = "dateOfBirth")]
        public DateOfBirthXml DateOfBirth { get; set; }
        [XmlElement(ElementName = "invoices")]
        public InvoicesXml Invoices { get; set; }
    }

    [XmlRoot("transactionDate")]
    public class TransactionDateXml
    {
        [XmlElement(ElementName = "year")]
        public string Year { get; set; }
        [XmlElement(ElementName = "month")]
        public string Month { get; set; }
        [XmlElement(ElementName = "day")]
        public string Day { get; set; }
    }

    [XmlRoot("dateOfBirth")]
    public class DateOfBirthXml
    {
        [XmlElement(ElementName = "year")]
        public string Year { get; set; }
        [XmlElement(ElementName = "month")]
        public string Month { get; set; }
        [XmlElement(ElementName = "day")]
        public string Day { get; set; }
    }

    [XmlRoot("invoices")]
    public class InvoicesXml
    {
        [XmlElement(ElementName = "invoice")]
        public InvoiceXml Invoice { get; set; }
    }

    [XmlRoot("invoice")]
    public class InvoiceXml
    {
        [XmlElement(ElementName = "invId")]
        public string InvId { get; set; }
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "appliedAmount")]
        public string AppliedAmount { get; set; }
    }
}
