using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Cookout
{
    public class User
    {
        int userID;
        string firstName;
        string lastName;
        string email;
        string password;
        string imageURL;
        string phoneNumber;

        [JsonProperty(PropertyName = "userID")]
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [JsonProperty(PropertyName = "email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [JsonProperty(PropertyName = "password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [JsonProperty(PropertyName = "imageURL")]
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }

        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
