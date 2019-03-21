using UnityEngine;

 public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;

    public float speed = 5.0f;
 
    private void Start ()
    {
         rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update ()
    {
        if (Input.GetKey(KeyCode.A))
        {
             transform.position += Vector3.left * speed * Time.deltaTime;
	    }
 
        if (Input.GetKey(KeyCode.D))
        {
             transform.position += Vector3.right * speed * Time.deltaTime;
	    }
    }
}