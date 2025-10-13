using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float maxhealth = 10.0f;
    [SerializeField] float health = 10.0f;
    [SerializeField] Slider slider;
    [SerializeField] State state;
    bool isDead = false;
    float Damage;

    void Start()
    {
        health = maxhealth;
        slider.value = 1.0f;
        Damage = slider.value / maxhealth;
    }

    public void GetHurt(float strength)
    {
        if (!isDead)
        {
            slider.value -= Damage * strength;
            health -= strength;
            state.Damaged();

            if (health <= 0)
            {
                Debug.Log("Dead");
                state.Dead();
                slider.gameObject.SetActive(false);
                isDead = true;
            }
        }
    }
}
