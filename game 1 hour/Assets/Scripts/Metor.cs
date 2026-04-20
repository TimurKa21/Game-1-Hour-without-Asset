using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Metor : MonoBehaviour
{
    public float speed = 5f;
    public TMP_Text text;
    private int hitCount = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 randomDirection = Random.onUnitSphere;
        randomDirection.y = 0;
        rb.velocity = randomDirection * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hitCount++;
            text.text = (hitCount * 50).ToString();

            Destroy(collision.gameObject); 
           
            if (hitCount >= 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
