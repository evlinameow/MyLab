using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    [DataContract]
    class Student : Person
    {
        public Student(string name, int age, string gender, string myGroup, string vuz, string special)
        {
            Name = name;
            Age = age;
            Gender = gender;
            MyGroup = myGroup;
            Vuz = vuz;
            Special = special;

        }
        // переменные
        private string _group = " ";
        private string _vuz = " ";
        private string _special = " ";
        // свойства
        [DataMember]
        public string MyGroup { get; set; }
        public string Vuz { get; set; }
        public string Special { get; set; }
    }
}
