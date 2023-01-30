using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    //controls
    bool UP, DOWN, LEFT, RIGHT;
    //others
    public Rigidbody2D rgbd2d;
    public float speed;

    private void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            UP = true;
        }
        else
        {
            UP = false;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            RIGHT = true;
        }
        else
        {
            RIGHT = false;
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            DOWN = true;
        }
        else
        {
            DOWN = false;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            LEFT = true;
        }
        else
        {
            LEFT = false;
        }
    }

    private void FixedUpdate()
    {
        if (RIGHT)
        {
            rgbd2d.transform.Translate(new Vector3 (speed, rgbd2d.velocity.y, 0) * Time.deltaTime * speed);
        }
        if (LEFT)
        {
            rgbd2d.transform.Translate(new Vector3(-speed, rgbd2d.velocity.y, 0) * Time.deltaTime * speed);
        }
        if (UP)
        {
            rgbd2d.transform.Translate(new Vector3(rgbd2d.velocity.x, speed, 0) * Time.deltaTime * speed);
        }
        if (DOWN)
        {
            rgbd2d.transform.Translate(new Vector3(rgbd2d.velocity.x, -speed, 0) * Time.deltaTime * speed);
        }
    }
}
