using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    Vector3 scaleChange = new Vector3((float)0.0002, (float)0.0001, (float)0.0001);
    Vector3 positionChange = new Vector3(0, 0, (float)0.0002);
    Vector3 rotateChange = new Vector3((float)0.001, (float)0.001, (float)0.001);
    //public Vector3 scaleChange;
    //public Vector3 positionChange;
    //public Vector3 rotateChange;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
        transform.Rotate(rotateChange);
    }
}
