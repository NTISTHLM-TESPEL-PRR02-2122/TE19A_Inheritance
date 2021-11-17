using System;

public class SuperGoomba : Goomba
{

  public SuperGoomba(): base(300)
  {
    hp = 2000;
    movementX += 600;
  }

}