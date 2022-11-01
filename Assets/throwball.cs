using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwball : MonoBehaviour
{
  public float power;
  public float spinp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
      private float moveSp = 4f;
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        float horimove = Input.GetAxis("Horizontal");
        
        transform.position = transform.position+ new Vector3(horimove * moveSp * Time.deltaTime, 0, 0);
        if(Input.GetKey("w")){
          power = power-10;
        }
        else if(Input.GetKey("s")){
           power = power+10;
        }
        else if(Input.GetKey("e"))
        {
          spinp = spinp+10;
          
        }
        else if(Input.GetKey("q")){
          spinp = spinp-10;
        
        }
        else if(Input.GetKey("space")){       
             rb.AddForce(new Vector3(0.0f,0.0f,power));
             rb.AddTorque(new Vector3(0,0,spinp));
        }
    }
}
