using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class GalaxyManager : MonoBehaviour
    {
        public static GalaxyManager instance;

        [Header("Prefabs")]
        public Star starPrefab;
        public Planet planetPrefab;

        [Header("Galaxy")]
        [SerializeField] [Range(-1999999999, 1999999999)] public int seedNumber = 0;
        [SerializeField] [Range(0, 500)] public int minimumRadius = 500;
        [SerializeField] [Range(1000, 5000)] public int maximumRadius = 5000;
        [SerializeField] public int numberOfStars = 250;
        [SerializeField] public float minDistBetweenStars = 150f;

        [Header("Stars")]
        [SerializeField] [Range(0, 2)] private int minNumPlanets;
        [SerializeField] [Range(3, 6)] private int maxNumPlanets;

        public Dictionary<string, Star> stars = new Dictionary<string, Star>();
        public Dictionary<string, Planet> planets = new Dictionary<string, Planet>();

        private void OnEnable()
        {
            instance = this;
        }

        private void Start()
        {
            GalaxyGenerator.instance.CreateGalaxy(seedNumber,
                numberOfStars, minimumRadius, maximumRadius, minDistBetweenStars,
                minNumPlanets, maxNumPlanets);
        }
    }
}