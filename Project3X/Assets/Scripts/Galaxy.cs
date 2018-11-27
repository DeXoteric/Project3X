using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class Galaxy : MonoBehaviour
    {
        public static Galaxy instance;

        [SerializeField] private int numberOfStars = 300;
        [SerializeField] [Range(0, 500)] public int minimumRadius = 0;
        [SerializeField] [Range(700, 1000)] public int maximumRadius = 1000;
        //[SerializeField] [Range(-1999999999, 1999999999)] public int seedNumber = 0;

        [SerializeField] private float minDistBetweenStars = 2f;

        private List<Star> stars;

        private void OnEnable()
        {
            instance = this;
        }

        private void Awake()
        {
            stars = new List<Star>();
        }

        private void Start()
        {
            CreateGalaxy();
        }

        public void CreateGalaxy()
        {
            int failCount = 0;

            for (int i = 0; i < numberOfStars; i++)
            {
                Vector3 starPosition = MathFuctions.RandomPosition(minimumRadius, maximumRadius);

                Collider[] positionCollider = Physics.OverlapSphere(starPosition, minDistBetweenStars);

                if (positionCollider.Length == 0)
                {
                    Star star = new Star(starPosition, i, this.transform);
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

            Debug.Log(Vector3.Distance(stars[0].StarPosition, stars[1].StarPosition));
            Debug.Log(Vector3.Distance(stars[0].planets[0].PlanetPosition, stars[1].planets[0].PlanetPosition));

            Debug.Log(stars[0].planets[0].PlanetPosition);
            Debug.Log(stars[1].planets[0].PlanetPosition);
        }
    }
}