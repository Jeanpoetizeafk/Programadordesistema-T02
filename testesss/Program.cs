Console.WriteLine("Escolha uma opção de pagamento: 1 - Pix; 2- Débito ou 3 - Crédito");
int pagamento = int.Parse(Console.ReadLine());
switch (pagamento)
{
    case 1:
        Console.WriteLine("Pagar com pix");
        break;

    case 2:
        Console.WriteLine("Pagar com débito");
        break;

    case 3:
        Console.WriteLine("Pagar com crédito");
        break;

    default:
        break;
}

int b = 50;
while (b >= 2)
{
    Console.WriteLine(b);
    b--;
}

List<object> dados = new List<object>
{ "ana",
  "brasil",
  "Ana Cunha",
  "Jabaquara",
   18,
};
foreach (var d in dados)
    Console.WriteLine(d);

// Declarando uma matriz 3 linhas por 2 colunas
int[,] matriz = new int[3, 2]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 }
};
