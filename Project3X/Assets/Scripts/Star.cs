using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class Star
    {
        public string StarName { get; private set; }
        public Vector3 StarPosition { get; private set; }
        public float DistanceFromGalaxyCenter { get; private set; }
        private int numPlanets;
        private int numAsteroids;
        private int numConnectionPoints;

        public List<Planet> planets = new List<Planet>();

        public Star(Vector3 position, int index, Transform parent)
        {
            StarName = "Star " + (index + 1);
            StarPosition = position;
            DistanceFromGalaxyCenter = Vector3.Distance(Vector3.zero, position);
            numPlanets = 4;
            numAsteroids = 3;
            numConnectionPoints = 2;

            //Debug.Log("created " + StarName + " with: " + numPlanets + " planets, " + numAsteroids + " asteroids, " + numConnectionPoints + " connection point/s");

            GameObject star = SpaceObjects.CreateSphereObject(StarName);

            for (int i = 0; i < numPlanets; i++)
            {
                Planet planet = new Planet(this, i, star.transform);
                planets.Add(planet);
            }

            star.transform.position = position;
            star.transform.SetParent(parent);

            //Debug.Log("Distance from galaxy center: " + DistanceFromGalaxyCenter);
            
        }
    }
}