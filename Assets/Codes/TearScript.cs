using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            GameObject tear = GameObject.Instantiate(ObjectsToSpawn[0]);
            tear.transform.position = player.transform.position;
        }
    }
}
