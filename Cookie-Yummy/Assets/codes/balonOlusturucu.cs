using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi=1f;
    float zamanSayici=0f;
    void Start()
    {
        
    }

    void Update()
    {
        zamanSayici-=Time.deltaTime;
        if(zamanSayici<0)
        {
            GameObject go=Instantiate (balon, new Vector3(Random.Range(-2.2f,2.2f),-6f,0),Quaternion.Euler(0,0,0));
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(250f,500f),0));
            zamanSayici=balonOlusturmaSuresi;

        }
    }
}
