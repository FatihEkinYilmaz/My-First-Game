using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private AudioSource audioSourcep;
    public AudioClip explosionSound;
    private void Start()
    {
        audioSourcep = GetComponent<AudioSource>();
        
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Instantiate(explosionParticle, transform.position, transform.rotation);
            audioSourcep.PlayOneShot(explosionSound, 1.0f);


            
        }
        
            
        
        
    }
}
