using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guardTMovement : MonoBehaviour
{
    public Rigidbody2D npcRB;
    public SpriteRenderer spriteR;
    public Animator Anim;
    public bool isLeft = false;
    public float npcMovementSpeed = 5f;
    public GameObject targetPosType;
    public GameObject targetPos;
    public float hsp = 0f;
    public float vsp = 0f;
    public float triggerDistance = 0.1f;

    public float timer = 0f;
    public float destroyTime = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        npcRB = GetComponent<Rigidbody2D>();
        spriteR = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
        targetPos = Instantiate(targetPosType, transform.position, Quaternion.identity);
    }

    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, targetPos.transform.position) >= triggerDistance)
        {
            if (targetPos.transform.position.x > transform.position.x + triggerDistance)
                hsp = 1 * npcMovementSpeed;
            else if (targetPos.transform.position.x < transform.position.x - triggerDistance)
                hsp = -1 * npcMovementSpeed;
            else
                hsp = 0;
            if (targetPos.transform.position.y > transform.position.y + triggerDistance)
                vsp = 1 * npcMovementSpeed;
            else if (targetPos.transform.position.y < transform.position.y - triggerDistance)
                vsp = -1 * npcMovementSpeed;
            else
                vsp = 0;
        }
        else
        {
            hsp = 0;
            vsp = 0;
        }

        npcRB.velocity = new Vector2(hsp, vsp);

        if (hsp < 0)
            isLeft = true;
        else
            isLeft = false;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > destroyTime)
        {
            Destroy(targetPos);
            Destroy(this.gameObject);
        }

        if (!isLeft)
            spriteR.flipX = false;
        else
            spriteR.flipX = true;

        if (npcRB.velocity != Vector2.zero)
        {
            Anim.Play("Walking");
        }
        else
        {
            Anim.Play("Idle");
        }
        spriteR.sortingOrder = -Mathf.FloorToInt(1000 + 100 * transform.position.y);

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            npcRB.drag = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playerMood>().mood -= 1;
        }
    }
}
