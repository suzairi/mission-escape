using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTrigger : MonoBehaviour {

	  public float speed;

    private Rigidbody2D rb;
    public DataContainer dataContainer;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
	Debug.Log ("Collider"+other.name+" "+gameObject.name);
        if (other.gameObject.CompareTag ("BadDiamond"))
        {
	    Debug.Log("destroy badDiamond");
            //other.gameObject.SetActive (false);
		dataContainer.score+= other.gameObject.GetComponent<Diamonds>().badDiamond;
	    Destroy(other.gameObject);

        }
    }
}