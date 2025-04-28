using System;
using UnityEngine;

public class birbScript : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float flapForce;
    public event Action birbDead;
    private bool isAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && isAlive)
        {
            rigidBody.AddForceY(flapForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birbDead.Invoke();
        isAlive = false;
    }
}
