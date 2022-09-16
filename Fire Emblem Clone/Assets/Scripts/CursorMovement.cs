using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    private Vector3 endPos;
    private Vector3 startPos;
    public float duration = 0.5f;
    private float timeElapsed;
    private bool moving = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!moving)
        {
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
            timeElapsed += Time.deltaTime;
            float percentComplete = timeElapsed / duration;

            transform.position = Vector3.Lerp(startPos, endPos, percentComplete);
            if (percentComplete >= 1f)
            {
                moving = false;
                timeElapsed = 0f;
            }
        }
    }
}
