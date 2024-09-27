using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pro3PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    
    public Animator playerAnimator;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    
    private AudioSource playerAudio;
    public AudioClip jumpSound;
    public AudioClip explosionSound;
    


    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

       //starts player in running animation bc speed_f is set to 1.0 and that's the parameter requirement
        playerAnimator.SetFloat("Speed_f", 1.0f);

      

        rb = GetComponent<Rigidbody>();

        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            playerAudio.PlayOneShot(jumpSound, 0.6f);
            dirtParticle.Stop();
            isOnGround = false;

            //set jump trigger animation
            playerAnimator.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explosionSound, 1.0f);
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
           
            gameOver = true;
        }
      
    }
}
