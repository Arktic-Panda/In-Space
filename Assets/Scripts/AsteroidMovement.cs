using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 10;
    private float deadZone = -1;
    private float acceleration = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         for (int i = 0; i < 10; i++)
        {
            acceleration += 0.1f * Time.deltaTime;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * (speed + acceleration));

        if (transform.position.z < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
