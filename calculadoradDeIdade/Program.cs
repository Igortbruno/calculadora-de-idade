Console.WriteLine("DIgite o seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}!");

Console.WriteLine("Digite o ano que você nasceu: ");
int year = int.Parse(Console.ReadLine());
int age = 2026 - year;
Console.WriteLine($"Você tem {age} anos.");

if (age > 17)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}