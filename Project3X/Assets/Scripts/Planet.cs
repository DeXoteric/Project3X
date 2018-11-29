using UnityEngine;

namespace Project3X
{
    public class Planet
    {
        public static SaveData saveData;

        public string PlanetName { get; private set; }
        public Vector3 PlanetPosition { get; private set; }
        public float DistanceFromStar { get; private set; }

        public Planet(Star star, int index, Transform parent)
        {
            Vector3 randomPlanetPosition = MathFuctions.PlanetPosition(index);

            PlanetName = star.StarName + " " + (index + 1);

            //GameObject planet = SpaceObjects.CreateSphereObject(PlanetName, randomPlanetPosition, parent);
            GameObject planet = GameObject.Instantiate(GalaxyManager.instance.planetPrefab);
            planet.name = PlanetName;
            planet.transform.position = randomPlanetPosition;
            planet.transform.SetParent(parent);
            PlanetPosition = star.StarPosition + planet.transform.position;
            DistanceFromStar = Vector3.Distance(star.StarPosition, PlanetPosition);


            GalaxyManager.instance.planets.Add(planet.name, this);

            //Debug.Log("Distance from star: " + DistanceFromStar);
            //Debug.Log("Created planet: " + PlanetName);

            
        }
        
        
    }
}