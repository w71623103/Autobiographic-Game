using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class playerMoving : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float playerMovementSpeed = 5f;
    public bool isBouncing = false;
    public bool timerStarted = false;
    public float timer = 0f;
    public float timePeriod = 0.25f;
    public bool hasCollided = false;
    public SpriteRenderer spriteR;
    public Animator Anim;
    public bool isLeft = true;
    public AudioSource sound;
    public AudioClip walkingS, hitS;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>(); //get a reference to the Rigidbody2D component on this player gameObject!
        spriteR = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalMovement = Input.GetAxis("Vertical") * playerMovementSpeed;
        float horizontalMovement = Input.GetAxis("Horizontal") * playerMovementSpeed;
        if(!isBouncing)
            playerRB.velocity = new Vector2(horizontalMovement, verticalMovement);

        if (horizontalMovement <= 0)
            isLeft = true;
        else
            isLeft = false;
        
    }

    void Update()
    {
        if (timerStarted)
        {
            timer += Time.deltaTime;
        }

        if (timer >= timePeriod)
        {
            timerStarted = false;
            isBouncing = false;
            hasCollided = false;
            timer = 0;
        }

        spriteR.sortingOrder = -Mathf.FloorToInt(1000 + 100 * transform.position.y);

        if (isLeft)
            spriteR.flipX = false;
        else
            spriteR.flipX = true;


        if (playerRB.velocity != Vector2.zero)
        {
            Anim.Play("kkslWalking2");
            
        }
        else 
        {
            Anim.Play("kkslIdle");
            
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "NPC")
        {
            isBouncing = true;
            hasCollided = true;
            sound.PlayOneShot(hitS);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (hasCollided)
        {
            isBouncing = false;
            hasCollided = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        timerStarted = true;
    }
}
