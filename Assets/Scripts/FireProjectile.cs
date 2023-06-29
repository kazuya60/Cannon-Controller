using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FireProjectile : MonoBehaviour
{
    // This script launches a projectile prefab by instantiating it at the position
    // of the GameObject on which it is placed, then then setting the velocity
    // in the forward direction of the same GameObject.


    public Rigidbody projectile;
    public float speed = 4;
    public AudioSource audioSource;
    public AudioClip explosionSound;
    public ParticleSystem ExplosionSmoke;
    
    

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
            audioSource.PlayOneShot(explosionSound);
            ParticleSystem explosionInstance = Instantiate(ExplosionSmoke,transform.position,transform.rotation);
            // stored the explosionSmoke into an instance so only the clones are being destroyed rather than the object original.
            // check master codes if material persists on the gameobject
            Destroy(explosionInstance,5.0f);
            
            
        }
    }
}
