using UnityEngine;

public class DiamondSpawner : MonoBehaviour 
{
    private Vector2 whereToSpawn;
    private float randX;
    private float randY;
    private float nextSpawnGood = 0.0f;
    private float nextSpawnBad = 0.0f;
    private float boundaryXMin = -6.5f, boundaryXMax = 6.5f;
    private float boundaryYMin = -4.0f, boundarYMax = 4.0f;
    private float thresholdDiamond = 0.5f;

    public GameObject goodDiamond;
    public GameObject badDiamond;
    public float spawnRate = 2f;

    private void Update()
    {
        if (randomizeDiamonds() > thresholdDiamond)
        {
            InstantiateGoodDiamond();
            return;
        }

        InstantiateBadDiamond();
    }

    private void InstantiateGoodDiamond () 
    {
        if (Time.time > nextSpawnGood)
        {
            nextSpawnGood = Time.time + spawnRate;
            Instantiate (goodDiamond, GetWhereToSpawn (), Quaternion.identity);
        }
    }

    private void InstantiateBadDiamond ()
    {
        if (Time.time > nextSpawnBad)
        {
            nextSpawnBad = Time.time + spawnRate;
            Instantiate(badDiamond, GetWhereToSpawn (), Quaternion.identity);
        }
    }

    private Vector2 GetWhereToSpawn()
    {
        randX = Random.Range(boundaryXMin, boundaryXMax);
        randY = Random.Range(boundaryYMin, boundarYMax);
        return new Vector2(randX, randY);
    }

    private float randomizeDiamonds()
    {
        return Random.Range(0.0f, 1.0f);
    }
}




