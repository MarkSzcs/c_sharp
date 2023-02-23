namespace PointAndLine
{
    class User
    {
        //static variables are higher level variables than regular ones,
        //they are declared before any instantiation of the class
        //it means that they are perfect to count things, eg.: userCount
        //by default ints are zero
        public static int userCount;

        //constant variable's names should be all uppercase
        //readonly is a type of constant that means that the furthest it can be modified is the constructor
        //and it can only be assigned once
        public readonly int ID;
        //const is a type of constant that can only be defined at declaration and its value can only be assigned once
        public const string BLOODTYPE = "AB";
        private string username;
        private string password;

        public string passwordData
        {
            get
            {
                return password;
            }
            set
            {   
                if(value.Length > 8)
                {
                    password = value;
                } 
                else
                {
                    System.Console.WriteLine("The password length is does not meet the requirements.");
                }
            }
        }
        public string usernameData
        {
            get
            {
                return username;
            }
            set
            {
                if(value.Length > 3 && value.Length < 11)
                {
                    username = value;
                } 
                else
                {
                    System.Console.WriteLine("The username length is does not meet the requirements.");
                }
            }
        }
        //the incrementation of userCount would be in the same condition as the validation if there was one
        //so it represents the count of the actual users not the number of times the constructor was called 
        public User()
        {
            ID = ++userCount;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            ID = ++userCount;
        }
    } 
}
