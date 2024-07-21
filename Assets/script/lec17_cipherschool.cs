using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec17_cipherschool : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform instatiatePos;
    public lec14_cipherschool camerafollow;
    // Start is called before the first frame update
    void Start()
    {
       GameObject go = Instantiate(ballPrefab, instatiatePos.position, Quaternion.identity);
        camerafollow.target = go.transform;
    }

}
