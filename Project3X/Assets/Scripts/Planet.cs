using UnityEngine;

namespace Project3X
{
    public class Planet
    {
        public string planetName { get; private set; }
        
        public Planet(SolarSystem solarSystem, int number, Transform parent = null)
        {
            planetName = solarSystem.solarSystemName + " " + number;

            GameObject empty = new GameObject();
            empty.name = planetName;
            empty.transform.SetParent(parent);

            Debug.Log("Created planet: " + planetName);
        }

        
    }
}