using System;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public static event Action<passedPipe> onSpawn;
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnRate = 30;
    [SerializeField] private float heightOffset = 10;
    private float timer = 29;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnRate)
        {
            Spawn();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void Spawn() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        passedPipe newPipe = Instantiate(pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation).GetComponentInChildren<passedPipe>();
        onSpawn?.Invoke(newPipe);
    }
}
