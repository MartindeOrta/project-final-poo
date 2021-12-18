using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetCat : pet
{
    private Animator ani;
   
  
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
     
        plate = GameObject.Find("PlateCat").GetComponent<Plates>();
        myFood = "Cat";
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 lookDirection = -(plate.transform.position + transform.position).normalized;
        Eat(lookDirection, plate.fullPlate);
        if (plate.fullPlate)
        {
            ani.SetFloat("VelX", 1);
        }
        else { ani.SetFloat("VelX", 0); }

    }
  
}    
