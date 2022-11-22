using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public const float LANE_DISTANCE = 5.0f;

    public float speed = 10;
    public float gravity = 10;
    public float verticalVelocity;
    private CharacterController controller;
    private int desiredLane = 1;
    private float acceleration;
    private float speedBoost;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLane(false);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveLane(true);
        }

        Vector3 targetPosition = transform.position.z * Vector3.forward;

        if(desiredLane == 0)
            targetPosition +=  Vector3.left * LANE_DISTANCE;
        else if (desiredLane == 2)
            targetPosition += Vector3.right * LANE_DISTANCE;


       
        for (int i = 0; i < 10; i++)
        {
            acceleration += 0.03f * Time.deltaTime;
        }


        //Debug.Log( acceleration );

        Vector3 moveVector = Vector3.zero;
        moveVector.x = (targetPosition - transform.position).normalized.x * speed;
        moveVector.y = -0.1f;
     

        controller.Move(moveVector * Time.deltaTime);
    }

    private void MoveLane (bool goingRight)
    {
        //Left Movement
        if (!goingRight)
        {
            desiredLane --;
            if(desiredLane == -1)
            desiredLane = 0;
        }
        //Right Movement
        else
        {
            desiredLane ++;
            if (desiredLane == 3)
            desiredLane = 2;
        }
    }
}
