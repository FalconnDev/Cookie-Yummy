using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balonKontrol : MonoBehaviour
{
    oyunKontrol OyunKontrolScripti;
    public GameObject patlama;

    void Start()
    {
        OyunKontrolScripti=GameObject.Find("GameObject").GetComponent<oyunKontrol>();
    }

    void OnMouseDown()
    {
        GameObject go= Instantiate (patlama,transform.position,transform.rotation) as GameObject;
        
        Destroy(this.gameObject);
        Destroy(go,0.5f);
        OyunKontrolScripti.BalonEkle();
    }

}
