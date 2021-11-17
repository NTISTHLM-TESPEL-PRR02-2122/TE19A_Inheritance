using System;

public class Goomba : Enemy
{
  public int movementY = 1;

  public Goomba(int mX)
  {
    movementX = mX;
  }

  public override void Update()
  {
    // base.Update();

    y += movementY;
  }
}