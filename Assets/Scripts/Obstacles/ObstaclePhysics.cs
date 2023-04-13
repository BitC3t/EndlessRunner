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
    private List<string> layers = new List<string>() {"GO - L1", "GO - L2", "GO - L3", "GO - L4", "GO - L5", "GO - L6"};
    
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
            if(getLayerOfObject(rb)) {
                rb.useGravity = true;
            }
        }
    }

    bool getLayerOfObject(Rigidbody rb) {
        GameObject currentLayer = GameObject.Find(PlayerMovement.current);
        GameObject nextLayer = GameObject.Find(PlayerMovement.nextLayer);
        GameObject previousLayer = GameObject.Find(PlayerMovement.previousLayer);

        
            if(rb.transform.position.y == currentLayer.transform.position.y) {
                return false;
            }

            if(rb.transform.position.y == nextLayer.transform.position.y) {
                return false;
            }

            if(rb.transform.position.y == previousLayer.transform.position.y) {
                return false;
            }

            return true;
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
