using System;
using System.Collections.Generic;

public class GameObject
{
  public static List<GameObject> objects = new List<GameObject>();


  public GameObject()
  {
    objects.Add(this);
  }


}