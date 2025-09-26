using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public float hp;
    public int maxHp;
    public bool dead;
    public Image healthBar;

    private void Start()
    {
        hp = maxHp;
        healthBar.fillAmount = 1;
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        Debug.Log("Damage taken : " + damage + ", new hp = " + hp);

        //Cast = conversion en float : (float)variable
        healthBar.fillAmount = hp / (float)maxHp;

        if(hp <= 0)
        {
            dead = true;
            Debug.Log("Die");
        }
    }

}
