using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    public GameObject tear;
    public PlayerMovement player;
    public float tearCooldown;
    public float tearSpeed;
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
                //Rigidbody2D tearInstance = Instantiate(tear, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
                if (Input.GetKey("up"))
                {
                    GameObject tearInstance = Instantiate(tear, transform.position, Quaternion.identity);
                    tearInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, 1.0f * tearSpeed);
                    Destroy(tearInstance, 2f);
                }
                else if (Input.GetKey("down"))
                {
                    GameObject tearInstance = Instantiate(tear, transform.position, Quaternion.identity);
                    tearInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0.0f, -1.0f * tearSpeed);
                    Destroy(tearInstance, 2f);
                }
                else if (Input.GetKey("right"))
                    {
                    GameObject tearInstance = Instantiate(tear, transform.position, Quaternion.identity);
                    tearInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f * tearSpeed, 0.0f);
                    Destroy(tearInstance, 2f);
                }
                else {

                    GameObject tearInstance = Instantiate(tear, transform.position, Quaternion.identity);
                    tearInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f * tearSpeed, 0.0f);
                    Destroy(tearInstance, 2f);
                }


            }
            
        }
        if (tearCooldownTimer > 0)
        {
            tearCooldownTimer--;
        }
        
    }
}