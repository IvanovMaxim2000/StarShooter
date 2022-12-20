using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public static bool canShooting { get; private set; }
    public Slider staminaBar;
    public static Stamina instance;
    private int _maxStamina = 3;
    private int _currentStamina;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        _currentStamina = _maxStamina;
        staminaBar.maxValue = _maxStamina;
        staminaBar.value = _maxStamina;
        canShooting = true;
    }

    public void AddStamina(ITarget target)
    {
        if (staminaBar.value + target.ExtraStamina <= _maxStamina)
        {
            _currentStamina += target.ExtraStamina;
            staminaBar.value += target.ExtraStamina;
        }
        else staminaBar.value = _maxStamina;
    }
    public void UseStamina(int amount)
    {
        if (staminaBar.value - amount > 0)
        {
            _currentStamina -= amount;
            staminaBar.value -= amount;
        }
        else
        {
            staminaBar.value = 0;
            StartCoroutine(WaitRenegiration());
        }
    }
    private IEnumerator WaitRenegiration()
    {
        canShooting = false;
        yield return new WaitForSeconds(3);
        canShooting = true;
        _currentStamina = _maxStamina;
        staminaBar.value = _currentStamina;
    }
}
