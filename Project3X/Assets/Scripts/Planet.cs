using UnityEngine;

namespace Project3X
{
    public class Planet : MonoBehaviour
    {
        public string planetName;
        
        public void Start()
        {
            
            

            Debug.Log("Created planet: " + planetName);
        }

        
    }
}