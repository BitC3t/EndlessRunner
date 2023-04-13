using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ObstaclePhysics : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject player;
    public float zOffset;
    public GameObject planePrefab;

    public GameObject prefab;
    public GameObject lavafloorr;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb.useGravity = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z + zOffset >= rb.transform.position.z) {
            rb.useGravity = true;
        }


    }

    void OnCollisionEnter(Collision collisioninfo) {
        if (collisioninfo.gameObject.tag == "floor1")
        {
            
            
            Instantiate(lavafloorr,transform.position,Quaternion.Euler(0,0,0));
           

           /* Vector3 planePosition = collisioninfo.contacts[0].point;
            Quaternion planeRotation = collisioninfo.transform.rotation;

            GameObject newPlane = Instantiate(planePrefab, planePosition, planeRotation);

            newPlane.transform.SetParent(transform);

            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider>().enabled = false;*/
        }


        if (collisioninfo.gameObject.tag == "floor2")
        {

           
            Instantiate(lavafloorr, transform.position, Quaternion.Euler(0,0,-60));


        }



        if (collisioninfo.gameObject.tag == "floor3")
        {

            
            Instantiate(lavafloorr, transform.position, Quaternion.Euler(0, 0, -120));


        }



        if (collisioninfo.gameObject.tag == "floor4")
        {

            
            Instantiate(lavafloorr, transform.position, Quaternion.Euler(0, 0, 180));


        }



        if (collisioninfo.gameObject.tag == "floor5")
        {

            
            Instantiate(lavafloorr, transform.position, Quaternion.Euler(0, 0, 120));


        }



        if (collisioninfo.gameObject.tag == "floor6")
        {

            
            Instantiate(lavafloorr, transform.position, Quaternion.Euler(0, 0, 60));


        }


       




    }

}
