using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demmo_OOP_02.Encapsulation
{
    internal struct PhoneNotebook
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
                //وصلت لغاية دلوقتي  لدقيقة ب17:56
            }
            return 5;
        }
        #endregion
    }
}