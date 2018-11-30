using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class Star : MonoBehaviour
    {
        public string StarID { get; set; }
        public string StarName { get; set; }
        public Vector3 StarPosition { get; set; }

        public List<Planet> planets = new List<Planet>();

        public delegate void OnStarNameChanged(string starName);
        public event OnStarNameChanged onStarNameChanged = delegate { };

        private void Start()
        {
            onStarNameChanged(StarName);
        }
    }
}