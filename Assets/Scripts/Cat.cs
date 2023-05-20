using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE
public class Cat : Animal
{

    public Cat()
    {
        this.Name = "Cat";
        this.Sound = "Meow";
        this.ProjectedHealth = 80;
        this.Health = 100;
    }


//POLYMORPHISM
 public override void Talk()
  {
    
    
    Debug.Log(this.Name + " " + this.Sound);
    Debug.Log(this.Name + " my projected health is " + this.ProjectedHealth);
    Debug.Log(this.Name + " my non-projected health is " + this.Health);

  }

    public override void TakeDamage()
    {
        this.ProjectedHealth -= 1;
        this.Health -= 1;
        Debug.Log("Projected health is now " + this.ProjectedHealth);
        Debug.Log("Non-projected health is now " + this.Health);
    }

}
