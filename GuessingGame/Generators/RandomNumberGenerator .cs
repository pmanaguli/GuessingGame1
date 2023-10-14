namespace GuessingGame.Generators;
public sealed class RandomNumberGenerator : INumberGenerator
{
    public int Generate(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
