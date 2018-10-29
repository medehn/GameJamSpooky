using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Experimental.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f; //holding speed of player

    private Vector3 velocity;
    public Vector3 ghostPosition;
    private GameObject teddy;
    public bool has_teddy;
    private Vector3 teddy_offset;


    private void Start()
    {
        has_teddy = false;
        ghostPosition = transform.position;
        teddy = GameObject.Find("teddy");
        teddy_offset = new Vector3(0f, 1f, 0f);
    }

    // Use this for initialization
    void Update()
    {
        velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = -1.0f;
            Vector3 v = new Vector3();
            transform.Rotate(0, 0, 10f * Time.deltaTime*speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = 1.0f;
            Vector3 v = new Vector3();
            transform.Rotate(0, 0, -10f * Time.deltaTime*speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            velocity.y = 1.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity.y = -1.0f;
        }

        transform.Translate(velocity.normalized * Time.deltaTime * speed);

        //teddy position setting
        if (has_teddy)
        {
            teddy.transform.position = transform.position + teddy_offset;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            has_teddy = true;
        }
    }
}