using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform player;

    public Vector3 offset;

    void Start() {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }

    void LateUpdate()
    {
        if(Quaternion.Angle(player.transform.rotation, Quaternion.Euler(0,0,120)) <= 0.01f) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 300), Time.deltaTime * 6.0f);
            return;
        } 

        if(Quaternion.Angle(player.transform.rotation, Quaternion.Euler(0,0,60)) <= 0.01f) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 240), Time.deltaTime * 6.0f);
            return;
        }

        if(Quaternion.Angle(player.transform.rotation, Quaternion.Euler(0,0,-60)) <= 0.01f) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 120), Time.deltaTime * 6.0f);
            return;
        }

        if(Quaternion.Angle(player.transform.rotation, Quaternion.Euler(0,0,-120)) <= 0.01f) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 60), Time.deltaTime * 6.0f);
            return;
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, player.transform.rotation, Time.deltaTime * 6.0f);

    }
}
