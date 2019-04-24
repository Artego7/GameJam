using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 8f;
    float horizontalMove = 0f;
    bool isJumping;
    bool isCrouch;
    bool isAttack;
    public int live = 100;
    public float jumpForce;
    public Animator animator;
    Rigidbody2D RbPlayer;
    SpriteRenderer RenderPlayer;
    GameObject GameObjPlayer;

    // Use this for initialization
    void Start()
    {
        RenderPlayer = GetComponent<SpriteRenderer>();
        RbPlayer = GetComponent<Rigidbody2D>();
        GameObjPlayer = GetComponent<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Damage();
        Attack();
        Movement();
        Jump();
        ChangeColorForDamage();
    }

    void Movement()
    {
        Crouch();

        if (!isCrouch)
        {
            horizontalMove = Input.GetAxis("Horizontal");
        }
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKey(KeyCode.LeftControl))
        {
            horizontalMove = horizontalMove * 1.5f;
        }
        RbPlayer.velocity = new Vector2(speed * horizontalMove, RbPlayer.velocity.y);
        OrentationPlayer();
    }

    void OrentationPlayer()
    {
        if (horizontalMove < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (horizontalMove > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isAttack = true;
        }
        if(this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            isAttack = false;
        }

        animator.SetBool("Attack", isAttack);
    }

    void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftShift) && !isCrouch && !isJumping)
        {
            isCrouch = true;
            horizontalMove = 0f;
            animator.SetBool("Crouch", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isCrouch = false;
            animator.SetBool("Crouch", false);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping && !isCrouch)
        {
            isJumping = true;
            RbPlayer.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("Jumping", true);
        }
    }

    private void CollisionJump(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Flor"))
        {
            isJumping = false;
            animator.SetBool("Jumping", false);
        }
    }
    private void ColliderJump(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Water"))
        {
            isJumping = false;
            animator.SetBool("Jumping", false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        CollisionJump(collision);
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        ColliderJump(collider);
    }

    void Damage()
    {
        print(live);
        if(live <= 0)
        {
            Destroy(GameObjPlayer);
        }
    }
    void ChangeColorForDamage()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            RenderPlayer.color = new Color(0.7019608f, 0.3960785f, 0.4235294f, 1f);
            print(RenderPlayer.material.color);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            RenderPlayer.color = new Color(1f, 1f, 1f, 1f);
            print(RenderPlayer.material.color);
        }
    }
}
