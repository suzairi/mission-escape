using UnityEngine;

public class PickUpTrigger : MonoBehaviour 
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const string BADDIAMOND = "BadDiamond";
    private const string GOODDIAMOND = "GoodDiamond";

    public float speed;
    public DataContainer dataContainer;

    private Rigidbody2D rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis (HORIZONTAL);
        float moveVertical = Input.GetAxis (VERTICAL);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.CompareTag (BADDIAMOND))
        {
		    dataContainer.score+= other.gameObject.GetComponent<Diamond>().badDiamond;
	        Destroy (other.gameObject);
        }
	
        if (other.gameObject.CompareTag (GOODDIAMOND))
        {
		    dataContainer.score+= other.gameObject.GetComponent<Diamond>().goodDiamond;
	        Destroy (other.gameObject);
        }
    }
}