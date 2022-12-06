using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bsll : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpFOrce;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gate")
        {
            Player.instance.score += 50;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Death")
        {
            Player.instance.death();
            Destroy(gameObject);
        }
    }
}
