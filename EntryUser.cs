using PointAndLine;

class EntryUser
{
    static void Main()
    {
        //here, before any instantiations existed
        //we can access our static variable
        System.Console.WriteLine(User.userCount);
        //this way it can be set becouse the standard constructor does not validate
        User user = new User("RobbieWilliams", "GreatToBeACat");
        System.Console.WriteLine(user.usernameData);
        System.Console.WriteLine(user.passwordData);
        System.Console.WriteLine(user.ID)
        //however when i call the data manipulation method, it is different
        User user2 = new User();
        user2.usernameData = "edd";
        user2.passwordData = "1234567";
        System.Console.WriteLine(user2.usernameData);
        System.Console.WriteLine(user2.passwordData);
        System.Console.WriteLine(user2.ID)

    }
}

/*

class User
{
    //static variables are higher level variables than regular ones,
    //they are declared before any instantiation of the class
    //it means that they are perfect to count things, eg.: userCount
    //by default ints are zero
    public static int userCount;

    //readonly means that the furthest it can be modified is the constructor
    //and it can only be assigned once
    public readonly int ID;
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
    static void Main()
    {
        //here, before any instantiations existed
        //we can access our static variable
        System.Console.WriteLine(User.userCount);
        //this way it can be set becouse the standard constructor does not validate
        User user = new User("RobbieWilliams", "GreatToBeACat");
        System.Console.WriteLine(user.usernameData);
        System.Console.WriteLine(user.passwordData);
        System.Console.WriteLine(user.ID);
        //however when i call the data manipulation method, it is different
        User user2 = new User();
        user2.usernameData = "edd";
        user2.passwordData = "1234567";
        System.Console.WriteLine(user2.usernameData);
        System.Console.WriteLine(user2.passwordData);
        System.Console.WriteLine(user2.ID);

    }
}

output is:
    0
    RobbieWilliams
    GreatToBeACat
    0
    The username length is does not meet the requirements.
    The password length is does not meet the requirements.


    1

*/