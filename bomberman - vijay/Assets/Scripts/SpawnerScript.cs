using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject bombPrefab;

    private float minX = -2.55f;

    private float maxX = 2.55f;

    void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));

        // this is the wait timer before starting to spawn new bombs
        Instantiate(bombPrefab,
        new Vector2(Random.Range(minX, maxX), transform.position.y),
        Quaternion.identity);

        // Essentially sets the boundry for where the bombs can spawn, transform.position.y makes the y of the bombs the same as the spawner.
        StartCoroutine(SpawnBombs());
    }
} // class
