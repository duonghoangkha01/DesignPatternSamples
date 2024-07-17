namespace DesignPatternSamples.Behaviour.NullObjectPattern
{
    public class NullObjectTest
    {
        public static void Test()
        {
            var users = new List<User>()
            {
                new User(1, "Bob"),
                new User(2, "John")
            };

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    PrintUser(users, id);
                }
            }
        }

        public static void PrintUser(IEnumerable<User> users, int id)
        {
            var user = GetUser(users, id);
            Console.WriteLine("Hello " + user.Name);

            if (user.HasAccess())
            {
                Console.WriteLine("You have access");
            }
            else
            {
                Console.WriteLine("You are not allowed here");
            }
        }

        private static User GetUser(IEnumerable<User> users, int id)
        {
            var user = users.FirstOrDefault(user => user.Id == id);

            //We are now checking if the user is null before returning, and instead returning a NullUser object if the user is null.
            //This means that we no longer need to check for null users later in the code and can treat all users that are returned from this function the same whether they exist or not.

            if (user == null)
            {
                return new NullUser();
            }
            else
            {
                return user;
            }
        }
    }
}