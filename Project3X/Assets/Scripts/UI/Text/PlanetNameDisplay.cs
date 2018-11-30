using TMPro;
using UnityEngine;

namespace Project3X
{
    public class PlanetNameDisplay : MonoBehaviour
    {
        private void OnEnable()
        {
            GetComponentInParent<Planet>().onPlanetNameChanged += NameDisplay;
        }

        public void NameDisplay(string planetName)
        {
            GetComponent<TextMeshPro>().text = planetName;
        }
    }
}