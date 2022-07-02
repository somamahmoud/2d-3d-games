using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class bluedragon : MonoBehaviour
{
    [SerializeField]
    GameObject PauseMenuScreen;
    float move1;
    float jump1;

    int i;

    float moveforce = 4f;
    float jump = 7;

    string collid = "collid";
    string bluedia = "bluedia";
    string rock = "rock";
    string animjump = "jump";
    string walk = "walk";

    private Rigidbody2D body;
    private SpriteRenderer sr;
    Animator anim;
    [SerializeField]
    AudioSource[] sounds;
    
    AudioSource audio1;
    AudioSource audio2;

    bool ground = true;

    [SerializeField]
    TMP_Text Game_Over;



    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        sounds = GetComponents<AudioSource>();
        audio1 = sounds[0];
        audio2 = sounds[1];
    }


    void Update()
    {
        PlayerMove();
        JumpPlayer();
        jumpAnimate();
        animatewalk();

    }
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            move1 = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(move1, 0f, 0f) * Time.deltaTime * moveforce;


        }
    }
    private void animatewalk()
    {
        if (move1 == -1)
        {
            anim.SetBool(walk, true);
            sr.flipX = false;

            move1 = 0;
        }

        else if (move1 == 1)
        {
            sr.flipX = true;
            anim.SetBool(walk, true);
            move1 = 0;
        }
        else
        {
            anim.SetBool(walk, false);

        }
    }

    private void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.W) && ground)
        {
            ground = false;
            jump1 = Input.GetAxisRaw("Vertical");
            body.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            audio1.Play();
        }

    }

    void jumpAnimate()
    {
        if (ground == true)
        {
            anim.SetBool(animjump, false);
        }
        else
        {
            anim.SetBool(animjump, true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(bluedia))
        {
            i += 1;
            Destroy(collision.gameObject);
            audio2.Play();
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            Game_Over.enabled = true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(collid) | collision.gameObject.CompareTag("greendrag") | collision.gameObject.CompareTag(rock))
        {
            ground = true;
        }

        if (collision.gameObject.CompareTag(rock))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(rock))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }

    public int get()
    {
        return i;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenuScreen.SetActive(false);

    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
