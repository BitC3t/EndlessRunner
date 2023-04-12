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

    void OnCollisionEnter(Collision collision) {
    /*if (collision.gameObject.name.Contains("Cube")) {
        Vector3 planePosition = collision.contacts[0].point;
        Quaternion planeRotation = collision.transform.rotation;

        GameObject newPlane = Instantiate(planePrefab, planePosition, planeRotation);

        newPlane.transform.SetParent(transform);

        GetComponent<Renderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }fix the fucking cube thing*/
}
}
