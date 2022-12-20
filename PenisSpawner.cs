using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenisSpawner : MonoBehaviour
{
     public GameObject Penis;
    public float spawnRate = 1;
    private float timer = 0;
    public float hightOffset = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnPenis();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
            spawnRate = spawnRate + (Time.deltaTime * 0.5f);
        } else {
            spawnPenis();
            timer = 0;
        }
    }

    void spawnPenis(){
        float lowestPoint = (transform.position.y - hightOffset) * 0.1f;
        float highestPoint = (transform.position.x + hightOffset) * 0.1f;

        Instantiate(Penis, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        }
}
