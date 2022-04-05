using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BaseCube : MonoBehaviour
{
    public GameObject greenCube;
    public GameObject ShapeName;


    public virtual void OnMouseDown() //polymorphism 
    {
        ShapeName.SetActive(true);
    }

}
