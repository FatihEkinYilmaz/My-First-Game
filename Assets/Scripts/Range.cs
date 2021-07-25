using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range : MonoBehaviour
{
    public float leftSide = -8.0f;
    public float rightSide = 13.0f;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<leftSide)
        {
            transform.position = new Vector3(leftSide, transform.position.y, transform.position.z);
        }
        else if (transform.position.x>rightSide)
        {
            transform.position = new Vector3(rightSide, transform.position.y, transform.position.z);
        }
    }
}
