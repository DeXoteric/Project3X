using TMPro;
using UnityEngine;

namespace Project3X
{
    public class StarNameDisplay : MonoBehaviour
    {
        private void OnEnable()
        {
            GetComponentInParent<Star>().onStarNameChanged += NameDisplay;
        }

        public void NameDisplay(string starName)
        {
            GetComponent<TextMeshPro>().text = starName;
        }
    }
}