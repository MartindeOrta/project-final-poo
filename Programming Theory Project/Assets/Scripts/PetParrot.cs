using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetParrot : pet
{
    
    public Plates plate;
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
        Move(plate.fullPlate);
       
    }
    public void Move(bool full)
    {
        if (full)
        {
            anim.SetFloat("VelX", 1);
        }
        else { anim.SetFloat("VelX", 0); }
        
    }
}
