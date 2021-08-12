using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;
     void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosionParticle, transform.position, transform.rotation);
            
        }
        else
        {

        }
            
        
        
    }
}
