using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Project3X
{
    public class StarNameDisplay : MonoBehaviour
    {

        private void OnEnable()
        {
           
        }

        public void NameDisplay(string starName)
        {
            this.GetComponent<TextMeshProUGUI>().text = starName;
        }

        private void OnDestroy()
        {
           
        }
    }
}
