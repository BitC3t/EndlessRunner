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
    private float deltaX = 5.0f;
    private List<int> negativeX = new List<int>() {1, -1};
    private List<float> offsetY = new List<float>() {0.0f, 2.5f, 7.5f, 10.0f};

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
        float xOffset = deltaX * (float) negativeX[rd.Next(negativeX.Count)];
        float yOffset = offsetY[rd.Next(offsetY.Count)];
    
        x = player.transform.position.x + xOffset;
        y = player.transform.position.y + yOffset;
        z = player.transform.position.z + zOffset;

        Vector3 position = new Vector3(x, y, z);

        spawnObject(position);
    }

    void spawnObject(Vector3 pos) {
        timePassed += Time.deltaTime;
        if(timePassed >= 2f) {
            Instantiate(prefab, pos, Quaternion.identity);
            timePassed = 0f;
        }
    }
}
