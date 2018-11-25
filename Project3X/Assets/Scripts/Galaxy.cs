using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class Galaxy : MonoBehaviour
    {
        public static Galaxy instance;

        private List<SolarSystem> solarSystems;

        private void OnEnable()
        {
            instance = this;
        }

        private void Awake()
        {
            solarSystems = new List<SolarSystem>();
        }

        private void Start()
        {
            CreateSolarSystem();
        }

        public void CreateSolarSystem()
        {
            var solarSystem = new SolarSystem();
            solarSystems.Add(solarSystem);
        }
    }
}