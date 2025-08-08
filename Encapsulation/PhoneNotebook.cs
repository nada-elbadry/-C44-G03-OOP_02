using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Demmo_OOP_02.Encapsulation
{
    internal struct PhoneNotebook:IEnumerable
    {
        #region Attributes
        private string[]? names;
        private int[]? numbers;
        private int size;
        #endregion

        #region Constructor
        public PhoneNotebook(int noteSize)
        {
            size = noteSize;
            names = new string[size];
            numbers = new int[size];
        }
        #endregion

        #region Properties

        public int Size
        {
            get { return size; }
            //Read Only Prop
        }

        #endregion

        #region Methods
        public void AddPerson(int postion, string name, int number)
        {
            if (names is not null && numbers is not null)
            {
                if (postion < size && postion >= 0)
                {
                    names[postion] = name;
                    numbers[postion] = number;
                }
            }
        }
        #endregion

        #region Getter Setter
        //Getter
        public int GetNumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
            }
            return -1;
        }
        //Setter
        public void SetNumbers(string name, int newnumber)
        {
            if (numbers is not null && names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = newnumber;

                    }
                    break;
                    //return;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }


        #endregion


        #region Indexer
        //Is A Special Property [Named With Keyword This]
        //Can Take Parametr

        public int this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == name)
                            return numbers[i];
                return -1;
            }
            set
            {
                if (numbers is not null && names is not null)
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == name)
                            numbers[i] = value;
                return;
                //return;
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Page = {index+1} :: Name {names[index]} :: Number = {numbers[index]} ";

            }

        }
        #endregion
    }
}
