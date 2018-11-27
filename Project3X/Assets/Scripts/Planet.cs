using UnityEngine;

namespace Project3X
{
    public class Planet
    {
        public string PlanetName { get; private set; }
        public Vector3 PlanetPosition { get; private set; }

        public Planet(Star star, int index, Transform parent)
        {
            Vector3 randomPlanetPosition = MathFuctions.PlanetPosition(index);

            PlanetName = star.StarName + " " + (index + 1);
            
            GameObject planet = SpaceObjects.CreateSphereObject(PlanetName, randomPlanetPosition, parent);

            PlanetPosition = star.StarPosition + planet.transform.position;

            Debug.Log("Created planet: " + PlanetName);
        }
    }
}