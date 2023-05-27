using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour  //BOCHICA
{
    public float speed;
    public bool grounded;
    public float jumpPower;
    private bool right;

    public Rigidbody2D rb2d;
    public Animator animator;
    public GameObject indigenous;
    public event EventHandler MuerteJugador;

    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource deathSound;
    [SerializeField] private AudioSource pickUpSound;
    [SerializeField] private GameObject deathSoundSource;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Grounded", grounded);
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            PlayJumpSound();
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
        }
    }
    void FixedUpdate()
    {
        PlayerMove();
    }
    //Valid Ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Grounded"))
        {
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collisionpiso)
    {
        if (collisionpiso.gameObject.CompareTag("Grounded"))
        {
            grounded = false;
        }
    }
   //Move player 
    private void PlayerMove()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);

        if (horizontal < 0 && right)
        {
            Spin();
        }
        else if (horizontal > 0 && !right)
        {
            Spin();
        }
        animator.SetFloat("Horizontal", Mathf.Abs(horizontal));
    }
    //Spin Player
    private void Spin()
    {
        right = !right;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    //Die Player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ceiling"))
        {
            PlayDeathSound();
            animator.SetTrigger("Die");
            StartCoroutine(ActiveDie());                      
            MuerteJugador?.Invoke(this, EventArgs.Empty);
        }

        if (collision.CompareTag("Item"))
        {
            pickUpSound.Play();
        }
    }
    //Sound Player Jump
    private void PlayJumpSound()
    {
        jumpSound.Play();
    }
    //Sound Player Die
    private void PlayDeathSound()
    {
        deathSound.Play();
    }
    //Desactivate Player
    IEnumerator ActiveDie()
    {
        float timeDie = 2f;
        yield return new WaitForSeconds(timeDie);
        indigenous.SetActive(false);

    }
}


