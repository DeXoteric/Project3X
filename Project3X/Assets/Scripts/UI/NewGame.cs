using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project3X
{
    public class NewGame : MonoBehaviour
    {

        //TODO move this to some kind of New Game menu
        [SerializeField] [Range(-1999999999, 1999999999)] public int seedNumber = 0;
        [SerializeField] public int numberOfStars = 300;
        [SerializeField] [Range(0, 500)] public int minimumRadius = 300;
        [SerializeField] [Range(700, 1000)] public int maximumRadius = 1000;
        [SerializeField] public float minDistBetweenStars = 50f;


        public void OnClickNewGame()
        {
            Galaxy galaxy = new Galaxy(seedNumber, numberOfStars, minimumRadius, maximumRadius, minDistBetweenStars);
        }
    }
}
