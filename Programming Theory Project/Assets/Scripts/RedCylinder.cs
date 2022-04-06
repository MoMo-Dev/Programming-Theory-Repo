using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class RedCylinder : BaseCube // INHERITANCE : RedCylinder inherit from BaseCube.
{
    public override void OnMouseOver() //polymorphism 
   {
       shapeObject.SetActive(true);
       ShapeColor.color = Color.red;
   }

   public override void OnMouseExit()
   {
       base.shapeObject.SetActive(false);
       ShapeColor.color = Color.black;
   }
}
