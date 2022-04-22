using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float moveScale = 0;
    float rotationScale = 0;

    [SerializeField]
    float moveSepeed = 2;
    [SerializeField]
    float rotationSpeed = 3;

   
    // Update is called once per frame
    void Update()
    {
        moveScale = Input.GetAxis("Horizontal");
        rotationScale = Input.GetAxis("Vertical");
        transform.Rotate(0f,-moveScale * moveSepeed * Time.deltaTime, 0f);
        transform.Translate(0f, 0f,-rotationScale * rotationSpeed * Time.deltaTime);
    }
}
