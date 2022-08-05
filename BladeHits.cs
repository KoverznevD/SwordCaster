using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeHits : MonoBehaviour
{
    Rigidbody2D blade;
    private float thrust = 20f;

    private void Start()
    {
        blade = this.GetComponent<Rigidbody2D>();    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "Blade")
        {
            Debug.Log("Hit!");
            blade.AddForce(transform.up * thrust);
        }
    }

    
}
