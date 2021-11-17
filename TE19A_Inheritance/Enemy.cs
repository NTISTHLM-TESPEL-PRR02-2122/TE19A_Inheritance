using System;

public class Enemy : GameObject
{
  public int hp = 100;
  public int coolness;
  public int x;
  public int y;
  public float cringeFactor;

  protected int defense = 100;

  public int movementX = 1;

  public virtual void Update()
  {
    x += movementX;
  }
}