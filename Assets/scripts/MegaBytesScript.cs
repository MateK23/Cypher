using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MegaBytesScript : MonoBehaviour
{
    public int qula;
    public AudioSource pickupsound;
    public Transform player;
    private void Update()
    {
        // transform.LookAt(player);
        // player = GameObject.FindGameObjectWithTag("Player").transform; 
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<playermovement>().scoreplus(qula);
            pickupsound.Play();

            Destroy(gameObject,0.1f);
        }
    }
}
