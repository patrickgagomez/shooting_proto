using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject hitEffect;
    public GameObject hole;
    public float particleTimer = 1f;
    
    //HERE FOR DESTRUCTION?
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        GameObject nextLevel = Instantiate(hole, transform.position, Quaternion.identity);
        Destroy(effect, particleTimer);
        Destroy(gameObject);
    }

}
