using UnityEngine;

namespace Project3X
{
    public class Planet : MonoBehaviour
    {
        public string PlanetID { get; set; }
        public string PlanetName { get; set; }
        public Vector3 PlanetPosition { get; set; }

        public delegate void OnPlanetNameChanged(string planetName);
        public event OnPlanetNameChanged onPlanetNameChanged = delegate { };

        private void Start()
        {
            onPlanetNameChanged(PlanetName);
        }
    }
}