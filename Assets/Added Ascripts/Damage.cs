using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour

{
    public int DamageAmount = 20;
    public Health PlayerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

  private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth.TakeDamage(DamageAmount);
            Destroy(gameObject);
        }
    }
}
