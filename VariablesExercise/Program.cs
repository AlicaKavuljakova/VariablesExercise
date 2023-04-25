// See https://aka.ms/new-console-template for more information




Console.WriteLine("What`s your dog's name?");
string dogName =Console.ReadLine();
Console.WriteLine("Where does your dog live?");
string livesAt = Console.ReadLine();
Console.WriteLine("How old is your dog?");
int dogAge =int.Parse(Console.ReadLine());
Console.WriteLine("Is your dog a German Shepherd, true or false?");
bool isGermanShepherd = bool.Parse(Console.ReadLine());
Console.WriteLine("What letter does your name start with?");
char letter = char.Parse(Console.ReadLine());
Console.WriteLine("How much change is in your pocket?");   
  
double changeInPocket= double.Parse(Console.ReadLine());
decimal pi = 3.14159m;
Console.WriteLine( $"There once was a dog named {dogName.ToUpper()}. This dog lived in {livesAt.ToUpper()}. It's {isGermanShepherd} that the dog was German Shepherd. The dog's age was {dogAge}.");
Console.WriteLine("Your name starts with letter " + letter + " .");
Console.WriteLine($"You have ${changeInPocket}  money in your pocket. Value of pi is {pi}");


