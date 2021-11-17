using System;
using System.Collections.Generic;


for (int i = 0; i < 100; i++)
{
    new Goomba(i);
}

new SuperGoomba();

Console.WriteLine(GameObject.objects.Count);
Console.ReadLine();


// List<Enemy> enemies = new List<Enemy>();

// new SuperGoomba();


// enemies.Add(new Goomba(5));
// enemies.Add(new SuperGoomba());

// foreach(Enemy e in enemies)
// {
//   e.Update();
// }


// Enemy e1 = new SuperGoomba();


// Goomba g1 = new SuperGoomba();
// SuperGoomba sg1 = new SuperGoomba();

// Console.WriteLine(sg1.movementX);

// Console.ReadLine();


// Goomba g1 = new Goomba();

// while (true)
// {
//   g1.Update();
//   System.Console.WriteLine(g1.x);
// }