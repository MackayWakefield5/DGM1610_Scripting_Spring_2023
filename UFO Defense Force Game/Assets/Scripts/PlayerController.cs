using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;

    public GameObject lazerBolt;

    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player on screen
        // Left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        //Right side Wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }

        // If w pressed fire lazerBolt
        if(Input.GetKeyDown(KeyCode.W))
        {
            // Creat lazerBolt at the blaster transform position maintaining object rotation
            Instantiate(lazerBolt,blaster.transform.position,lazerBolt.transform.rotation);
        }
    }
    // Delete object with trigger that hits player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
