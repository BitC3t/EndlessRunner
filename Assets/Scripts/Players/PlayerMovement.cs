
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerMovement : MonoBehaviour
{

    public GameObject player;
    public float walkSpeed;
    public float layerSpeed;
    public float zMovement;
    public float playerHeight;

    private GameObject currentLayer;
    public static String current;
    public static String nextLayer;
    public static String previousLayer;
    private int index;
    private List<string> layers = new List<string>() {"GO - L1", "GO - L2", "GO - L3", "GO - L4", "GO - L5", "GO - L6"};

    // Start is called before the first frame update
    void Start()
    {
        this.currentLayer = GameObject.Find("GO - L1");
        this.index = 0;
        current = "GO - L1";
        previousLayer = "GO - L6";
        nextLayer = "GO - L2";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            string layer = getNextLayer();
            this.currentLayer = GameObject.Find(layer);
            Vector3 position = new Vector3(this.currentLayer.transform.position.x, this.currentLayer.transform.position.y,
            transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, position, layerSpeed * Time.deltaTime);

            transform.rotation = Quaternion.Slerp(transform.rotation, this.currentLayer.transform.rotation, Time.deltaTime * layerSpeed);
            changeGravity(layer);
        }

        if(Input.GetMouseButtonDown(1)) {
            string layer = getPreviousLayer();
            this.currentLayer = GameObject.Find(layer);
            Vector3 position = new Vector3(this.currentLayer.transform.position.x, this.currentLayer.transform.position.y,
            transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, position, layerSpeed * Time.deltaTime);

            transform.rotation = Quaternion.Slerp(transform.rotation, this.currentLayer.transform.rotation, Time.deltaTime * layerSpeed);
            changeGravity(layer);
        }

        transform.position += Vector3.forward * zMovement * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + zMovement);

        Debug.Log("Current: " + current + ", Next: " + nextLayer + ", Prev: " + previousLayer);
    }

    string getNextLayer() {
        this.index += 1;

        if(this.index >= 6) {
            this.index = 0;
        }

        current = this.layers[this.index];
        
        if(this.index - 1 == -1) {
            previousLayer = this.layers[5];
        } else {
            previousLayer = this.layers[this.index - 1];
        }

        if(this.index + 1 == 6) {
            nextLayer = this.layers[0];
        } else {
            nextLayer = this.layers[this.index + 1];
        }
        return this.layers[this.index];
    }

    string getPreviousLayer() {
        this.index -= 1;
        
        if(this.index <= -1) {
            this.index = 5;
        }

        current = this.layers[this.index];

        if(this.index - 1 == -1) {
            previousLayer = this.layers[5];
        } else {
            previousLayer = this.layers[this.index - 1];
        }

        if(this.index + 1 == 6) {
            nextLayer = this.layers[0];
        } else {
            nextLayer = this.layers[this.index + 1];
        }
        return this.layers[this.index];
    }

    void changeGravity(string layer) {
        if(layer == "GO - L1") {
            Physics.gravity = new Vector3(0,-9.8f,0);
        } else if(layer == "GO - L2") {
            Physics.gravity = new Vector3(-8.48f, -4.9f, 0);
        } else if(layer == "GO - L3") {
            Physics.gravity = new Vector3(-4.9f, 8.48f, 0);
        } else if(layer == "GO - L4") {
            Physics.gravity = new Vector3(0, 9.8f, 0);
        } else if(layer == "GO - L5") {
            Physics.gravity = new Vector3(4.9f, 8.48f, 0);
        } else if(layer == "GO - L6") {
            Physics.gravity = new Vector3(8.48f, 4.9f, 0);
        }
    }

    float getRadians(float deg) {
        return (float) (deg * Math.PI)/180f;
    }
}
