
// A entrada de dados por parte do usuário é um tópico interessante. Pois Quase tudo
//Vem do console, e o C# trata tudo que vem do console como string.

Console.WriteLine("Olá, Digite seu nome: ");

//ReadLine() transforma tudo em string e Lê até o usuário digitar Enter
string nome = Console.ReadLine();

//Readkey() - Lê apenas um caractere e encerra a leitura.
Console.WriteLine($"Olá {nome}! Quer continuar? S/N");
ConsoleKeyInfo tecla = Console.ReadKey();

//Entrada para números inteiros:

//Para receber um valor inteiro, primeiro precisamos receber esse valor como
//string e converter o mesmo.

//Parse.

Console.WriteLine("Digite a sua idade:");







