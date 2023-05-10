namespace CSharpExamples.OOP
{
    public class User
    {
        private int id;

        public int Id{ get { return id; }}

        protected string socialSecurity;

        public User(int id) 
        {
            this.id = id;
            socialSecurity = Guid.NewGuid().ToString();             // Create a unique 128-bit numeric value (32-digit string)
        } 

        public virtual void WhoAmI()
        {
            Console.WriteLine($"I am an Parent user with id: {id}");
        }
    }
}
