using SneakerBox;
namespace SneakerBoxDL
{
    public class DataServices
    {
        List<Login> Users = new List<Login>();

        public DataServices()
        {
            CreateData();
        }
        private void CreateData()
        {

            Login user1 = new Login { username = "Liam", password = "Pogi" };
            Login user2 = new Login { username = "Edwards", password = "MahalKita" };

            Users.Add(user1);
            Users.Add(user2);

        }

        public Login GetUser(string username, string password)
        {
            Login foundUser = new Login();
            foreach (var user in Users)
            {
                if (user.username == username && password == user.password)
                {
                    foundUser = user;
                }
            }

            return foundUser;
        }
    }
}