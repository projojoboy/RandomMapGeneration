using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	[SerializeField] GameObject[] objects;
    private GameObject spawnedTemplate;

    private void Start()
    {
        int rand = Random.Range(0, objects.Length);
        spawnedTemplate = Instantiate(objects[rand], transform.position, Quaternion.identity);
        spawnedTemplate.transform.parent = gameObject.transform;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(spawnedTemplate);

            int rand = Random.Range(0, objects.Length);
            spawnedTemplate = Instantiate(objects[rand], transform.position, Quaternion.identity);
        }
    }
}
