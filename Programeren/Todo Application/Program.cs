//Starts the program with the following lines
Console.WriteLine("Hello!");
Console.WriteLine("Press [S] to see all Todo'S");
Console.WriteLine("Press [A] to add an additional Todo");
Console.WriteLine("Press [R] to remove a Todo");
Console.WriteLine("Press [E] to exit this application");

//reads line from console and assigns a value to the input
var userChoice = Console.ReadLine();

//Proceeds the application with the userInput variable
switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all Todo's");
        Console.WriteLine("You currently don't have any Todo on the list, if you would like to add one please select [A] in the selection menu!");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add an additional Todo");
        Console.WriteLine("What Todo would you like to add to the list?:");
        var userAddedTodo = Console.ReadLine();
        Console.WriteLine("The following Todo has been added to the list: " + userAddedTodo);
        break;
    case "R":
    case "r":
        PrintSelectedOption("remove a Todo");
        Console.WriteLine("You currently don't have any Todo's to remove please add one before you try to remove one.");
        break;
    case "E":
    case "e":
        PrintSelectedOption("exit this application");
        Console.WriteLine("Are you sure you want to exit this application?");
        Console.WriteLine("Press [Y] to confirm exit");
        Console.WriteLine("Press [N] to cancel");
        var userConfirmation = Console.ReadLine();

        if (userConfirmation == "Y")
        {
            Console.WriteLine("Exiting application now...");
        }
        else
        {
            Console.WriteLine("You canceled the exiting process");
        }
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}


Console.ReadKey(); // Prevents window from closing

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}

