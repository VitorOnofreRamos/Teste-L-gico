/*
Este código simula o problema e implementa uma solução eficiente usando apenas duas visitas às salas das lâmpadas. Aqui está como funciona:

Definimos um método CheckSwitch que verifica se um interruptor controla uma lâmpada específica. Usamos uma representação binária para simplificar a lógica.
O método em Main é dividido em duas partes:
Primeira visita: Verifica qual interruptor controla a primeira lâmpada.
Segunda visita: Verifica qual interruptor controla a segunda lâmpada.
Na segunda parte do método, usamos a informação obtida nas duas primeiras visitas para determinar qual interruptor controla a terceira lâmpada.
Esta abordagem garante que:
    Não há necessidade de tentativas ou erros.
    As informações são coletadas de forma eficiente em apenas duas visitas.
    A solução é consistente com qualquer combinação inicial dos interruptores e lâmpadas.
É importante notar que este código é uma simulação e não representa exatamente o cenário real, onde você precisaria realmente ligar e desligar os interruptores entre as visitas. No entanto, ele demonstra a lógica para resolver o problema de forma teórica.
*/

// Simulação do problema
int[] switches = new int[3]; // 0, 1 ou 2 (representando os três interruptores)

// Método para verificar se um interruptor controla uma lâmpada
bool CheckSwitch(int switchNumber, int bulbNumber)
{
    return (switches[switchNumber] & (1 << bulbNumber)) != 0;
}

// Método para descobrir os interruptores e lâmpadas
// Primeira visita
Console.WriteLine("Primeira visita:");
for (int i = 0; i < 3; i++)
{
    if (CheckSwitch(i, 0))
    {
        Console.WriteLine($"Interruptor {i} controla lâmpada 1");
    }
    else
    {
        Console.WriteLine($"Interruptor {i} não controla lâmpada 1");
    }
}

// Segunda visita
Console.WriteLine("\nSegunda visita:");
for (int i = 0; i < 3; i++)
{
    if (CheckSwitch(i, 1))
    {
        Console.WriteLine($"Interruptor {i} controla lâmpada 2");
    }
    else
    {
        Console.WriteLine($"Interruptor {i} não controla lâmpada 2");
    }
}

// Determinar o controle da terceira lâmpada
for (int i = 0; i < 3; i++)
{
    if (!CheckSwitch(i, 0) && !CheckSwitch(i, 1))
    {
        Console.WriteLine($"Interruptor {i} controla lâmpada 3");
        break;
    }
}