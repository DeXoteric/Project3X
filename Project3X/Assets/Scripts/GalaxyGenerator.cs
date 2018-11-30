using UnityEngine;

namespace Project3X
{
    public class GalaxyGenerator : MonoBehaviour
    {
        public static GalaxyGenerator instance;

        private void OnEnable()
        {
            instance = this;
        }

        public void CreateGalaxy(int seedNumber,
            int numberOfStars, int minimumRadius, int maximumRadius, float minDistBetweenStars,
            int minNumPlanets, int maxNumPlanets)
        {
            Random.InitState(seedNumber);

            GameObject galaxy = new GameObject("Galaxy");

            int failCount = 0;

            for (int i = 1; i <= numberOfStars; i++)
            {
                Vector3 starPosition = MathFuctions.RandomPosition(minimumRadius, maximumRadius);

                Collider2D[] positionCollider = Physics2D.OverlapCircleAll(starPosition, minDistBetweenStars);

                if (positionCollider.Length == 0)
                {
                    Star star = Instantiate(GalaxyManager.instance.starPrefab);

                    var numPlanets = Random.Range(minNumPlanets, maxNumPlanets + 1);

                    star.name = "Star " + i;
                    star.transform.position = starPosition;
                    star.transform.SetParent(galaxy.transform);

                    star.StarID = "Star " + i.ToString(); //TODO pick random name from list
                    star.StarName = "Star " + i;
                    star.StarPosition = star.transform.position;

                    GalaxyManager.instance.stars.Add(star.StarID, star);

                    failCount = 0;

                    for (int j = 1; j < numPlanets; j++)
                    {
                        Planet planet = Instantiate(GalaxyManager.instance.planetPrefab);

                        var randomPlanetPosition = MathFuctions.PlanetPosition(j);

                        planet.name = star.StarName + " " + j;
                        planet.transform.position = star.StarPosition + randomPlanetPosition;
                        planet.transform.SetParent(star.transform);

                        planet.PlanetID = star.StarName + " " + j; //TODO roman numerals
                        planet.PlanetName = star.StarName + " " + j;
                        planet.PlanetPosition = planet.transform.position;

                        GalaxyManager.instance.planets.Add(planet.PlanetID, planet);
                    }
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
        }
    }
}