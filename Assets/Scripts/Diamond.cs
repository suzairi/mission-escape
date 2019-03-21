using UnityEngine;

public class Diamond : MonoBehaviour 
{
    private float time = 0;
    private float liveSpanMin = 2.0f;
    private float liveSpanMax = 6.0f;

    public int goodDiamond = 10;
	public int badDiamond = -10;

    private void Start ()
    {
        DestroyMySelf ();
    }

    private void DestroyMySelf ()
    {
        Destroy (gameObject, Random.Range(liveSpanMin,liveSpanMax));
    }
}
