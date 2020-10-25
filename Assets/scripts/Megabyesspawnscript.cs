using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Megabyesspawnscript : MonoBehaviour
{
    private Vector3 spawnposition;
    public GameObject megaBytes;
    public GameObject megaBytesLarge;
    public AudioSource spawnsound;
    float counter = 0;
    void spawn()
    {
        spawnposition.x = Random.Range(-13f, 13f);
        spawnposition.z = Random.Range(-13f, 13f);
        spawnposition.y = 0f;
        // rand
        if (counter>20f)
        {
            Instantiate(megaBytesLarge, spawnposition, Quaternion.identity);
            counter = 0;
        }
        else
        {
            Instantiate(megaBytes, spawnposition, Quaternion.identity);
        }
    }

     void Update()
    {
        counter += Time.deltaTime;
            if (GameObject.FindGameObjectWithTag("MegaByte") == null)
            {
            spawn();
            spawnsound.Play();
            }
        
    }
}