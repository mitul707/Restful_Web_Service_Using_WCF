using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace StudentPortalService
{    
    public class Student
    {
        private string s_studId;
        private string s_firstName;
        private string s_lastName;
        private string s_contact;
        private string s_address;        
        private byte[] b_image;
        private string s_email;
        private string s_gender;

        public string StudentId
        {
            get
            {
                return s_studId;
            }
            set 
            { 
                s_studId = value; 
            }
        }
        public string FirstName 
        {
            get
            {
                return s_firstName;
            }
            set
            {
                s_firstName = value;
            }
        }
        public string LastName 
        {
            get
            {
                return s_lastName;
            }
            set
            {
                s_lastName = value;
            }
        }

        public string Contact
        {
            get
            {
                return s_contact;
            }
            set
            {
                s_contact = value;
            }
        }

        public string Address
        {
            get
            {
                return s_address;
            }
            set
            {
                s_address = value;
            }
        }

        public byte[] Image
        {
            get
            {
                return b_image;
            }
            set
            {
                b_image = value;
            }
        }

        public string Email
        {
            get
            {
                return s_email;
            }
            set
            {
                s_email = value;
            }
        }

        public string Gender
        {
            get
            {
                return s_gender;
            }
            set
            {
                s_gender = value;
            }
        }
    }
}
