using Static_Extention_Struct;
using Static_Extention_Struct.Extentions;

//Person.Name = "Kubra";

//Console.WriteLine(Person.Name);
//Person.Test();

//Person person = new Person();   
//Person person1 = new Person();
//Person person2 = new Person();
//Person person3 = new Person();

//Person.Test();

//Car car1  = new Car();
//Car car2 = new Car();

//Console.WriteLine(Car.count);

//Car car = new Car();

//int num = 50;

//int result = num.Sum(100);

//Console.WriteLine(result);

//string name = "Fidan55@";

//Console.WriteLine(name.CheckDigitOfString(@"\d"));
//Console.WriteLine(name.CheckDigitOfString(@"[A-Z]"));


//string name = null;

//Console.WriteLine(name);


// int? age = null;

//if(age == null)
//{
//    Console.WriteLine("Age not found");
//}



//Animal animal = new Animal();

//animal.GetAge(5);

//GetRole(1);
//static void GetRole(int roleId)
//{
//    if (roleId == (int)Roles.SuperAdmin)
//    {
//        Console.WriteLine("SuperAdmin");
//    }
//}

//CheckRole(2);

//foreach (var item in Enum.GetValues(typeof(Roles)))
//{
//    Console.WriteLine(item.ToString()); 
//}

//var result = HasRole("Admin");


//if (result)
//{
//    Console.WriteLine("Yes, We have this role");
//}
//else
//{
//    Console.WriteLine("No,We don't have this role");
//}

//Console.WriteLine(result);




//static bool HasRole(string role)
//{
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//            return true;
//        }

//    }
//    return false;
//}









//HasRole("Admin");



//static void HasRole(string role)
//{
//    bool hasrole = false;
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//        if (item.ToString() == role)
//        {
//           hasrole = true;
//        }
//    }
//    if (hasrole)
//    {
//        Console.WriteLine("Yes, We have this role");
//    }
//    else
//    {
//        Console.WriteLine("No,We don't have this role");
//    }
//} 










//static void HasRole(string role)
//{
//    foreach (var item in Enum.GetValues(typeof(Roles)))
//    {
//       if(item.ToString() == role)
//        {
//            Console.WriteLine("Yes,We have this role");
//            return;
//        }
//    }
//}




//static void CheckRole(int roleId)
//{
//    switch (roleId)
//    {
//        case (int)Roles.SuperAdmin:
//            Console.WriteLine("SuperAdmin");
//            break;
//        case (int)Roles.Admin:
//            Console.WriteLine("Admin");
//            break;
//        case (int)Roles.Member:
//            Console.WriteLine("Member");
//            break;
//        default:
//            Console.WriteLine("RoleId is wrong");
//            break;
//    }
//}






static string HasRole(string role)
{

    foreach (var item in Enum.GetValues(typeof(Roles)))
    {
        if (item.ToString() == role)
        {
            return "Yes, We have this role";
        }
    }
        return "No,We don't have this role";
    
}

Console.WriteLine(HasRole("Admin"));




