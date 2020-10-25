using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Threading;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject ShooterEnemy;
    public GameObject WallEnemy;
    public GameObject followenemy;
    public GameObject trapEnemy;
    public GameObject sensor;
    private GameObject tag;
    public Transform[] pozicia;
    int Spawnrate = 1;
    float secondsBetween = 8f;
    float passedtime = 0.0f;
    public Transform plaer;
    Vector3 fwd, offset;
    float distance = 5f;
    float counter = 0;
    void Update()
    {
        int number = (int)Random.Range(1, 5);
        tag = GameObject.FindGameObjectWithTag("Enemy");
        passedtime += Time.deltaTime;
        if (passedtime > secondsBetween)
        {
            if (!tag)
            {
                passedtime = 0;
                if (number == 1)
                {
                    fwd = transform.TransformDirection(Vector3.forward) * distance;
                    offset = plaer.position + fwd;
                    Instantiate(WallEnemy, offset, Quaternion.identity);
                }
                else if (number == 2)
                {
                    for (int i = 0; i < Spawnrate; i++)
                    {
                        StartCoroutine(BeforeSpawn(sensor, ShooterEnemy));
                    }
                }
                else if (number == 3)
                {
                    StartCoroutine(BeforeSpawn(sensor, followenemy));
                }
                else if (number == 4)
                {
                    for (int i = 0; i < Spawnrate; i++)
                    {
                        StartCoroutine(BeforeSpawn(sensor, trapEnemy));
                    }
                }


            }
        }
        counter += Time.deltaTime;

        if (counter > 10f)
        {
            Spawnrate++;
            counter = 0;
        }

    }

    void spawnmtrisas(GameObject rame, Transform sp)
    {
        Instantiate(rame, sp.position, sp.rotation);
    }

    IEnumerator BeforeSpawn(GameObject SensorPlace, GameObject enemy)
    {
        Transform sp = pozicia[Random.Range(0, pozicia.Length)];
        SensorPlace = (GameObject)Instantiate(SensorPlace, sp.position, sp.rotation);
        Destroy(SensorPlace, 0.9f);
        yield return new WaitForSeconds(1f);

        spawnmtrisas(enemy, sp);
    }
}
