using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ip_Yonetimi : MonoBehaviour
{

    public Rigidbody2D Ilk_Kanca;

    public Top _Top;

    public int BaglantiSayisi = 5;

    public GameObject BaglantiPrefab;
    
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
            GameObject Baglanti = Instantiate(BaglantiPrefab, transform);
            HingeJoint2D joint = Baglanti.GetComponent<HingeJoint2D>();
            joint.connectedBody = OncekiBaglanti;

            if(i < BaglantiSayisi -1)
            {
                OncekiBaglanti = Baglanti.GetComponent<Rigidbody2D>();
            }
            else // BURASI
            {
                _Top.SonZinciriBagla(Baglanti.GetComponent<Rigidbody2D>()); //Zincirleri Bagladik sira son zincere topu baglamada.
            }
        }
    }
    
}
