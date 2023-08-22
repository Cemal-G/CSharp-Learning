using System.ComponentModel;
using System.Runtime.InteropServices;
// de command Console.WriteLine("") wordt gebruikt om zinnen te schrijven in de CMD. maar je kunt dit ook gebruiken in apps zoals Unity maar daaar kom je zelf wel achter
Console.WriteLine("Hello!"); // dus dit zorgt ervoor dat in je CMD scherm "Hello!" wordt geschreven
Console.WriteLine("Input the first number please:");
var userInput = Console.ReadLine(); //  userInput is een variable die ik zelf zo heb genoemd (ddit kan je dus veranderen naar wat je ook wilt (zorg dat je het overal dan hernoemd)) Console.ReadLine() is eigenlijk simpelweg een command dat ervoor zorgt dat de gebruiker kan typen. de script gaat dan na wat de gebruik heeft geschreven
int numberOne = int.Parse(userInput); // als je wat schrijft in cmd is dat altijd de variable "string" dit betekent dat het letters/woorden/zinnen zijn maar ik wil het een getal maken want met woorden kan je niet rekenen DUS veranderen we de string (het woord (getal dat gebruiker schreef dus bijv 6)) naar een "int" (getal) hiermee kan je wel rekenen later meer over.

Console.WriteLine("Input the second number please:"); //hetzelfde als hierboven
var secondUserInput = Console.ReadLine();
int numberTwo = int.Parse(secondUserInput);

Console.WriteLine("What would you like to do with these numbers?:"); //alweer geweeon gebruik gemaakt van cmd die dingen schrijft
Console.WriteLine("Press [A] to add the two nubmers");
Console.WriteLine("Press [S] to subtact the two nubmers");
Console.WriteLine("Press [M] to multiply the two nubmers");

var choice = Console.ReadLine(); // cmd leest het antwoord van de gebruiker

//hier word het interessant ik maak hier if / else statements om blokken codes (genaamd scopes) te maken voor ieder variable (a / s / m) AKA ervoor zorgen dat als je A S of M typt als gebruiker je een ander pad krijgt en dus andere opties
if (EqualCaseInsensitive(choice, "A")) // EqualCaseInsensitive is een void method (een functie ) die ik later in de code heb geschreven meer daat later over
{
    Console.WriteLine("Adding the two numbers will result in the following:");
    var result = numberOne + numberTwo; // result (wat de cmd uiteindelijk schrijft is variable numberOne + numberTwo als we den ínt.parse method niet deden krijgen we het volgende: stel de gekozen getallen waren 5 en 10 dan zou je krijgen (het woord 5) + (het woord 10) dus 510 met int.parse zijn het getallen dus (het getal 5) + (het getal 10) = 15
    PrintFinalEquation(numberOne, numberTwo, result, "+"); // PrintFinalEquation is een void method (een functie ) die ik later in de code heb geschreven meer daat later over
}

else if (EqualCaseInsensitive(choice, "S"))
{
    Console.WriteLine("Subtracting the two numbers will result in the following:");
    var result = numberOne - numberTwo;
    PrintFinalEquation(numberOne, numberTwo, result, "-");
}

else if (EqualCaseInsensitive(choice, "M"))
{
    Console.WriteLine("Multiplying the two numbers will result in:");
    var result = numberOne * numberTwo;
    PrintFinalEquation(numberOne, numberTwo, result, "X");
}
else
{
    Console.WriteLine("Invalid choice!");
}


Console.WriteLine("Press any key to close this application");
Console.ReadKey(); // zorg ervoor dat de applicatie niet sluit als alles gedaan is (want anders zou het sneller sluiten dan het laatse zou kunnen lezen deze command zorgt ervoor dat de gebruiker een toets (maakt niet uit welke) moet indrukken om de script te sluiten


// dit is een beetje lastig maar in het kort heb ik deze functie/method geschreven om duplicatie te vermijde maar dit is niet iets wat je hoeft te kennen
void PrintFinalEquation(
    int numberOne, int numberTwo, int result, string @operator)
{
    Console.WriteLine(numberOne + " " + @operator + " " + numberTwo + " = " + result);
}

bool EqualCaseInsensitive(string left, string right) // zorgt ervoor dat het niet uitmaakt of je "a" of "A" schrijft in cmd dit had ook gekunt zonder functie zoals hier benede:
{
    return left.ToUpper() == right.ToUpper();
}


/* if (case == "a" || case == "A") dit doe ik niet want met deze functie vermijd ik duplicatie en is het script makkelijker te lezen
 * de rest van je code */