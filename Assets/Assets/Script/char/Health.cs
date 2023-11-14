using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currHealth {get; private set; }
    private Animator anim;
    public GameObject GameOverUI;


    // Start is called before the first frame update
    void Awake()
    {
        currHealth = startingHealth;
        anim = GetComponent<Animator>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(1);
        }
    }

    public void  TakeDamage(float _damage)
    {
        currHealth = Mathf.Clamp(currHealth - _damage, 0, startingHealth);

        if (currHealth <= 0)
        {
            anim.SetTrigger("mati");
            GetComponent<Gerak>().enabled = false;
            GameOverUI.SetActive(true);
        } 
    }

    public void AddHealth(float _value)
    {
        currHealth = Mathf.Clamp(currHealth + _value, 0, startingHealth);
    }
}
