using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotSpeed;
    public int speed;
    public float hInput;
    public float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      hInput = Input.GetAxis("Horizontal"); // left and right movement
      vInput = Input.GetAxis("Vertical"); // Forward and Backward
      
      transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); // move character left and right
      
      transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime); // move character forward and back
      
    }
}
