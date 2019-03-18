using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerController : MonoBehaviour
 {
     public float speed = 5f;
 
     private Rigidbody2D rb2d;
 
     void Start()
     {
         rb2d = GetComponent<Rigidbody2D>();
     }
     void Update()
     {
         if (Input.GetKey(KeyCode.A))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
 
         if (Input.GetKey(KeyCode. D))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
	}

     }
 }