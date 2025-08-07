using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demmo_OOP_02.Encapsulation
{
    internal struct Emolyee
    {
        #region Attributes
        public int Id;
        private string? Name;
        private decimal salary;
        private decimal deduction;//Derived Attribute
        #endregion

        //Encapsulation
        //Separate Data Definition [Attributes] From Its Use [Getter Setter,Property]
        //1.Attribute Private
        //2.Apply Encapsulation [Getter Setter Approach]

        #region  01 Applying Encapsulation Using Old Approach Getter Setter
        //Getter
        public string? GetName()
        {
            return Name;
        }
        //Setter
        public void SetName(string? name)
        {

            Name = name?.Length > 10 ? name.Substring(0, 10) : name;
        }
        #endregion

        #region 02 Applying Encapsulation Using new Approach Property
        //Using This Aproach is more recomended => Easy to use similar to attribute
        //1.1 Full Proerty
        public decimal Salary
        {
            get { return salary; }
            set { salary = value < 10000 ? 10000 : value; }
        }
        //1.2Automatic Property
        public int Age { get; set; }
        //Compilier Will Generate Backing Field"Private Hidden Attribute"
        public decimal Deduction
        {
            get { return Salary * 0.1M; }
            //Read Only Property
        }
        //Code Snippet Property
        //Prop
        //PropFull
        #endregion

        #region Constructors
        public Emolyee(int id, string? name, decimal salary, int age)//ctrl+.
        {
            Id = id;
            Name = name;
            Salary = salary;
            Age = age;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"ID={Id}\n,Name={Name}\n,Salary={Salary:c},\nAge={Age}";
        }
        #endregion
    }
}
