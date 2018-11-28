using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour {

    public static DataManager instance;

    private void OnEnable()
    {
        instance = this;
    }
}
