using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionobstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.gameObject.tag == "obstacle")
        {
            Debug.Log("ww hit obstacle");
            /*  game over script  */
        }
        if(collisioninfo.gameObject.tag == "lavafloor")
        {
            Debug.Log("ww hit lava");
            /*  game over script  */
        }



    }
}
