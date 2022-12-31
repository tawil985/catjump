using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public GameObject arrowPrefab; 
    float span = 1.0f;             
    float delta = 0;               
    public GameObject hpGauge;     

    void Update()
    {
        delta += Time.deltaTime;  
        if (delta > span) 
        {
            delta = 0;         
            int px = Random.Range(-5, 5); 
            Instantiate(arrowPrefab, new Vector3(px, 10, 0), Quaternion.identity);
        }
    }

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
