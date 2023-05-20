using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public abstract class Animal : MonoBehaviour
{
    //ABSTRACTION
    public abstract void Talk();
    
    private string m_Sound;

    private string m_name;

    private int m_ProjectedHealth;
    private int m_Health;

    public TextMeshProUGUI ProjectedHealthText;
    public TextMeshProUGUI HealthText;
    


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


    public int Health
    {
        get{return m_Health;}
        set{m_Health = value;}


    }

   public int ProjectedHealth
    {
        get{return m_ProjectedHealth - 1;}
        set{m_ProjectedHealth = value + 1;}


    }
    // Start is called before the first frame update
    void Start()
    {
      Talk();  
      UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            TakeDamage();
            UpdateHealthText();
        }
    }

    //ABSTRACTION 
    //Animals can have their own TakeDamage
    public virtual void TakeDamage()
    {

    }

    private void UpdateHealthText()
    {
        ProjectedHealthText.text = "Projected health " + ProjectedHealth.ToString();
        HealthText.text = "Non-projected health " + Health.ToString();


    }
}
