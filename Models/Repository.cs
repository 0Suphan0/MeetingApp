namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users= new();

        static Repository()
        {
            _users.Add(new UserInfo() {
            
                Name="Süphan",
                Email="yakutsuphan@gmail.com",
                Phone="05325478545",
                WillAttend=true

            });

            _users.Add(new UserInfo()
            {

                Name = "Mehmet",
                Email = "yakutmehmet@gmail.com",
                Phone = "05325478545",
                WillAttend = true

            });

            _users.Add(new UserInfo()
            {

                Name = "Ayşe",
                Email = "ayşe@gmail.com",
                Phone = "05325478545",
                WillAttend = false

            });
        }

        public static List<UserInfo> Users { get {  return _users; } }

        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }

    }
}
