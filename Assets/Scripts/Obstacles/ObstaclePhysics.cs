using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePhysics : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject player;
    public float zOffset;
    
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
}
