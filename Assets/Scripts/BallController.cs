using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController instance;
    public GameObject BallPrefab;
    public Transform Spawn;

    private bool timerStarted = false;
    private float timeSinceKnockOver = 0f;
    public float timeUntilNewBall = 5f;
    private int knockedOverCount;

    // Start is called before the first frame update
    //void Awake()
    //{
    //    if (instance == null)
    //        instance = this;
    //    else if (instance != this)
    //        Destroy(gameObject);
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (timerStarted)
    //    {
    //        timeSinceKnockOver += Time.deltaTime;

    //        if (timeSinceKnockOver >= timeUntilNewBall)
    //        {
    //            instance.SpawnNewBall(); // Call BallManager to spawn a new ball
    //            timerStarted = false; // Reset timer
    //            timeSinceKnockOver = 0f; // Reset time counter
    //        }
    //    }
    //    if (knockedOverCount >= 10)
    //    {
    //        Debug.Log("All skittles knocked over!");
    //        timerStarted = false; // Stop the timer if all skittles are down
    //        // Implement what happens when all skittles are down
    //    }
    //}
    //public void SpawnNewBall()
    //{
    //    if (BallPrefab && Spawn)
    //    {
    //        Instantiate(BallPrefab, Spawn.position, Quaternion.identity);
    //        Debug.Log("New ball spawned!");
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {
        
        Instantiate(BallPrefab, Spawn.position, Spawn.rotation);
    }
}
