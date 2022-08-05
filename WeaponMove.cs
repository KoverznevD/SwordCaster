using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMove : MonoBehaviour
{
    
    
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 20f;


    void FixedUpdate()
    {
        
        // Movement
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, _movementSpeed, 0)  * Time.deltaTime;
        } 
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -_movementSpeed, 0)  * Time.deltaTime;
        } 
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-_movementSpeed, 0, 0)  * Time.deltaTime;
        } 
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(_movementSpeed, 0, 0)  * Time.deltaTime;
        }

        // Rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward, -_rotationSpeed * Time.deltaTime);
        }
    }


    
}




