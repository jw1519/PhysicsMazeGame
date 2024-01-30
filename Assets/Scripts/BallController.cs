using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController instance;
    public GameObject BallPrefab;
    public Transform Spawn;
    public int poolSize = 5;

    private List<GameObject> ballsPool;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        //make the pool
        ballsPool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(BallPrefab);
            obj.SetActive(false);
            ballsPool.Add(obj);
        }

    }

    public void SpawnBall()
    {
        if (BallPrefab && Spawn)
        {
            Instantiate(BallPrefab, Spawn.position, Spawn.rotation);
        }
    }

}
