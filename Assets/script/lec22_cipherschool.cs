using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lec22_cipherschool : MonoBehaviour
{
    int childCount = 0;
    //if we want to hide in inspector but still be accessible to all other scripts
    [HideInInspector]public bool allCoinCollected = false;
    //if we want a private variable to be seen in insprector
    //for example :- private int x;
    //then it can be written like '[SerializeField]private int x; ' and done

    private void Start()
    {
        childCount = transform.childCount;
        //transform will get the no . child present in hierarchy

    }
    private void Update()
    {
        //we need to check every frame whether we have collected any coin or not
        //check if the count of child object has changed
        if(transform.childCount <  childCount)
        {
            Debug.Log("coin taken");
            //update the child count
            childCount = transform.childCount;
            if (childCount == 0) { 
            allCoinCollected = true;
            }


        }
    }
}
