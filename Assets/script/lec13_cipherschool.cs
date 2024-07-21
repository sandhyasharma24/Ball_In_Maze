using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()

    // Update is called once per frame

    public float speed;
    private string tag_wall = "wall";
    //we created this variable tagwall to avoid reusing string wall again and again and to avoid spelling mistake because to check the collision tag spelling should be same as in inspector
    void Update()
    {
        //getaxes method help us to move ball along horizontal axiz anf vertical axis
        //in unity edit->project setting->input manager->axes
        //get axes return value between -1 and 1
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
        //TIMEDELATATIMe:-its time in second ,takes computer last feed and ensure consistent movement in all frame
        //to roll the ball we need to add force on it and for that we need reference of rigitbody
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement, ForceMode.Impulse);




    }

    private void OnCollisionEnter(Collision collision)
    {
        //the parameter collision will help us find to what object our playes has collided with and what tag it has
        if (collision.gameObject.tag == tag_wall) {
            Debug.Log("collided with wall");
            //we will use addscore method from lec 19 to avoid messing up the code and do all work in one script
            lec19_cipherschool.instance.AddScore(-1);
        
        }
    }
}
