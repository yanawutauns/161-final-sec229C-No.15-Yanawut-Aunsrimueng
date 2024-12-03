using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public string shapeName;
    protected string ShapeName
    {
        get { return shapeName; } set { shapeName = value; }
    }
    public void Init(string shapeName)
    {
        this.shapeName = shapeName;
    }

    public abstract float CalculateArea();

    public virtual void Resize() 
    {
        
    }

    public void Draw()
    {
        
    }
}

