using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    [DataContract]
    class Person
    {
        private string _name = " ";
        private int _age = 0;
        private string _gender = " ";
        [DataMember]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

    }
}
