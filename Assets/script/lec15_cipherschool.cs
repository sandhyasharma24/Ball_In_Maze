using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec15_cipherschool : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //addscore without any reference to lec19 script
            lec19_cipherschool.instance.AddScore(1);
            Invoke("DestroyCollectables", 0.2f);
        }
    }
    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
