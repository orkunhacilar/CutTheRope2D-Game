using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Top _Top;

   
    void Update()
    {



        if (Input.GetMouseButton(0)) // sol click alinca
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); //mouse'u takip et


            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Merkez_1")) //tagi merkez_1 olan zincirlere denk gelirsen
                {
                    //Destroy(hit.collider.gameObject); //hangisine denk geldiysen onu yok et.
                    hit.collider.gameObject.SetActive(false);



                    _Top.HingeKontrol["Merkez_1"].enabled = false;
                    //Kodlari incelersen anlarsin. TOPUN HingeJoint2Dsini kapatiyoruz.
                    //Merkez_1 Adı altında yaratılan Ip_Yonetimi scriptinde gerceklesen son halka ile top arasinda olan baglantisi burda kopmus oluyor. Cunku topunkini kapadik

                }
                if (hit.collider.CompareTag("Merkez_2")) //tagi merkez_2 olan zincirlere denk gelirsen
                {
                    hit.collider.gameObject.SetActive(false);


                    _Top.HingeKontrol["Merkez_2"].enabled = false;
                    //Kodlari incelersen anlarsin. TOPUN HingeJoint2Dsini kapatiyoruz.
                    //Merkez_2 Adı altında yaratılan Ip_Yonetimi scriptinde gerceklesen son halka ile top arasinda olan baglantisi burda kopmus oluyor. Cunku topunkini kapadik
                }
            }
            
        }
    }
}
