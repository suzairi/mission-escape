using UnityEngine;

public class IcebergController : MonoBehaviour
{
    private float initialIcebergPosX = .0f;
    private float initialIcebergPosY = -7.5f;
    private float initialIcebergBigPosY = -9.8f;

    private float icebergPosX, icebergPosY;
    private float boundaryIcebergLeft = -10.0f, boundaryIcebergRight = 8.0f;
    private float time = .0f;

    public GameObject iceberg;
    public GameObject icebergBig;
    public float delay = 3.0f;

    void Start ()
    {
        InitializeIceberg ();
	}

    void InitializeIceberg ()
    {
        float x = Random.Range (boundaryIcebergLeft,boundaryIcebergRight);

        float random = Random.RandomRange(0.0f, 1.0f);
        float treshold = 0.5f;

        if (random > treshold)
        {
            Instantiate(iceberg, new Vector2(x, initialIcebergPosY), Quaternion.identity);
            return;
        }

        Instantiate(icebergBig, new Vector2(x, initialIcebergBigPosY), Quaternion.identity);

    }
	
	void Update ()
    {
        time += Time.deltaTime;
        
        if (time > delay)
        {
            InitializeIceberg ();
            time = .0f;
        }
	}
}
