using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class RedCylinder : BaseCube // INHERITANCE : RedCylinder inherit from BaseCube.
{
   
   public override void OnMouseDown() //polymorphism 
   {
      ShapeName.SetActive(true);
   }

}
