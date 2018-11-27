using UnityEngine;

namespace Project3X
{
    public class Star : MonoBehaviour
    {
        public string starName;

        public void Start()
        {
            
            Debug.Log("Created star: " + starName);
        }
    }
}