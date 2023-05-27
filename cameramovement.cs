using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    public float camspeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(camspeed * Time.deltaTime, 0, 0);
    }
}
