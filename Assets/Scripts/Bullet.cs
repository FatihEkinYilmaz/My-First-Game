using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;
    public float topBound = 15.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        if (transform.position.z>topBound)
        {
            Destroy(this.gameObject);
        }
    }
}
