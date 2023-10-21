using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float moveDistance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            rigidbody2D.MovePosition(rigidbody2D.position + Vector2.up * moveDistance);
        }
        else if (Input.GetKeyDown("down"))
        {
            rigidbody2D.MovePosition(rigidbody2D.position + Vector2.down * moveDistance);
        }
        else if (Input.GetKeyDown("left"))
        {
            rigidbody2D.MovePosition(rigidbody2D.position + Vector2.left * moveDistance);
        }
        else if (Input.GetKeyDown("right"))
        {
            rigidbody2D.MovePosition(rigidbody2D.position + Vector2.right * moveDistance);
        }
        

        

    }
}
