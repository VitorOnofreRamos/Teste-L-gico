//Número de Fibonacci
Console.Write("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool resultado = VerificarFibonacci(numero);

Console.WriteLine($"O número {numero} {(resultado ? "pertence" : "não pertence")} à sequência de Fibonacci.");

static bool VerificarFibonacci(int numero)
{
    int a = 0;
    int b = 1;

    if (numero == a || numero == b) return true;

    int proximo = a + b;

    while (proximo <= numero)
    {
        if (proximo == numero) return true;

        a = b;
        b = proximo;
        proximo = a + b;
    }

    return false;
}
