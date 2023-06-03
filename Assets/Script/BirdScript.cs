using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigitBody;
    private float gravity = 3;
    public LogicScript logic;
    public bool isBirdAlive = true;
    private bool isCollided = false;
    public AudioSource playerJump;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isCollided == true) { 
            transform.position += Vector3.left * 10 * Time.deltaTime;
        }

        playerInput();
        myRigitBody.gravityScale = gravity;

        if (transform.position.y <= -13 || transform.position.y >= 14) {
            logic.gameOver();
        }

    }

    void playerInput() {
        if (Input.GetKeyDown(KeyCode.Space) == true && isBirdAlive == true) {
            myRigitBody.velocity = Vector2.up * 10;
            playerJump.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBirdAlive = false;
        isCollided = true;
    }
}
