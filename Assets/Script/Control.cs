using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Rigidbody2D den;
    public float kecepatan;
    public Vector2 gerakan;

    // Start is called before the first frame update
    void Start()
    {
        den = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gerakan.x = Input.GetAxisRaw("Horizontal");
        gerakan.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        den.MovePosition(den.position + gerakan * kecepatan * Time.fixedDeltaTime);
    }
}
