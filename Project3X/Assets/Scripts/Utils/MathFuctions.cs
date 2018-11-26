﻿using UnityEngine;

namespace Project3X
{
    public class MathFuctions : MonoBehaviour
    {
        // This method converts a distance and angle (polar coordinates)
        public static Vector3 PolarToCart(float distance, float angle)
        {
            Vector3 cartPosition = new Vector3(distance * Mathf.Cos(angle), distance * Mathf.Sin(angle), 0);

            return cartPosition;
        }

        // This method returns a random angle between 0 and 2*PI
        public static float RandomAngle()
        {
            float angle = Random.Range(0, 2 * Mathf.PI);

            return angle;
        }

        // This method creates a random polar coordinate then converts and returns it as a Cartesian coordinate
        public static Vector3 RandomPosition(float minRad, float maxRad)
        {
            float distance = Random.Range(minRad, maxRad);
            float angle = RandomAngle();

            Vector3 cartPosition = PolarToCart(distance, angle);

            return cartPosition;
        }

        // This method creates a positon for a planet based on its number in the planetList (see Star Class)
        public static Vector3 PlanetPosition(int planetListNumber)
        {
            float distance = (planetListNumber + 1) * 15; //TODO random with proper scale
            float angle = RandomAngle();

            Vector3 cartPosition = PolarToCart(distance, angle);

            return cartPosition;
        }
    }
}