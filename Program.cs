Console.Clear();

int valor = -1;

Console.WriteLine("--- Entrada Válida ---");

while(valor < 0 || valor > 9 )
{
    Console.Write("Digite um valor entre 1 e 9 (0 para cancelar): ");
    valor = Convert.ToInt32(Console.ReadLine());
}

if (valor == 0)
{
    Console.WriteLine($"Operação cancelada.");
}

else
{
    Console.WriteLine($"\nO número escolhido foi {valor}.");
}


