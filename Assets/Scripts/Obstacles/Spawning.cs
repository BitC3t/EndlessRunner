using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawning : MonoBehaviour
{

    public GameObject player;
    public GameObject prefab;
    public float zOffset;
    
    private float x, y, z;
    private List<string> layers = new List<string>() {"GO - L1", "GO - L2", "GO - L3", "GO - L4", "GO - L5", "GO - L6"};

    private float timePassed = 0f;
    // Start is called before the first frame update
    // This is where you will spawn an object with a defined Z offset from the player
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Random rd = new Random();
        string layerChosen = layers[rd.Next(layers.Count)];      
        GameObject layer = GameObject.Find(layerChosen);
    
        x = layer.transform.position.x;
        y = layer.transform.position.y;
        z = player.transform.position.z + zOffset;

        Vector3 position = new Vector3(x, y, z);

        spawnObject(position, layer);
    }

    void spawnObject(Vector3 pos, GameObject layer) {
        timePassed += Time.deltaTime;
        if(timePassed >= 2f) {
            GameObject gameObject = Instantiate(prefab, pos, layer.transform.rotation);
            timePassed = 0f;
        }
    }

    
}
