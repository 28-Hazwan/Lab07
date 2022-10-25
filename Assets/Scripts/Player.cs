using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float velocity;
    private Rigidbody rb;
    private float score;
    public GameObject UI;
   
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        UI.GetComponent<Text>().text = "Score : " + score;
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.velocity = Vector2.up * velocity;
        }
        
            
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Out")
        {
            SceneManager.LoadScene("GAMEOVER");
        }
        if (collision.gameObject.tag == "Score")
        {
            
            score++;
        }
    }

}
