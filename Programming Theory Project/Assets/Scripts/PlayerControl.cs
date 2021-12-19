using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Plates plates;

    void Update()
    {    
        if (Input.GetMouseButtonDown(0))
        {
            plates.OnMouseDown();
        }
    }

  
}
