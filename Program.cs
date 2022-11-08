int n1, n2, resto;

Console.WriteLine("");
Console.WriteLine("Múltiplo");
Console.WriteLine("");

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Avaliar se é múltiplo de:  ");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2; 

if (resto == 0)
{ 
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n{n1} é múltiplo de {n2}");
    Console.ResetColor();
}

else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n{n1} não é múltiplo de {n2}");
    Console.ResetColor();
}
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine("\nObrigado por utilizar o programa!");
    Console.ResetColor();
