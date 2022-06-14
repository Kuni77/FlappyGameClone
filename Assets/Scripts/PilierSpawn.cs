using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilierSpawn : MonoBehaviour
{

    public float tempsMax = 1;
    private float timer = 0;
    public GameObject pilier;
    public float height;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //si temms plus grand que maxtime
        if (timer > tempsMax)
        {
            GameObject nouveauPilier = Instantiate(pilier);
            nouveauPilier.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(nouveauPilier, 20);
            timer = 0;
        }
        
        timer += Time.deltaTime;
    }
}
