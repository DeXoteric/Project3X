using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
       
    public class Galaxy 
    {
        
        public List<Star> stars = new List<Star>();
        
        public Galaxy(int seed, int numberOfStars, int minimumRadius, int maximumRadius, float minDistBetweenStars)
        {
            DataManager.saveData.seedNumber = seed;
            DataManager.saveData.numberOfStars = numberOfStars;
            DataManager.saveData.minimumRadius = minimumRadius;
            DataManager.saveData.maximumRadius = maximumRadius;
            DataManager.saveData.minDistBetweenStars = minDistBetweenStars;


            GameObject galaxy = new GameObject("Galaxy");

            Random.InitState(seed);

            int failCount = 0;

            for (int i = 0; i < numberOfStars; i++)
            {
                Vector3 starPosition = MathFuctions.RandomPosition(minimumRadius, maximumRadius);

                Collider[] positionCollider = Physics.OverlapSphere(starPosition, minDistBetweenStars);

                if (positionCollider.Length == 0)
                {
                    Star star = new Star(starPosition, i, galaxy.transform);
                    stars.Add(star);
                    

                    failCount = 0;
                }
                else
                {
                    i--;
                    failCount++;
                }

                if (failCount > numberOfStars)
                {
                    Debug.LogError("Could not fit all stars in the galaxy. Consider smaller distance between stars!");
                    break;
                }
            }

            //Debug.Log(Vector3.Distance(stars[0].StarPosition, stars[1].StarPosition));
            //Debug.Log(Vector3.Distance(stars[0].planets[0].PlanetPosition, stars[1].planets[0].PlanetPosition));
            
            //Debug.Log(stars[0].planets[0].PlanetPosition);
            //Debug.Log(stars[1].planets[0].PlanetPosition);
        }
    }
}