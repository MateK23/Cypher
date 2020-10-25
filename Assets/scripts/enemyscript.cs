using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyscript : MonoBehaviour
{
    public Transform player;
    public float lifetime;
    public Slider slider;
    private void Start()
    {
        slider.value = lifetime;
    }

    private void Update()
    {
        transform.LookAt(player);
        lifetime -= Time.deltaTime;
        slider.value = lifetime;
        if (lifetime <= 0.0f)
        {
            Destroy(gameObject);
        }
        //player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<playermovement>().death();
        }
    }
}
