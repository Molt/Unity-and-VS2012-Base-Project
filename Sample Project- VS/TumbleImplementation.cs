using UnityEngine;

namespace Sample_Project__VS
{
    public class TumbleImplementation
    {
        // Performs the actual tumble.
        public float Tumble(float originalAngle, float rotationRate, float deltaTime)
        {
            return (originalAngle + (rotationRate*deltaTime));
        }
    }
}
