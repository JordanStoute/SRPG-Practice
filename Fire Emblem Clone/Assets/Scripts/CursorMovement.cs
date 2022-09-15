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
            if (Input.GetKeyDown(KeyCode.D))
            {
                startPos = transform.position;
                endPos = new Vector3(startPos.x + 1f, startPos.y, startPos.z);
                moving = true;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                startPos = transform.position;
                endPos = new Vector3(startPos.x - 1f, startPos.y, startPos.z);
                moving = true;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                startPos = transform.position;
                endPos = new Vector3(startPos.x, startPos.y, startPos.z + 1f);
                moving = true;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                startPos = transform.position;
                endPos = new Vector3(startPos.x, startPos.y, startPos.z - 1f);
                moving = true;
            }
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
