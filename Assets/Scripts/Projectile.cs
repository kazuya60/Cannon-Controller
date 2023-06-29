using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // This script is place on a projectile GameObject
  public ParticleSystem boom;
  // public AudioClip DestroyBoom;
   
    void Start()
    {
         // The projectile is deleted after 10 seconds, whether
         // or not it collided with anything (to prevent lost
         // instances sticking around in the scene forever)
          Destroy(gameObject,4.0f);
    }

    void OnCollisionEnter()
    {
      Destroy(gameObject);
      ParticleSystem boomInstance = Instantiate(boom,transform.position,boom.transform.rotation);
      Destroy(boomInstance,5.0f);
    }
    
}
