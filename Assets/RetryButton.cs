using UnityEngine;
using UnityEngine.Events;

public class RetryButton : MonoBehaviour
{
    [SerializeField] private UnityEvent retry;


    private void Start()
    {
    }

    private void OnClick()
    {
        if (collision.CompareTag("Player"))
        {
            retry?.Invoke();
        }
    }
}