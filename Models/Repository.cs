namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users= new();

        static Repository()
        {
            _users.Add(new UserInfo() {
                Id = 1,
                Name="Süphan",
                Email="yakutsuphan@gmail.com",
                Phone="05325478545",
                WillAttend=true

            });

            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Mehmet",
                Email = "yakutmehmet@gmail.com",
                Phone = "05325478545",
                WillAttend = true

            });

            _users.Add(new UserInfo()
            {
                Id=3,
                Name = "Ayşe",
                Email = "ayşe@gmail.com",
                Phone = "05325478545",
                WillAttend = false

            });
        }

        public static List<UserInfo> Users { get {  return _users; } }

        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetUserById(int id)
        {
            return _users.FirstOrDefault(i => i.Id == id);
        }

    }
}
