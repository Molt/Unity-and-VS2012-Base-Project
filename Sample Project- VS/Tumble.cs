using UnityEngine;

namespace Sample_Project__VS
{
    public class Tumble : MonoBehaviour
    {
        public Vector3 RotationRates;
        private TumbleImplementation implementation = new TumbleImplementation();

        // Use this for initialization
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            var rotation = gameObject.transform.rotation.eulerAngles;
            var deltaTime = Time.deltaTime;

            gameObject.transform.Rotate(
                implementation.Tumble(rotation.x, RotationRates.x, deltaTime),  
                implementation.Tumble(rotation.y, RotationRates.y, deltaTime),
                implementation.Tumble(rotation.z, RotationRates.z, deltaTime)
            );
        }
    }
}
