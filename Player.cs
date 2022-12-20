using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float flapStrenght;
    public Logic logic;
    public AudioSource boingFile;
    public bool birdIsAlive = true;
    public AudioSource jump;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive){
            rb.velocity = new Vector2(rb.velocity.x, flapStrenght);
            jump.Play();
            Debug.Log("jumping...");
        }

        if(transform.position.y > 1.19 || transform.position.y < -1) {
            birdIsAlive = false;
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.GameOver();
        if(birdIsAlive){
            boingFile.Play();
        }
        birdIsAlive = false;
    }
}
