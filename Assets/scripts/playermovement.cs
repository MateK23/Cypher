using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playermovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    private Vector3 direction;
    public float rotationspeed;
    public static float score;
    public Text scoretext;
    public Joystick joy;
    public AudioSource sheaskda;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoretext.text = score.ToString() +"KB";
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            death();
        }
    }

    void Movement()
    {
        //   float horizontalmove = Input.GetAxisRaw("Horizontal");
        //   float verticalmove = Input.GetAxisRaw("Vertical");
        float horizontalmove = joy.Horizontal;
        float verticalmove = joy.Vertical;
        direction = new Vector3(horizontalmove, 0.0f, verticalmove);
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationspeed * Time.deltaTime);
        }

        //rb.MovePosition(transform.position +speed * Time.deltaTime * direction);
        rb.velocity = direction * speed;
    }
    public void death()
    {
        sheaskda.Play();
        SceneManager.LoadScene(2);
    }

    public void scoreplus(int x)
    {
        score += x;
        scoretext.text = score.ToString() + "KB";
    }
}