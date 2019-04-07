using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpead;
    public float flyPower;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode flyKey;

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newForce = new Vector2(0, 0); //the force we will add to our player


        if (Input.GetKey(leftKey)) //When someone presses "A"
        {
            newForce.x -= MoveSpead;
        }

        if (Input.GetKey(rightKey)) //When someone presses "D"
        {
            newForce.x += MoveSpead;
        }
        
        if (Input.GetKey(flyKey)) //When someone presses "Space"
        {
            rb.AddForce(Vector2.up * flyPower);
        }

        rb.AddForce(newForce);

    }

}
