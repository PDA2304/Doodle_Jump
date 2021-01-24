using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();

        for (int i = 0; i < 7; i++)
        {
            SpawnerPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnerPosition.y += Random.Range(2f, 3f);

            Instantiate(platformPrefab, SpawnerPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
