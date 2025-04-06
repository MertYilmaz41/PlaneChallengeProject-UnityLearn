using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    public float rotateSpeed = 1000.0f;
    private Vector3 rotate = new Vector3(0, 0, 8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotate * rotateSpeed);
    }
}
