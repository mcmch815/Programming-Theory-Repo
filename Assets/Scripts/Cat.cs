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
    }


//POLYMORPHISM
 public override void Talk()
  {
    
    
    Debug.Log(this.Name + " " + this.Sound);

  }



}
