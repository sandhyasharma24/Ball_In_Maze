using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec27_cipherschool : MonoBehaviour
{
    //this script will present in all the scene for that we are making it singleton
    public static lec27_cipherschool instance;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
            //this method won't let the scrit destroy even on switching scenes
            DontDestroyOnLoad(gameObject);
        }
    }
}
