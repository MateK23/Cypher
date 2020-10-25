using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemywalk : MonoBehaviour
{
    public Transform player;

    public float speed;
    public float lifetime;
    public Slider slider;
    private void Start()
    {
        slider.value = lifetime;
    }


    void Update()
    {
        transform.LookAt(player);

        transform.position += transform.forward * speed * Time.deltaTime;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        lifetime -= Time.deltaTime;
        if (lifetime < 0.0f)
        {
            Destroy(gameObject);
        }
        slider.value = lifetime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playermovement>().death();
        }
    }
}
