using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class SolarSystem : MonoBehaviour
    {
        private string solarSystemName;
        private int numPlanets;
        private int numAsteroids;
        private int numConnectionPoints;

        private Star star;
        private List<Planet> planets  = new List<Planet>();

        public void Start()
        {
            solarSystemName = "Solar System";
            this.name = solarSystemName;

            numPlanets = 4;
            numAsteroids = 3;
            numConnectionPoints = 2;


            Debug.Log("created " + solarSystemName + " with: " + numPlanets + " planets, " + numAsteroids + " asteroids, " + numConnectionPoints + " connection point/s");

            CreateStar();
            CreatePlanets();
        }

        private void CreateStar()
        {
            star = Instantiate(Galaxy.instance.starPrefab);
            star.transform.SetParent(transform);
            star.name = solarSystemName;
            star.starName = solarSystemName;
        }

        private void CreatePlanets()
        {
            for (int i = 0; i < numPlanets; i++)
            {
                Planet planet = Instantiate(Galaxy.instance.planetPrefab);
                planet.transform.position = MathFuctions.PlanetPosition(i);
                planet.transform.SetParent(transform);
                planet.name = solarSystemName + " " + (i + 1);
                planet.planetName = solarSystemName + " " + (i + 1);
                planets.Add(planet);
            }
        }

        
    }
}