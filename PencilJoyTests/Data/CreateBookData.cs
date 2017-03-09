namespace PencilJoyTests.Data
{
    class CreateBookData
    {
        internal string Username { get; set; }
        internal int NumberMonth { get; set; }
        internal int NumberDay { get; set; }
        internal string SelectorForCharacterPerson { get; set; }
        private int numberSex;
        internal int NumberSex
        {
            get
            {
                return numberSex;
            }
            set
            {
                switch (value)
                {
                    case 0:
                        numberSex = 2;
                        SelectorForCharacterPerson = "#select-girl";
                        break;

                    case 1:
                        numberSex = 1;
                        SelectorForCharacterPerson = "#select-boy";
                        break;

                    default:
                        numberSex = -1;
                        break;
                }
            }
        }
        internal int NumberCharacter { get; set; }
        public CreateBookData(string username, int numberMonth, int numberDay, int numberSex, int numberCharacter)
        {
            Username = username;
            NumberMonth = numberMonth;
            NumberDay = numberDay;
            NumberSex = numberSex;
            NumberCharacter = numberCharacter;
        }
    }
}
