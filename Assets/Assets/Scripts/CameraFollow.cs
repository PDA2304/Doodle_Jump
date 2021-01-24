using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform doodlePos;

    // Update is called once per frame
    void Update()
    {
        if (doodlePos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, doodlePos.position.y, transform.position.z);
        }
    }
}
