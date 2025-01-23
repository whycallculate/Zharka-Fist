using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterUI : MonoBehaviour
{
    public CharacterController characterController;
    public TextMeshProUGUI maxHealthUIText;
    private void Start()
    {
        maxHealthUIText.text = characterController._Health.currentHealth.ToString();
        characterController._Health.OnTookDamage += DecreseHealthUI;

    }
    private void OnEnable()
    {
    }
    private void OnDisable()
    {
        characterController._Health.OnTookDamage -= DecreseHealthUI;

    }
    void DecreseHealthUI()
    {
        maxHealthUIText.text = characterController._Health.currentHealth.ToString();

    }
}
