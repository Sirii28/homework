{

    Console.WriteLine("Enter your name:");
    string name = Console.ReadLine() ?? "";

   // if (name == null)
     //   name = "";
    
    switch(name)  
    {
       case "Irada":
            Console.WriteLine("Your name is Irada");
            break;
        default:
            Console.WriteLine("Wrong");
            break;
    }

    Console.WriteLine("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age >= 18) 
    Console.WriteLine("Ok");

    else if (age == 18)
        Console.WriteLine("Almost Ok");

    else
        Console.WriteLine("Wrong");

    Console.WriteLine("enter your weight");

    double weight = Convert.ToDouble(Console.ReadLine());

    if (weight > 60)
        Console.WriteLine("you dont fit us");

    else if (weight >= 60)
        Console.WriteLine("ok");

    else if (weight < 60)
        Console.WriteLine("ok");

    else
    
        Console.WriteLine("you dont fit us");
        
    Console.WriteLine("if you have more than 2 correct answers, you are accepted");
    int answer = Convert.ToInt32(Console.ReadLine());

    if (answer >= 2)
        Console.WriteLine("you are accepted");
    else if (answer <= 3)
        Console.WriteLine("You are not accepted");

    Console.WriteLine("Adress is: Mederova 123");



    
       





    

    



        



}