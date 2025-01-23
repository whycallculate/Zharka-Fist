using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterController : MonoBehaviour 
{
    [SerializeField] int maxHealth = 100;

    public CharacterClass characterClass;
    public CharacterHealth _Health;

    private void Awake()
    {
        _Health = gameObject.GetComponent<CharacterHealth>();
        _Health.SetMaxHealth(maxHealth);
        _Health.CallculateHealthWithStat(10);

    }


    private void Update()
    {
        Debug.Log(_Health.currentHealth);
    }



}
