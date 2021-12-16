using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{
    public string myFood;
    public string seleccionFood;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   public void  Eat(Vector3 positionPlate, bool fullPlate)

    {       if (fullPlate)
        {
          
            transform.Translate(positionPlate * 1 * Time.deltaTime);
         
        }
           }
    public void Sleep()
    {

    }
}

