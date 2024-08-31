int[] seqA = { 1, 3, 5, 7 };
Console.WriteLine($"a) {NextElementInSequence(seqA)}");

int[] seqB = { 2, 4, 8, 16, 32, 64 };
Console.WriteLine($"b) {NextPowerOfTwo(seqB[seqB.Length - 1])}");

int[] seqC = { 0, 1, 4, 9, 16, 25, 36 };
Console.WriteLine($"c) {NextSquare(seqC)}");

int[] seqD = { 4, 16, 36, 64 };
Console.WriteLine($"d) {NextSquare(seqD)}");

int[] seqE = { 1, 1, 2, 3, 5, 8 };
Console.WriteLine($"e) {NextFibonacci(seqE)}");

int[] seqF = { 2, 10, 12, 16, 17, 18, 19 };
Console.WriteLine($"f) {NextElementInSequence(seqF)}");

static int NextElementInSequence(int[] sequence)
{
    return sequence[sequence.Length - 1] + (sequence[sequence.Length - 1] - sequence[sequence.Length - 2]);
}

static int NextPowerOfTwo(int n)
{
    return n * 2;
}

static int NextSquare(int[] sequence)
{
    int nextIndex = (int)Math.Sqrt(sequence[sequence.Length - 1]) + 1;
    return nextIndex * nextIndex;
}

static int NextFibonacci(int[] sequence)
{
    return sequence[sequence.Length - 1] + sequence[sequence.Length - 2];
}