using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class oyunKontrol : MonoBehaviour
{
    public TextMeshProUGUI zamanText,balonText;
    public float zamanSayici=60;
    int patlayanBalon=0;
    public GameObject patlama;
    public GameObject deathScreen;

    void Start()
    {
        balonText.text="Puan:" + patlayanBalon;
        
    }

    void Update()
    {
        if (zamanSayici>0)
        {
            zamanSayici-=Time.deltaTime;
            zamanText.text="Süre :"+(int)zamanSayici;


        }
        else
        {
            GameObject[] go=GameObject.FindGameObjectsWithTag("Puan");
            for(int i=0; i< go.Length; i++)
            {
                Instantiate (patlama,go[i].transform.position,go[i].transform.rotation);
                Destroy(go[i]);
                deathScreen.SetActive(true);
            }
        }
        
    }

    public void BalonEkle()
    {
        patlayanBalon+=1;
        balonText.text="Puan : "+ patlayanBalon;
    }

}
