using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BaseCube : MonoBehaviour
{
   //[SerializeField] private GameObject greenCube;

   public GameObject shapeObject;
   [SerializeField] private Material shapeColor;

   public Material ShapeColor // ENCAPSULATION
   {
       get
       {
           return shapeColor;
       }
   }
   
   private void Start()
   {
       shapeObject.SetActive(false);
       
   }

    public virtual void OnMouseOver() //polymorphism 
    {
        shapeObject.SetActive(true);
        ShapeColor.color = Color.green;
    }

    public virtual void OnMouseExit()
    {
        shapeObject.SetActive(false);
        ShapeColor.color = Color.black;
    }
}
