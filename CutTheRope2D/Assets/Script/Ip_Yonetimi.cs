using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ip_Yonetimi : MonoBehaviour
{

    [SerializeField] private Rigidbody2D Ilk_Kanca;

    [SerializeField] private Top _Top;

    [SerializeField] private int BaglantiSayisi = 5;

    public string HingeAdi;

   

    public GameObject[] BaglantiHavuzu;
    
    void Start()
    {
        Ip_Olustur();
    }

    void Ip_Olustur() //BAGLANTILAR RIGIDBODY 2DLER ILE GERCEKLESTIRILIYOR.
    {
        //BURASI yazdigim yere kadar zincirleri birbirlerine baglamaya calisiyoruz aslinda.
        Rigidbody2D OncekiBaglanti = Ilk_Kanca;

        for (int i = 0; i < BaglantiSayisi; i++)
        {
            BaglantiHavuzu[i].SetActive(true);
            

            HingeJoint2D joint = BaglantiHavuzu[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = OncekiBaglanti;

            if(i < BaglantiSayisi -1)
            {
                OncekiBaglanti = BaglantiHavuzu[i].GetComponent<Rigidbody2D>();
            }
            else // BURASI
            {
                _Top.SonZinciriBagla(BaglantiHavuzu[i].GetComponent<Rigidbody2D>(), HingeAdi); //Zincirleri Bagladik sira son zincere topu baglamada.
            }
        }
    }
    
}
