using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D playerRigid2D;

    private float movePlayerHorizontal;
    private float movePlayerVertical;
    private Vector2 movement;

    public float speed = 4.0f;

    private void Awake()
    {
        playerRigid2D = this.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePlayerHorizontal = Input.GetAxis("Horizontal");

        movePlayerVertical = Input.GetAxis("Vertical");

        movement = new Vector2(movePlayerHorizontal, movePlayerVertical);

        playerRigid2D.velocity = movement * speed;
    }
}
