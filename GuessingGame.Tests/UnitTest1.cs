using System.Numerics;
using GuessingGame;
using NSubstitute;
using GuessingGame.Generators;
namespace GuessingGame.Tests;

public class UnitTest1
{
    [Fact]
    public void GetResult_found()
    {

        int minRange = 4;
        int maxRange = 5;
        int guessNumber = 3;
        INumberGenerator numberGenerator = Substitute.For<INumberGenerator>();
        numberGenerator.Generate(minRange, maxRange).Returns(guessNumber);
        Service service = new Service(numberGenerator);
        string result=service.GetResult(minRange,maxRange,6);

    }
}
