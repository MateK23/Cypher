using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyshooting : MonoBehaviour
{
    public Transform player;
    public float lifetime;
    public Transform Shootposition;
    public GameObject Projectile;
    public float Firerate;
    float Nextfire=0;
    public Slider slider;
    private void Start()
    {
        slider.value = lifetime;
    }
    private void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime < 0.0f)
        {
            Destroy(gameObject);
        }
        slider.value = lifetime;
        transform.LookAt(player);
        if (Time.time > Nextfire)
        {
            Nextfire = Time.time + Firerate;
            Instantiate(Projectile,Shootposition.position,Shootposition.rotation);
            player= GameObject.FindGameObjectWithTag("Player").transform;
        }
        
    }
}
