using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    Vector2 startPos, endPos;
    void FixedUpdate()
    {  
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
    }
    private void Update()
    {
        
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                startPos = Input.GetTouch(0).position;

            }
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                endPos = Input.GetTouch(0).position;

              if (startPos.x > endPos.x && transform.position.x > -4)
                {
                    transform.position = new Vector3(transform.position.x - 2f , transform.position.y, transform.position.z);
                }
                else if (startPos.x < endPos.x && transform.position.x < 0)
                {
                    transform.position = new Vector3(transform.position.x + 2f, transform.position.y, transform.position.z);
                }
            }
            
       
       
    }
}
