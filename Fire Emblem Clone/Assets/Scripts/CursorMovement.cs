using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    public float duration = 0.5f;
    public float waitTime = 1f;
    public float slowDuration = 1.75f;

    private Vector3 endPos;
    private Vector3 startPos;
    private float durationElapsed;
    private float waitTimeElapsed;
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CursorControl();
    }
    void CursorControl()
    {
        if (!moving)
        {
            // If all buttons are released, completely stop and reset movement.
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
            {
                waitTimeElapsed = 0f;
            }

            // If player has moved once, but the wait time has not been surpassed, increment and force player to wait.
            if (waitTimeElapsed / waitTime < 1f)
            {
                
            }

            // Controls for moving cursor
            float horizDir = 0f;
            float vertDir = 0f;
            startPos = transform.position;
            if (Input.GetKey(KeyCode.D))
            {
                horizDir = 1f;
                moving = true;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                horizDir = -1f;
                moving = true;
            }
            if (Input.GetKey(KeyCode.W))
            {
                vertDir = 1f;
                moving = true;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                vertDir = -1f;
                moving = true;
            }
            endPos = new Vector3(startPos.x + horizDir, startPos.y, startPos.z + vertDir);


        }
        else
        {
            durationElapsed += Time.deltaTime;
            float percentComplete = 0f;
            if (waitTimeElapsed / waitTime < 1f)
            {
                waitTimeElapsed += Time.deltaTime;
                percentComplete = durationElapsed / slowDuration;
            }
            else
            {
                percentComplete = durationElapsed / duration;
            }

            transform.position = Vector3.Lerp(startPos, endPos, percentComplete);
            if (percentComplete >= 1f)
            {
                moving = false;
                durationElapsed = 0f;
            }
        }
    }
}
