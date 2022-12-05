using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseScript : MonoBehaviour
{
	[SerializeField]
	private int maxHealth = 100;
	private int currentHealth;

	public HealthBarScript healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

    private void Update()
    {
        if (currentHealth <= 0)
        {
			SceneManager.LoadScene("EndGame");
        }
    }
    void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Zombie" || collision.collider.tag == "BigZombie")
		{
			collision.collider.SendMessage("Die");
			TakeDamage(1);
		}
	}
}
