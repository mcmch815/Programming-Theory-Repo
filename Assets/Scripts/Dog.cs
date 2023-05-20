using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Dog : Animal
{

    public Dog()
    {
        this.Name = "Dog";
        this.Sound = "Woof!";
    }


//POLYMORPHISM
 public override void Talk()
  {
    
    
    Debug.Log(this.Name + " " + this.Sound + this.Sound);

  }



}
