using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPosition : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        string tag = gameObject.tag;
        Debug.Log(tag + ": " + transform.position);
    }
}
