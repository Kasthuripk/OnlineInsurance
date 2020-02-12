using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineInsurance
{
    public class UserEntity
    {
        public string customerName { get; set; }
        public int policyNumber { get; set; }
        public long phoneNumber { get; set; }
        public string dateOfBirth { get; set; }
        public string mailId { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public UserEntity(string customerName, int policyNumber, long phoneNumber, string dateOfBirth, string mailId, string password, string role)
        {
            this.customerName = customerName;
            this.policyNumber = policyNumber;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.mailId = mailId;
            this.password = password;
            this.role = role;
        }

        public UserEntity(string mailId, string password)
        {
            this.mailId = mailId;
            this.password = password;
        }

        public UserEntity()
        {
        }

        public override string ToString()
        {
            return customerName + " " + policyNumber + " " + phoneNumber + " " + dateOfBirth + " "+ dateOfBirth +" " + mailId+" " + mailId+ " " + role;
        }


    }
}