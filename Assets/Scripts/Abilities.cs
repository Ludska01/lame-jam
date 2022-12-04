using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Abilities : MonoBehaviour
{
    [SerializeField]
    private Image abilityImage1;
    [SerializeField]
    private float cooldown1;
    [SerializeField]
    private KeyCode ability1;
    bool isCooldown1 = false;

    [SerializeField]
    private Image abilityImage2;
    [SerializeField]
    private float cooldown2;
    [SerializeField]
    private KeyCode ability2;
    bool isCooldown2 = false;

    [SerializeField]
    private Image abilityImage3;
    [SerializeField]
    private float cooldown3;
    [SerializeField]
    private KeyCode ability3;
    bool isCooldown3 = false;


    [SerializeField]
    private Image abilityImage4;
    [SerializeField]
    private float cooldown4;
    [SerializeField]
    private KeyCode ability4;
    bool isCooldown4 = false;
    // Start is called before the first frame update
    void Start()
    {
        abilityImage1.fillAmount = 0;
        abilityImage2.fillAmount = 0;
        abilityImage3.fillAmount = 0;
        abilityImage4.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Ability1();
        Ability2();
        Ability3();
        Ability4();
    }

    void Ability1()
    {
        if(Input.GetKey(ability1) && isCooldown1 == false)
        {
            isCooldown1 = true;
            abilityImage1.fillAmount = 1;
        }

        if (isCooldown1) {
            abilityImage1.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if (abilityImage1.fillAmount <= 0) {
                abilityImage1.fillAmount = 0;
                isCooldown1 = false;
            }
        }
    }

    void Ability2()
    {
        if (Input.GetKey(ability2) && isCooldown2 == false)
        {
            isCooldown2 = true;
            abilityImage2.fillAmount = 1;
        }

        if (isCooldown2)
        {
            abilityImage2.fillAmount -= 1 / cooldown2 * Time.deltaTime;

            if (abilityImage2.fillAmount <= 0)
            {
                abilityImage2.fillAmount = 0;
                isCooldown2 = false;
            }
        }
    }

    void Ability3()
    {
        if (Input.GetKey(ability3) && isCooldown3 == false)
        {
            isCooldown3 = true;
            abilityImage3.fillAmount = 1;
        }

        if (isCooldown3)
        {
            abilityImage3.fillAmount -= 1 / cooldown3 * Time.deltaTime;

            if (abilityImage3.fillAmount <= 0)
            {
                abilityImage3.fillAmount = 0;
                isCooldown3 = false;
            }
        }
    }

    void Ability4()
    {
        if (Input.GetKey(ability4) && isCooldown4 == false)
        {
            isCooldown4 = true;
            abilityImage4.fillAmount = 1;
        }

        if (isCooldown4)
        {
            abilityImage4.fillAmount -= 1 / cooldown4 * Time.deltaTime;

            if (abilityImage4.fillAmount <= 0)
            {
                abilityImage4.fillAmount = 0;
                isCooldown4 = false;
            }
        }
    }
}
