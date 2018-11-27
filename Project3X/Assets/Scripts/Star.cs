using UnityEngine;

namespace Project3X
{
    public class Star
    {
        private string starName;

        public Star(SolarSystem solarSystem, Transform parent = null)
        {
            starName = solarSystem.solarSystemName;

            GameObject empty = new GameObject();
            empty.name = starName;
            empty.transform.SetParent(parent);

            Debug.Log("Created star: " + starName);
        }
    }
}