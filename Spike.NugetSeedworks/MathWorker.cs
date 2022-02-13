namespace Spike.NugetSeedworks;

public static class MathWorker
{
    public static int Sum(this int original, int additionNumber)
    {
        return original + additionNumber;
    }

    public static int Substract(this int original, int subtractNumber)
    {
        return original - subtractNumber;
    }

    public static decimal Devide(this decimal original, int divideNumber)
    {
        return original / divideNumber;
    }

    public static decimal Multiply(this decimal original, int multiplicationNumber)
    {
        return original / multiplicationNumber;
    }
}
