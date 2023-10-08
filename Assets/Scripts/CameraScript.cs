using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    // target should be the Player game object in hierarchy

    void Start()
    {
        
    }


    void Update()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        //moves the camera to the player's position

    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        //moves the camera to the player's position again
    }
}
