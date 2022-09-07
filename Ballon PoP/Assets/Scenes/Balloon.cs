using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{ 
    public int scoreToGive = 100; 
    
    public int clicktoPop = 3;
    
    public float scaleToIncrease = 0.10f;




 void OnMouseDown()
 { 
    clickToPop -= 1;
    
    
    transform.localscale += Vector3.one * scaleToIncrease;



    if(clickToPop == 0)
    {
    
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
