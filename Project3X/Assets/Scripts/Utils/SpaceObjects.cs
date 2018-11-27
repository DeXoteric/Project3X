using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project3X {
    public class SpaceObjects : MonoBehaviour
    {

        // This method creates a sphere object whether that be a planet or star
        public static GameObject CreateSphereObject(string name)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.name = name;
            
            return sphere;
        }

        public static GameObject CreateSphereObject(string name, Vector3 position, Transform parent = null)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.name = name;
            sphere.transform.position = position;
            sphere.transform.parent = parent;

            return sphere;
        }
    }
}
