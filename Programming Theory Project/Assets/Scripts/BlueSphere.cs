using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : BaseCube // INHERITANCE : BlueSphere inherit from BaseCube
{
    public override void OnMouseDown()  //polymorphism 
    {
        ShapeName.SetActive(true);
    }
}
