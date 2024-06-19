using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody Player;

    public float moveSpeed;
    public float rotSpeed;
    public float jumpForce;

    public int Score;

    void Start()
    {
        Player = GetComponent<Rigidbody>();
        moveSpeed = 1.0f;
        rotSpeed = 15f;
        jumpForce = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        moveWASD(); 
        //moveWASD2();
    }


    void moveWASD()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (Time.deltaTime * moveSpeed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * moveSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (Time.deltaTime * moveSpeed));
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.back * (Time.deltaTime * rotSpeed));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward * (Time.deltaTime * rotSpeed));
        }
    }

    void moveWASD2()
    {
        float translation = Input.GetAxis("Horizontal") * moveSpeed;
        float rotation = Input.GetAxis("Vertical") * rotSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);
        transform.Rotate(0, 0, rotation);
        if (Input.GetButton("Jump"))
        {
            Player.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
