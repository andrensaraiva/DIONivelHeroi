// See https://aka.ms/new-console-template for more information
int nivel;
string nome;

Console.WriteLine("Digite o nome do Herói");
nome = Console.ReadLine();

Console.WriteLine("Digite a XP do Herói");
nivel = int.Parse(Console.ReadLine());

if (nivel <= 1000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de FERRO");
    return;
}
if (nivel > 1000 && nivel <= 2000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de BRONZE");
    return;
}
if (nivel > 2000 && nivel <= 5000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de PRATA");
    return;
}
if (nivel > 5000 && nivel <= 7000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de OURO");
    return;
}
if (nivel > 7000 && nivel <= 8000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de PLATINA");
    return;
}
if (nivel > 8000 && nivel <= 9000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de ASCENDENTE");
    return;
}
if (nivel > 9000 && nivel <= 10000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de IMORTAL");
    return;
}
if ( nivel > 10000)
{
    Console.WriteLine("O Herói de nome " + nome + " está no nível de RADIANTE");
    return;
}
