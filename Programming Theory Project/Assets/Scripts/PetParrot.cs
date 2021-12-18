using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetParrot : pet
{
    
  
    public float x;
    public float y;
    public float z;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {    
        myFood = "Parrot";

        anim = GetComponent<Animator>();
        plate = GameObject.Find("PlateParrot").GetComponent<Plates>();
        myFood = "Parrot";
    }

    // Update is called once per frame
    void Update()
    {
        
        Eat(new Vector3(x,y,z), plate.fullPlate);
        Move();
       
    }
    public void Move()
    {
        if (transform.position.z >  -3.8 && transform.position.z< 0 )
        {
            anim.SetFloat("VelX", 1);
        }
        else { anim.SetFloat("VelX", 0);
            
        }
        
    }
}
