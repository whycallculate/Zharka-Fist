using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{

    public event System.Action OnTookDamage;
    public float maxHealth {  get; private set; }
    
    public float currentHealth { get; private set; }
    private int strHpValue = 15;

    private void Awake()
    {
    }
    public void SetMaxHealth(int maxHealth)
    {
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }

    public float CallculateHealthWithStat(int str)
    {
        float newStatHpValue = str * strHpValue;
        maxHealth += newStatHpValue;
        currentHealth = maxHealth;
        return maxHealth;
    }

    
    public float DecreaseHealth(float value)
    {
        if (value > maxHealth) 
        {
            return 0;
        }
        if (currentHealth < 0)
        {
            currentHealth = 0;
            OnTookDamage.Invoke();
            return currentHealth;
        }
        currentHealth -= value;
        OnTookDamage?.Invoke();
        return currentHealth;
    }

    public float IncreaseHealth(int value)
    {
        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            OnTookDamage.Invoke();
            return currentHealth;

        }
        currentHealth += value;
        OnTookDamage.Invoke();
        return currentHealth;
    }


}
