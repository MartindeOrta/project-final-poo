using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{
    public string myFood;
    public string seleccionFood;
    public float run;
    // Start is called before the first frame update
    void Start()
    {
        run = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void  Eat(Vector3 positionPlate, bool fullPlate)

    {       if (fullPlate)
        {
          
            transform.Translate(positionPlate * 1 * Time.deltaTime);
            run = 1;
         
        }
           }
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            Destroy(other.gameObject);
            transform.Translate(Vector3.zero);
            run = 0;

        }

    
    }
}

