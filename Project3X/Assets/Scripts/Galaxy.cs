using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class Galaxy : MonoBehaviour
    {
        public static Galaxy instance;

        public SolarSystem solarSystemPrefab;
        public Star starPrefab;
        public Planet planetPrefab;

        private List<SolarSystem> solarSystems = new List<SolarSystem>();

        private void OnEnable()
        {
            instance = this;
        }
        

        private void Start()
        {
            CreateSolarSystem();
        }

        public void CreateSolarSystem()
        {
            SolarSystem solarSystem = Instantiate(solarSystemPrefab);
            solarSystem.transform.SetParent(transform);
            solarSystems.Add(solarSystem);
        }
    }
}