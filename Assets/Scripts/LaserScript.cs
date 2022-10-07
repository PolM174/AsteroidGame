using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    public float speed;
    public GameObject explosion;
    private GameObject animatrion_explosion;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(0.0f, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LimitLaser"))
        {
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            animatrion_explosion = (GameObject) Instantiate(explosion, transform.position, transform.rotation);
            Destroy(animatrion_explosion,2.0f);

        }
    }






}
