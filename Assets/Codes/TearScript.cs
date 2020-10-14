using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;
    public PlayerMovement player;
    public float tearCooldown = 30;
    private float startingCounter;
    // Start is called before the first frame update
    void Start()
    {
        startingCounter = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("right"))
        {
            if (startingCounter == 0)
            {
                startingCounter = tearCooldown;
                GameObject tear = GameObject.Instantiate(ObjectsToSpawn[0]);
                tear.transform.position = player.transform.position;
            }
            if (startingCounter > 0)
            {
                startingCounter--;
            }
        }
    }
}