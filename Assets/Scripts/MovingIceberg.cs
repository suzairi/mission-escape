using UnityEngine;

public class MovingIceberg : MonoBehaviour {

    private float finishPosYMin = -5.5f;
    private float finishPosYMax = -3.9f;
    private Vector3 startPos;
    private float trackPercent = 0;
    private int direction = 1;
    private int destroyCounter = 2;

    public Vector3 finishPos = Vector3.zero;
    public float speed = 0.5f;

    private void Start ()
    {
        startPos = transform.position;
        finishPos.x = transform.position.x;
        finishPos.y = GetRandomizedIcebergFinishYPos ();
    }

    private float GetRandomizedIcebergFinishYPos ()
    {
        return Random.Range(finishPosYMin, finishPosYMax);
    }

    void Update ()
    {
        trackPercent += direction * speed * Time.deltaTime;
        float x = (finishPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3 (x, y, startPos.z);

        if ((direction == 1 && trackPercent > .9f) ||
                (direction == -1 && trackPercent < .1f))
        {
            direction *= -1;
            destroyCounter--;
        }

        if(destroyCounter == 0)
        {
            Destroy(gameObject);
        }
    }
}

