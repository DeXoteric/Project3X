using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class SolarSystem
    {
        public string solarSystemName { get; set; }
        private int numPlanets;
        private int numAsteroids;
        private int numConnectionPoints;

        private Star star;
        public List<Planet> planets;

        public SolarSystem()
        {
            solarSystemName = "Solar System";
            numPlanets = 4;
            numAsteroids = 3;
            numConnectionPoints = 2;

            GameObject empty = new GameObject();
            empty.name = solarSystemName;
            empty.transform.SetParent(Galaxy.instance.transform);

            Debug.Log("created " + solarSystemName + " with: " + numPlanets + " planets, " + numAsteroids + " asteroids, " + numConnectionPoints + " connection point/s");

            star = new Star(this, empty.transform);

            planets = new List<Planet>();

            for (int i = 0; i < numPlanets; i++)
            {
                Planet planet = new Planet(this, i + 1, empty.transform);
                planets.Add(planet);
            }
        }
    }
}