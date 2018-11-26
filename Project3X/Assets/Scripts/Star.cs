using UnityEngine;

namespace Project3X
{
    public class Star : MonoBehaviour
    {
        public string starName;
        public Vector3 starPosition { get; private set; }

        public void Start()
        {
            starPosition = transform.position;
            Debug.Log("Created star: " + starName);
        }
    }
}