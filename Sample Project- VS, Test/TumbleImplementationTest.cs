using UnityEngine;

namespace Sample_Project__VS__Test
{
    using NUnit.Framework;
    using Sample_Project__VS;

    [TestFixture]
    public class TumbleImplementationTest
    {
        [Test]
        public void NoRotationForZeroDeltaTime()
        {
            // Construct the tumbleImplementation, tumble the rotation
            var tumbleImplmentation = new TumbleImplementation();
            var time = 0.0f;
            var finalRotation = tumbleImplmentation.Tumble(0, 0, time);
            // Check the rotation is what we expect
            Assert.AreEqual(0, finalRotation, 0.01, "X rotation is correct");
        }

        [Test]
        public void RotatesCorrectlyOverTime()
        {
            // Construct the tumbleImplementation, tumble the rotation
            var tumbleImplmentation = new TumbleImplementation();
            var time = 10.0f;
            var finalRotationX = tumbleImplmentation.Tumble(0, 10, time);
            var finalRotationY = tumbleImplmentation.Tumble(0, 20, time);
            var finalRotationZ = tumbleImplmentation.Tumble(0, 30, time);
            // Check the rotation is what we expect
            Assert.AreEqual(100, finalRotationX, 1.0, "X rotation is correct");
            Assert.AreEqual(200, finalRotationY, 1.0, "Y rotation is correct");
            Assert.AreEqual(300, finalRotationZ, 1.0, "Z rotation is correct");
        }
    }
}
