using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class GalaxyManager : MonoBehaviour
    {
        public static GalaxyManager instance;

       

        [Header("Prefabs")]
        public GameObject starPrefab;
        public GameObject planetPrefab;

        [SerializeField] [Range(-1999999999, 1999999999)] public int seedNumber = 0;
        [SerializeField] public int numberOfStars = 300;
        [SerializeField] [Range(0, 500)] public int minimumRadius = 300;
        [SerializeField] [Range(700, 2000)] public int maximumRadius = 1000;
        [SerializeField] public float minDistBetweenStars = 50f;

        
        public Dictionary<string, Star> stars = new Dictionary<string, Star>();
        public Dictionary<string, Planet> planets = new Dictionary<string, Planet>();

        private void OnEnable()
        {
            instance = this;
        }

        private void Start()
        {
            Galaxy galaxy = new Galaxy(seedNumber, numberOfStars, minimumRadius, maximumRadius, minDistBetweenStars);


            
        }
    }
}