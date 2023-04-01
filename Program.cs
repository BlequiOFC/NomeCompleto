Console.Clear();
string nome, sobrenome;

Console.WriteLine("Digite o seu primeiro nome.");
nome = Console.ReadLine()!;

Console.WriteLine("Digite o seu sobrenome.");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Seu nome completo é {nome} {sobrenome}");
Console.WriteLine($"Seu nome de catálogo é {sobrenome.ToUpper()} {nome}");