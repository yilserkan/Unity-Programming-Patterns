using NUnit.Framework;
using ProgrammingPatterns;
using UnityEngine;


public class BirdTest
{
    [Test]
    public void BirdStopsAtMaxHeight()
    {
        IBird bird = new MockBird() { MaxHeight = 3f, MinHeight = -3f};
        BirdController birdController = new BirdController(bird);
        birdController.Move(10f);
        Assert.AreEqual(bird.MaxHeight, bird.Position.y);
    }

    [Test]
    public void BirdStopsAtMinHeight()
    {
        IBird bird = new MockBird() {MaxHeight = 3f, MinHeight = -3f} ;
        BirdController birdController = new BirdController(bird);
        birdController.Move(-10);
        Assert.AreEqual(bird.MinHeight, bird.Position.y);
    }


}
