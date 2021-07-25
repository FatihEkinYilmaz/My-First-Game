using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public GameObject projectilePrefabs;

    public float horizontal_Input;
    public float speed = 10.0f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal_Input = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontal_Input,0)*speed * Time.deltaTime);
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabs, transform.position, projectilePrefabs.transform.rotation);
        }
    }
}
