using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodSplatter : MonoBehaviour
{

    private SpriteRenderer rend;
    [SerializeField] Sprite[] blood;
    [SerializeField]
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponentInChildren<SpriteRenderer>();
        int rand = Random.Range(0, blood.Length);
        rend.sprite = blood[rand];
        StartCoroutine(WaitToDestory(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitToDestory(float time){
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
