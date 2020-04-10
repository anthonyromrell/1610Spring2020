using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndDamage : MonoBehaviour
{
    public int damagePower = 10;
    public int health = 100;
    public Text healthText;
    public float attackTime = 1f;
    private WaitForSeconds waitObj;
    private bool canAttack;

    private void Start()
    {
        healthText.text = health.ToString();
        waitObj = new WaitForSeconds(attackTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        var otherHealthAndDamage = GetComponent<HealthAndDamage>();
        
        canAttack = true;
        while (canAttack)
        {
            otherHealthAndDamage.health -= damagePower;
            healthText.text = health.ToString();
            yield return waitObj;
            if (health <= 0)
            {
                Destroy(transform.parent.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canAttack = false;
    }
}