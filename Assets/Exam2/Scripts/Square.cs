using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
   private int Side = 3;
    public override float CalculateArea()
    {
        throw new System.NotImplementedException();
      
    }
    
    private void Start()
    {
        CalculateArea();

    }
}
