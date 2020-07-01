using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace tut2
{
    class Student
    {
        [XmlAttribute(AttributeName = "idStudent")]
        public string IdStudent { get; set; }

        [XmlElement(ElementName = "firstName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lastName")]
        public string FastName { get; set; }

        [XmlElement(ElementName = "studies")]
        public Study Department { get; set; }
        public Study Mode { get; set; }
      
        public string BirthDay { get; set; }
        public string Email { get; set; }
        public string MotherFirstName { get; set; }
        public string FatherFirstName { get; set; }

        
    }
}
