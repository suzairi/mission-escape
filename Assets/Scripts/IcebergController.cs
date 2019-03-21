using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcebergController : MonoBehaviour {

    public GameObject iceberg;

    float initialIcebergPosX = 0.0f;
    float initialIcebergPosY = -7.5f;
    float icebergPosX, icebergPosY;
    float boundaryIcebergLeft = -10.0f, boundaryIcebergRight = 8.0f;

	// Use this for initialization
	void Start () {
        InitializeIceberg();
	}

    void InitializeIceberg()
    {
        float x = Random.Range(boundaryIcebergLeft,boundaryIcebergRight);
        Instantiate(iceberg, new Vector2(x, initialIcebergPosY), Quaternion.identity);
    }

    void MoveIceberg()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
