using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trapBehaviour : MonoBehaviour
{
    public float lifetime;
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
    
}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playermovement>().death();
        }
    }
}
