//Contar a letra "A"
Console.Write("Digite aqui: ");
string input = Console.ReadLine();

var result = CountLetterA(input);

Console.WriteLine($"Letra 'a' encontrada: {result.found}");
Console.WriteLine($"Quantidade de ocorrências: {result.count}");

static (bool found, int count) CountLetterA(string str)
{
    string lowerStr = str.ToLower();

    int count = lowerStr.Count(c => c == 'a');

    bool found = count > 0;

    return (found, count);
}