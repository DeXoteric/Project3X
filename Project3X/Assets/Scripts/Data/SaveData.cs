﻿using System;

namespace Project3X
{
    [Serializable]
    public struct SaveData
    {
        
        //[SerializeField] [Range(-1999999999, 1999999999)]
        public int seedNumber;
        public int numberOfStars;
        public int minimumRadius;
        public int maximumRadius;
        public float minDistBetweenStars;
    }
}