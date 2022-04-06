using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphere : BaseCube // INHERITANCE : BlueSphere inherit from BaseCube
{
    public override void OnMouseOver()  //polymorphism 
    {
        shapeObject.SetActive(true);
        ShapeColor.color = Color.blue;
    }
    public override void OnMouseExit()
    {
        base.shapeObject.SetActive(false);
        ShapeColor.color = Color.black;
    }
}
