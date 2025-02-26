using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusTrackerCode
{
    public class PersonalInfo
    {
        Form4 f4 = new Form4();
        int PatientID;
        int age;
        bool gender;
        string country;

        public PersonalInfo()
        {
            setPatientID();
            setAge();
            setGender(); setCountry();
        }

        public void setPatientID()
        {
            PatientID = f4.getID();
        }
        public void setAge()
        {
            age = f4.getAge();
        }
        public void setGender()
        {
            gender = f4.getGender();
        }
        public void setCountry()
        {
            country = f4.getCountry();
        }
    }
}
