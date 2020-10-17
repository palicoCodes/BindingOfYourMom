using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    public GameObject[] ObjectsToSpawn;
    public PlayerMovement player;
    public float tearCooldown = 30;
    private float tearCooldownTimer = 0;
    public int tearDuration;
    // Start is called before the first frame update
    void Start()
    {
         
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("right"))
        {
            if (tearCooldownTimer == 0)
            {
                tearCooldownTimer = tearCooldown;
                GameObject tear = GameObject.Instantiate(ObjectsToSpawn[0]);

                tear.transform.position = player.transform.position;
                Destroy(tear,tearDuration);
            }
            
        }
        if (tearCooldownTimer > 0)
        {
            tearCooldownTimer--;
        }
        
    }
}