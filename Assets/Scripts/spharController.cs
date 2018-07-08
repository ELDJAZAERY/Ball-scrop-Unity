using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spharController : MonoBehaviour {

    public float jumpForce=50;
    [Range(100,500)]
    public float ballSpeed = 500;
    Rigidbody body;

    bool jumpEnable = true;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update() {

        //if(Input.GetKey(KeyCode.RightWindows)) { GetComponent<Rigidbody>().AddForce(50, 0, 0); Debug.Log("Righte !!");  }  

        float xSpeed =  -Input.GetAxis("Vertical");
        float ySpeed =  Input.GetAxis("Horizontal");
        //body.AddTorque(new Vector3(xSpeed, 0, ySpeed) * ballSpeed * Time.deltaTime);
        body.AddForce(new Vector3(xSpeed, 0, ySpeed) * ballSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && jumpEnable){
            jumpEnable = false;
            body.AddForce(new Vector3(xSpeed,jumpForce, ySpeed) * ballSpeed * Time.deltaTime);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "floor")  jumpEnable = true;
    }

}
