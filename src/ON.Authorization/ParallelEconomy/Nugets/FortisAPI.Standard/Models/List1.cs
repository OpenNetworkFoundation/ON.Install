// <copyright file="List1.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// List1.
    /// </summary>
    public class List1 : BaseModel
    {
        private string accountNumber;
        private string contactApiId;
        private string firstName;
        private string cellPhone;
        private double? balance;
        private string companyName;
        private string headerMessage;
        private string dateOfBirth;
        private string homePhone;
        private string officePhone;
        private string officePhoneExt;
        private Models.UpdateIfExistsEnum? updateIfExists;
        private string contactC1;
        private string contactC2;
        private string contactC3;
        private string parentId;
        private string email;
        private string createdUserId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "account_number", false },
            { "contact_api_id", false },
            { "first_name", false },
            { "cell_phone", false },
            { "balance", false },
            { "company_name", false },
            { "header_message", false },
            { "date_of_birth", false },
            { "home_phone", false },
            { "office_phone", false },
            { "office_phone_ext", false },
            { "update_if_exists", false },
            { "contact_c1", false },
            { "contact_c2", false },
            { "contact_c3", false },
            { "parent_id", false },
            { "email", false },
            { "created_user_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="List1"/> class.
        /// </summary>
        public List1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="List1"/> class.
        /// </summary>
        /// <param name="locationId">location_id.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="emailTrxReceipt">email_trx_receipt.</param>
        /// <param name="headerMessageType">header_message_type.</param>
        /// <param name="id">id.</param>
        /// <param name="createdTs">created_ts.</param>
        /// <param name="modifiedTs">modified_ts.</param>
        /// <param name="active">active.</param>
        /// <param name="accountNumber">account_number.</param>
        /// <param name="contactApiId">contact_api_id.</param>
        /// <param name="firstName">first_name.</param>
        /// <param name="cellPhone">cell_phone.</param>
        /// <param name="balance">balance.</param>
        /// <param name="address">address.</param>
        /// <param name="companyName">company_name.</param>
        /// <param name="headerMessage">header_message.</param>
        /// <param name="dateOfBirth">date_of_birth.</param>
        /// <param name="homePhone">home_phone.</param>
        /// <param name="officePhone">office_phone.</param>
        /// <param name="officePhoneExt">office_phone_ext.</param>
        /// <param name="updateIfExists">update_if_exists.</param>
        /// <param name="contactC1">contact_c1.</param>
        /// <param name="contactC2">contact_c2.</param>
        /// <param name="contactC3">contact_c3.</param>
        /// <param name="parentId">parent_id.</param>
        /// <param name="email">email.</param>
        /// <param name="createdUserId">created_user_id.</param>
        /// <param name="receivedEmails">received_emails.</param>
        /// <param name="isDeletable">is_deletable.</param>
        /// <param name="location">location.</param>
        /// <param name="user">user.</param>
        /// <param name="recurrings">recurrings.</param>
        /// <param name="emailBlacklist">email_blacklist.</param>
        /// <param name="smsBlacklist">sms_blacklist.</param>
        /// <param name="changelogs">changelogs.</param>
        /// <param name="postbackLogs">postback_logs.</param>
        /// <param name="createdUser">created_user.</param>
        /// <param name="parent">parent.</param>
        /// <param name="children">children.</param>
        public List1(
            string locationId,
            string lastName,
            bool emailTrxReceipt,
            int headerMessageType,
            string id,
            int createdTs,
            int modifiedTs,
            bool active,
            string accountNumber = null,
            string contactApiId = null,
            string firstName = null,
            string cellPhone = null,
            double? balance = null,
            Models.Address address = null,
            string companyName = null,
            string headerMessage = null,
            string dateOfBirth = null,
            string homePhone = null,
            string officePhone = null,
            string officePhoneExt = null,
            Models.UpdateIfExistsEnum? updateIfExists = null,
            string contactC1 = null,
            string contactC2 = null,
            string contactC3 = null,
            string parentId = null,
            string email = null,
            string createdUserId = null,
            List<Models.ReceivedEmail> receivedEmails = null,
            bool? isDeletable = null,
            Models.Location location = null,
            Models.User1 user = null,
            List<Models.Recurring> recurrings = null,
            Models.EmailBlacklist emailBlacklist = null,
            Models.SmsBlacklist smsBlacklist = null,
            List<Models.Changelog> changelogs = null,
            List<Models.PostbackLog> postbackLogs = null,
            Models.CreatedUser createdUser = null,
            Models.Parent parent = null,
            Models.Children children = null)
        {
            this.LocationId = locationId;
            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (contactApiId != null)
            {
                this.ContactApiId = contactApiId;
            }

            if (firstName != null)
            {
                this.FirstName = firstName;
            }

            this.LastName = lastName;
            if (cellPhone != null)
            {
                this.CellPhone = cellPhone;
            }

            if (balance != null)
            {
                this.Balance = balance;
            }

            this.Address = address;
            if (companyName != null)
            {
                this.CompanyName = companyName;
            }

            if (headerMessage != null)
            {
                this.HeaderMessage = headerMessage;
            }

            if (dateOfBirth != null)
            {
                this.DateOfBirth = dateOfBirth;
            }

            this.EmailTrxReceipt = emailTrxReceipt;
            if (homePhone != null)
            {
                this.HomePhone = homePhone;
            }

            if (officePhone != null)
            {
                this.OfficePhone = officePhone;
            }

            if (officePhoneExt != null)
            {
                this.OfficePhoneExt = officePhoneExt;
            }

            this.HeaderMessageType = headerMessageType;
            if (updateIfExists != null)
            {
                this.UpdateIfExists = updateIfExists;
            }

            if (contactC1 != null)
            {
                this.ContactC1 = contactC1;
            }

            if (contactC2 != null)
            {
                this.ContactC2 = contactC2;
            }

            if (contactC3 != null)
            {
                this.ContactC3 = contactC3;
            }

            if (parentId != null)
            {
                this.ParentId = parentId;
            }

            if (email != null)
            {
                this.Email = email;
            }

            this.Id = id;
            this.CreatedTs = createdTs;
            this.ModifiedTs = modifiedTs;
            this.Active = active;
            if (createdUserId != null)
            {
                this.CreatedUserId = createdUserId;
            }

            this.ReceivedEmails = receivedEmails;
            this.IsDeletable = isDeletable;
            this.Location = location;
            this.User = user;
            this.Recurrings = recurrings;
            this.EmailBlacklist = emailBlacklist;
            this.SmsBlacklist = smsBlacklist;
            this.Changelogs = changelogs;
            this.PostbackLogs = postbackLogs;
            this.CreatedUser = createdUser;
            this.Parent = parent;
            this.Children = children;
        }

        /// <summary>
        /// Location ID
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        /// <summary>
        /// Contact Account Number
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["account_number"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Contact API Id
        /// </summary>
        [JsonProperty("contact_api_id")]
        public string ContactApiId
        {
            get
            {
                return this.contactApiId;
            }

            set
            {
                this.shouldSerialize["contact_api_id"] = true;
                this.contactApiId = value;
            }
        }

        /// <summary>
        /// First Name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.shouldSerialize["first_name"] = true;
                this.firstName = value;
            }
        }

        /// <summary>
        /// Last Name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Cell phone of contact
        /// </summary>
        [JsonProperty("cell_phone")]
        public string CellPhone
        {
            get
            {
                return this.cellPhone;
            }

            set
            {
                this.shouldSerialize["cell_phone"] = true;
                this.cellPhone = value;
            }
        }

        /// <summary>
        /// Balance
        /// </summary>
        [JsonProperty("balance")]
        public double? Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.shouldSerialize["balance"] = true;
                this.balance = value;
            }
        }

        /// <summary>
        /// Address of contact
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                this.shouldSerialize["company_name"] = true;
                this.companyName = value;
            }
        }

        /// <summary>
        /// Header Message
        /// </summary>
        [JsonProperty("header_message")]
        public string HeaderMessage
        {
            get
            {
                return this.headerMessage;
            }

            set
            {
                this.shouldSerialize["header_message"] = true;
                this.headerMessage = value;
            }
        }

        /// <summary>
        /// Contacts DOB, Format: yyyy-MM-dd
        /// </summary>
        [JsonProperty("date_of_birth")]
        public string DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                this.shouldSerialize["date_of_birth"] = true;
                this.dateOfBirth = value;
            }
        }

        /// <summary>
        /// Whether or not to email all transactions receipts to contact (1 or 0)
        /// </summary>
        [JsonProperty("email_trx_receipt")]
        public bool EmailTrxReceipt { get; set; }

        /// <summary>
        /// Contacts home phone
        /// </summary>
        [JsonProperty("home_phone")]
        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }

            set
            {
                this.shouldSerialize["home_phone"] = true;
                this.homePhone = value;
            }
        }

        /// <summary>
        /// Contacts office phone
        /// </summary>
        [JsonProperty("office_phone")]
        public string OfficePhone
        {
            get
            {
                return this.officePhone;
            }

            set
            {
                this.shouldSerialize["office_phone"] = true;
                this.officePhone = value;
            }
        }

        /// <summary>
        /// Contacts office phone extension for office phone
        /// </summary>
        [JsonProperty("office_phone_ext")]
        public string OfficePhoneExt
        {
            get
            {
                return this.officePhoneExt;
            }

            set
            {
                this.shouldSerialize["office_phone_ext"] = true;
                this.officePhoneExt = value;
            }
        }

        /// <summary>
        /// Header Message Type
        /// </summary>
        [JsonProperty("header_message_type")]
        public int HeaderMessageType { get; set; }

        /// <summary>
        /// Update If Exists
        /// </summary>
        [JsonProperty("update_if_exists")]
        public Models.UpdateIfExistsEnum? UpdateIfExists
        {
            get
            {
                return this.updateIfExists;
            }

            set
            {
                this.shouldSerialize["update_if_exists"] = true;
                this.updateIfExists = value;
            }
        }

        /// <summary>
        /// Custom field 1 for api users to store custom data
        /// </summary>
        [JsonProperty("contact_c1")]
        public string ContactC1
        {
            get
            {
                return this.contactC1;
            }

            set
            {
                this.shouldSerialize["contact_c1"] = true;
                this.contactC1 = value;
            }
        }

        /// <summary>
        /// Custom field 2 for api users to store custom data
        /// </summary>
        [JsonProperty("contact_c2")]
        public string ContactC2
        {
            get
            {
                return this.contactC2;
            }

            set
            {
                this.shouldSerialize["contact_c2"] = true;
                this.contactC2 = value;
            }
        }

        /// <summary>
        /// Custom field 3 for api users to store custom data
        /// </summary>
        [JsonProperty("contact_c3")]
        public string ContactC3
        {
            get
            {
                return this.contactC3;
            }

            set
            {
                this.shouldSerialize["contact_c3"] = true;
                this.contactC3 = value;
            }
        }

        /// <summary>
        /// Parent Id
        /// </summary>
        [JsonProperty("parent_id")]
        public string ParentId
        {
            get
            {
                return this.parentId;
            }

            set
            {
                this.shouldSerialize["parent_id"] = true;
                this.parentId = value;
            }
        }

        /// <summary>
        /// Email of contact
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.shouldSerialize["email"] = true;
                this.email = value;
            }
        }

        /// <summary>
        /// Contact ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Created Time Stamp
        /// </summary>
        [JsonProperty("created_ts")]
        public int CreatedTs { get; set; }

        /// <summary>
        /// Modified Time Stamp
        /// </summary>
        [JsonProperty("modified_ts")]
        public int ModifiedTs { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// User ID Created the register
        /// </summary>
        [JsonProperty("created_user_id")]
        public string CreatedUserId
        {
            get
            {
                return this.createdUserId;
            }

            set
            {
                this.shouldSerialize["created_user_id"] = true;
                this.createdUserId = value;
            }
        }

        /// <summary>
        /// Received Email Information on `expand`
        /// </summary>
        [JsonProperty("received_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ReceivedEmail> ReceivedEmails { get; set; }

        /// <summary>
        /// Is Deletable Information on `expand`
        /// </summary>
        [JsonProperty("is_deletable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeletable { get; set; }

        /// <summary>
        /// Location Information on `expand`
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Location Location { get; set; }

        /// <summary>
        /// User Information on `expand`
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public Models.User1 User { get; set; }

        /// <summary>
        /// Recurring Information on `expand`
        /// </summary>
        [JsonProperty("recurrings", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Recurring> Recurrings { get; set; }

        /// <summary>
        /// Email Blacklist Information on `expand`
        /// </summary>
        [JsonProperty("email_blacklist", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EmailBlacklist EmailBlacklist { get; set; }

        /// <summary>
        /// Sms Blacklist Information on `expand`
        /// </summary>
        [JsonProperty("sms_blacklist", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SmsBlacklist SmsBlacklist { get; set; }

        /// <summary>
        /// Changelog Information on `expand`
        /// </summary>
        [JsonProperty("changelogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Changelog> Changelogs { get; set; }

        /// <summary>
        /// Postback Log Information on `expand`
        /// </summary>
        [JsonProperty("postback_logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PostbackLog> PostbackLogs { get; set; }

        /// <summary>
        /// User Information on `expand`
        /// </summary>
        [JsonProperty("created_user", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatedUser CreatedUser { get; set; }

        /// <summary>
        /// Parent Information on `expand`
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Parent Parent { get; set; }

        /// <summary>
        /// Children Information on `expand`
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Children Children { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"List1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["account_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactApiId()
        {
            this.shouldSerialize["contact_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFirstName()
        {
            this.shouldSerialize["first_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCellPhone()
        {
            this.shouldSerialize["cell_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBalance()
        {
            this.shouldSerialize["balance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompanyName()
        {
            this.shouldSerialize["company_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHeaderMessage()
        {
            this.shouldSerialize["header_message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateOfBirth()
        {
            this.shouldSerialize["date_of_birth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHomePhone()
        {
            this.shouldSerialize["home_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOfficePhone()
        {
            this.shouldSerialize["office_phone"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOfficePhoneExt()
        {
            this.shouldSerialize["office_phone_ext"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpdateIfExists()
        {
            this.shouldSerialize["update_if_exists"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactC1()
        {
            this.shouldSerialize["contact_c1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactC2()
        {
            this.shouldSerialize["contact_c2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactC3()
        {
            this.shouldSerialize["contact_c3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentId()
        {
            this.shouldSerialize["parent_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmail()
        {
            this.shouldSerialize["email"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreatedUserId()
        {
            this.shouldSerialize["created_user_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["account_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactApiId()
        {
            return this.shouldSerialize["contact_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFirstName()
        {
            return this.shouldSerialize["first_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCellPhone()
        {
            return this.shouldSerialize["cell_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBalance()
        {
            return this.shouldSerialize["balance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompanyName()
        {
            return this.shouldSerialize["company_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHeaderMessage()
        {
            return this.shouldSerialize["header_message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateOfBirth()
        {
            return this.shouldSerialize["date_of_birth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHomePhone()
        {
            return this.shouldSerialize["home_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOfficePhone()
        {
            return this.shouldSerialize["office_phone"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOfficePhoneExt()
        {
            return this.shouldSerialize["office_phone_ext"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdateIfExists()
        {
            return this.shouldSerialize["update_if_exists"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactC1()
        {
            return this.shouldSerialize["contact_c1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactC2()
        {
            return this.shouldSerialize["contact_c2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactC3()
        {
            return this.shouldSerialize["contact_c3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentId()
        {
            return this.shouldSerialize["parent_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmail()
        {
            return this.shouldSerialize["email"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreatedUserId()
        {
            return this.shouldSerialize["created_user_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is List1 other &&                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.ContactApiId == null && other.ContactApiId == null) || (this.ContactApiId?.Equals(other.ContactApiId) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.CellPhone == null && other.CellPhone == null) || (this.CellPhone?.Equals(other.CellPhone) == true)) &&
                ((this.Balance == null && other.Balance == null) || (this.Balance?.Equals(other.Balance) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
                ((this.HeaderMessage == null && other.HeaderMessage == null) || (this.HeaderMessage?.Equals(other.HeaderMessage) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                this.EmailTrxReceipt.Equals(other.EmailTrxReceipt) &&
                ((this.HomePhone == null && other.HomePhone == null) || (this.HomePhone?.Equals(other.HomePhone) == true)) &&
                ((this.OfficePhone == null && other.OfficePhone == null) || (this.OfficePhone?.Equals(other.OfficePhone) == true)) &&
                ((this.OfficePhoneExt == null && other.OfficePhoneExt == null) || (this.OfficePhoneExt?.Equals(other.OfficePhoneExt) == true)) &&
                this.HeaderMessageType.Equals(other.HeaderMessageType) &&
                ((this.UpdateIfExists == null && other.UpdateIfExists == null) || (this.UpdateIfExists?.Equals(other.UpdateIfExists) == true)) &&
                ((this.ContactC1 == null && other.ContactC1 == null) || (this.ContactC1?.Equals(other.ContactC1) == true)) &&
                ((this.ContactC2 == null && other.ContactC2 == null) || (this.ContactC2?.Equals(other.ContactC2) == true)) &&
                ((this.ContactC3 == null && other.ContactC3 == null) || (this.ContactC3?.Equals(other.ContactC3) == true)) &&
                ((this.ParentId == null && other.ParentId == null) || (this.ParentId?.Equals(other.ParentId) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.CreatedTs.Equals(other.CreatedTs) &&
                this.ModifiedTs.Equals(other.ModifiedTs) &&
                this.Active.Equals(other.Active) &&
                ((this.CreatedUserId == null && other.CreatedUserId == null) || (this.CreatedUserId?.Equals(other.CreatedUserId) == true)) &&
                ((this.ReceivedEmails == null && other.ReceivedEmails == null) || (this.ReceivedEmails?.Equals(other.ReceivedEmails) == true)) &&
                ((this.IsDeletable == null && other.IsDeletable == null) || (this.IsDeletable?.Equals(other.IsDeletable) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                ((this.Recurrings == null && other.Recurrings == null) || (this.Recurrings?.Equals(other.Recurrings) == true)) &&
                ((this.EmailBlacklist == null && other.EmailBlacklist == null) || (this.EmailBlacklist?.Equals(other.EmailBlacklist) == true)) &&
                ((this.SmsBlacklist == null && other.SmsBlacklist == null) || (this.SmsBlacklist?.Equals(other.SmsBlacklist) == true)) &&
                ((this.Changelogs == null && other.Changelogs == null) || (this.Changelogs?.Equals(other.Changelogs) == true)) &&
                ((this.PostbackLogs == null && other.PostbackLogs == null) || (this.PostbackLogs?.Equals(other.PostbackLogs) == true)) &&
                ((this.CreatedUser == null && other.CreatedUser == null) || (this.CreatedUser?.Equals(other.CreatedUser) == true)) &&
                ((this.Parent == null && other.Parent == null) || (this.Parent?.Equals(other.Parent) == true)) &&
                ((this.Children == null && other.Children == null) || (this.Children?.Equals(other.Children) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.ContactApiId = {(this.ContactApiId == null ? "null" : this.ContactApiId)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.CellPhone = {(this.CellPhone == null ? "null" : this.CellPhone)}");
            toStringOutput.Add($"this.Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName)}");
            toStringOutput.Add($"this.HeaderMessage = {(this.HeaderMessage == null ? "null" : this.HeaderMessage)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth)}");
            toStringOutput.Add($"this.EmailTrxReceipt = {this.EmailTrxReceipt}");
            toStringOutput.Add($"this.HomePhone = {(this.HomePhone == null ? "null" : this.HomePhone)}");
            toStringOutput.Add($"this.OfficePhone = {(this.OfficePhone == null ? "null" : this.OfficePhone)}");
            toStringOutput.Add($"this.OfficePhoneExt = {(this.OfficePhoneExt == null ? "null" : this.OfficePhoneExt)}");
            toStringOutput.Add($"this.HeaderMessageType = {this.HeaderMessageType}");
            toStringOutput.Add($"this.UpdateIfExists = {(this.UpdateIfExists == null ? "null" : this.UpdateIfExists.ToString())}");
            toStringOutput.Add($"this.ContactC1 = {(this.ContactC1 == null ? "null" : this.ContactC1)}");
            toStringOutput.Add($"this.ContactC2 = {(this.ContactC2 == null ? "null" : this.ContactC2)}");
            toStringOutput.Add($"this.ContactC3 = {(this.ContactC3 == null ? "null" : this.ContactC3)}");
            toStringOutput.Add($"this.ParentId = {(this.ParentId == null ? "null" : this.ParentId)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.CreatedTs = {this.CreatedTs}");
            toStringOutput.Add($"this.ModifiedTs = {this.ModifiedTs}");
            toStringOutput.Add($"this.Active = {this.Active}");
            toStringOutput.Add($"this.CreatedUserId = {(this.CreatedUserId == null ? "null" : this.CreatedUserId)}");
            toStringOutput.Add($"this.ReceivedEmails = {(this.ReceivedEmails == null ? "null" : $"[{string.Join(", ", this.ReceivedEmails)} ]")}");
            toStringOutput.Add($"this.IsDeletable = {(this.IsDeletable == null ? "null" : this.IsDeletable.ToString())}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
            toStringOutput.Add($"this.Recurrings = {(this.Recurrings == null ? "null" : $"[{string.Join(", ", this.Recurrings)} ]")}");
            toStringOutput.Add($"this.EmailBlacklist = {(this.EmailBlacklist == null ? "null" : this.EmailBlacklist.ToString())}");
            toStringOutput.Add($"this.SmsBlacklist = {(this.SmsBlacklist == null ? "null" : this.SmsBlacklist.ToString())}");
            toStringOutput.Add($"this.Changelogs = {(this.Changelogs == null ? "null" : $"[{string.Join(", ", this.Changelogs)} ]")}");
            toStringOutput.Add($"this.PostbackLogs = {(this.PostbackLogs == null ? "null" : $"[{string.Join(", ", this.PostbackLogs)} ]")}");
            toStringOutput.Add($"this.CreatedUser = {(this.CreatedUser == null ? "null" : this.CreatedUser.ToString())}");
            toStringOutput.Add($"this.Parent = {(this.Parent == null ? "null" : this.Parent.ToString())}");
            toStringOutput.Add($"this.Children = {(this.Children == null ? "null" : this.Children.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}