using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBPManilaMobile.Model
{
    public class Business
    {
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get;
            set;
        }

        public string BusinessName
        {
            get;
            set;
        }

        public string BusinessDescription
        {
            get;
            set;
        }

        public string BusinessAddress
        {
            get;
            set;
        }

        public string BusinessHours
        {
            get;
            set;
        }

        public string ContactNumbers
        {
            get;
            set;
        }

        public string Website
        {
            get;
            set;
        }

        public string Facebook
        {
            get;
            set;
        }

        public string Instagram
        {
            get;
            set;
        }

        public string Requirement
        {
            get;
            set;
        }

        public string Category
        {
            get;
            set;
        }

        public string Municipal
        {
            get;
            set;
        }

    }
}
