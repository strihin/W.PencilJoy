using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PencilJoy
{
    class DataBook
    {
        public string FirstName { get; set; }

        public int Birthmonth { get; set; }

        public int Birthday { get; set; }

        public bool GenderPerson { get; set; }
        public int CharacterPerson { get; set; }

        public DataBook()      {       }

        public DataBook(string FirstName, int Birthmonth, int Birthday, bool GenderPerson, int CharacterPerson)
        {
            this.FirstName = FirstName;
            this.Birthday = Birthday;
            this.Birthmonth = Birthmonth;
            this.GenderPerson = GenderPerson;
            this.CharacterPerson = CharacterPerson;
        }       
    }
}
