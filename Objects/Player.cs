using CSharpExamples.Interfaces;

namespace CSharpExamples.OOP
{
    public class Player : User, IPlayer
    {
        private string email;
        private string firstName;
        private string lastName;
        private Vector3 position = new Vector3(0,0,0);
        private string hidingInfo;
        private int age;

        public string Email
        {
            get { return email; }

        }

        public string FullName                                      // Property
        {
            get
            { return $"{firstName} {lastName}"; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FirstNameWithFirstLastCharacter
        {
            get { return GetFirstNameWithFirstCharacterOfLast(); }
        }

        public Player(int id, string email) : base(id)
        {

            this.email = email;
            hidingInfo = socialSecurity;
        }

        public Player(int id, string email, string firstName, string lastName) : base(id)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            hidingInfo = socialSecurity;
        }

        private string GetFirstNameWithFirstCharacterOfLast()
        {

            string firstCharacterOFLastName = string.Empty;
            if (!string.IsNullOrEmpty(lastName))
            {
                firstCharacterOFLastName = lastName[0].ToString();
            }


            return $"{firstName} {firstCharacterOFLastName} ";
        }

        
        public override void WhoAmI()
        {
            base.WhoAmI();
            Console.Write($"I am an (overrided in child class) user with email: {email}");
        }
        
        public void FindEnemiesInCloseProximity(int enemies = 3)
        {
            Console.WriteLine($"I found {enemies} enemires");
        }

        public bool MovePlayer(Vector3 newPosition)
        {
            position = newPosition;
            return true;
        }


    }


    public class XboxPlayer : IPlayer
    {
        public void FindEnemiesInCloseProximity(int enemies = 3)
        {
            Console.WriteLine("Find Enemies for Xbox");
        }

        public bool MovePlayer(Vector3 newPosition)
        {
            Console.WriteLine("");
            return true;
        }
    }
}
