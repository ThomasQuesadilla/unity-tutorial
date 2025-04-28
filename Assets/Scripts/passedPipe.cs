using System;
using UnityEngine;

public class passedPipe : MonoBehaviour
{
    public event Action onPass;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            onPass?.Invoke();
            Destroy(gameObject);
        }
    }
}
