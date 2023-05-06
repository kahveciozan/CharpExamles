
namespace CSharpExamples.OOP
{
    public class Player
    {
        private User user;
        private string email;
        private string firstName;
        private string lastName;
        private Vector3 position = new Vector3(0,0,0);


        public int UserId
        {
            get { return user.Id;}
        }


        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public string FirstNameWithFirstLastCharacter
        {
            get
            {
                return GetFirstNameWithFirstCharacterOfLast();
            }
        }

        public Player(int id, string email)
        {
            user = new User(id);
            this.email = email;
        }

        public Player(int id, string email, string firstName, string lastName)
        {
            user = new User(id);
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
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

        internal void FindEnemiesInCloseProximity(int enemies = 3)
        {
            Console.WriteLine($"I found {enemies} enemires");
        }

        public bool MovePlayer(Vector3 newPosition)
        {
            position = newPosition;

            return true;
        }
    }
}
