using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject asteroid;

    private float timeBetwenAsteroids;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;
    public GameObject spawn7;
    public GameObject spawn8;
    public GameObject spawn9;
    public GameObject spawn10;


// Start is called before the first frame update
    void Start()
    {
        timeBetwenAsteroids = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timeBetwenAsteroids += Time.deltaTime;
        if(timeBetwenAsteroids > 1.0f)
        {

            int value = Random.Range(1, 11);
            

            if(value == 1)
            {
                GameObject element = Instantiate(asteroid, spawn1.transform.position, transform.rotation);

            }else if (value == 2)
            {
                GameObject element = Instantiate(asteroid, spawn2.transform.position, transform.rotation);
            }
            else if (value == 3)
            {
                GameObject element = Instantiate(asteroid, spawn3.transform.position, transform.rotation);
            }
            else if (value == 4)
            {
                GameObject element = Instantiate(asteroid, spawn4.transform.position, transform.rotation);
            }
            else if (value == 5)
            {
                GameObject element = Instantiate(asteroid, spawn5.transform.position, transform.rotation);
            }
            else if (value == 6)
            {
                GameObject element = Instantiate(asteroid, spawn6.transform.position, transform.rotation);
            }
            else if (value == 7)
            {
                GameObject element = Instantiate(asteroid, spawn7.transform.position, transform.rotation);
            }
            else if (value == 8)
            {
                GameObject element = Instantiate(asteroid, spawn8.transform.position, transform.rotation);
            }
            else if (value == 9)
            {
                GameObject element = Instantiate(asteroid, spawn9.transform.position, transform.rotation);
            }
            else if (value == 10)
            {
                GameObject element = Instantiate(asteroid, spawn10.transform.position, transform.rotation);

            }

            timeBetwenAsteroids = 0.0f;
        }

        //Destroy(element);
    }



}
