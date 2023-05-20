using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Animal : MonoBehaviour
{
    //ABSTRACTION
    public abstract void Talk();
    
    private string m_Sound;

    private string m_name;



    public string Sound
    {
        get{return m_Sound;}
        set{m_Sound = value;}
        
       
    }

    //ENCAPSULATION
    public string Name
    {
        get{return m_name;}
        set{
            if(value.Length > 10)
            {
                Debug.Log("Name has been cut to 10 characters");
                m_name = value.Substring(0, Mathf.Min(value.Length, 10));
            }
            else
            {
                m_name = value;
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
      Talk();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
