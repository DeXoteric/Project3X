using UnityEngine;

namespace Project3X
{
    public class Planet : MonoBehaviour
    {
        public string planetName;
        public Vector3 planetPosition { get; private set; }

        public void Start()
        {

            planetPosition = transform.position;

            Debug.Log("Created planet: " + planetName);
            
        }

        private void Update()
        {
            Debug.Log(Vector3.Distance(this.transform.position, FindObjectOfType<Star>().transform.position));
        }
    }
}