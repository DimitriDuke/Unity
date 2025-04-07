using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject UwU;

    // Update is called once per frame
    void Update()
    {
        if (UwU != null) 
        {
        Vector3 position = transform.position;
        position.x = UwU.transform.position.x;
        transform.position = position;
        }
    }
}
