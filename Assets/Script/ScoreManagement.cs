using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManagement : MonoBehaviour
{
    public float speed;
    int score;
    public Text scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), speed * Time.deltaTime);
        scoreTxt.text = "" + score;
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "virus")
        {
            score++;
        }
    }
}
