using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            StartCoroutine(kill());
        }
        if (collision.gameObject.tag == "wall")
        {
            StartCoroutine(kill());
        }
    }
    
    IEnumerator kill()
    {
        sprite.enabled = false;
        yield return new WaitForSeconds(3);
        transform.position = new Vector3(Random.Range(8, -8), Random.Range(4.5f, -4.5f));
        sprite.enabled = true;

    }
}
