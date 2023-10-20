using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    

    [SerializeField] private GameObject[] IP_merkezleri;
    [SerializeField] private int ToplamTopSayisi;
    [SerializeField] private int DevrilmesiGerekenObjeSayisi;

    void Update()
    {



        if (Input.GetMouseButton(0)) // sol click alinca
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); //mouse'u takip et


            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Merkez_1")) //tagi merkez_1 olan zincirlere denk gelirsen
                    ZincirTeknikIslem(hit, "Merkez_1");
                else if (hit.collider.CompareTag("Merkez_2")) //tagi merkez_2 olan zincirlere denk gelirsen
                    ZincirTeknikIslem(hit, "Merkez_2");
                else if (hit.collider.CompareTag("Merkez_3")) //tagi merkez_2 olan zincirlere denk gelirsen
                    ZincirTeknikIslem(hit, "Merkez_3");
                else if (hit.collider.CompareTag("Merkez_4")) //tagi merkez_2 olan zincirlere denk gelirsen
                    ZincirTeknikIslem(hit, "Merkez_4");
                else if (hit.collider.CompareTag("Merkez_5")) //tagi merkez_2 olan zincirlere denk gelirsen
                    ZincirTeknikIslem(hit, "Merkez_5");
            }
            
        }
    }
    void ZincirTeknikIslem(RaycastHit2D hit, string HingeAdi)
    {
        hit.collider.gameObject.SetActive(false);

        foreach (var item in IP_merkezleri)
        {
            if (item.GetComponent<Ip_Yonetimi>().HingeAdi == HingeAdi)
            {
                foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                {
                    item2.SetActive(false); // Havuz olarak Yarattigim butun zincirleri o ip merkezindeki kapat dedik.
                }
            }
        }
    }

    public void TopDustu()
    {
        ToplamTopSayisi--;
        if (ToplamTopSayisi == 0)
        {
            if (DevrilmesiGerekenObjeSayisi > 0)
            {
                Debug.Log("LOSE EKRANI");
            }
            else if (DevrilmesiGerekenObjeSayisi == 0)
            {
                Debug.Log("win ekrani");
            }
        }
        else
        {
            if (DevrilmesiGerekenObjeSayisi == 0)
            {
                Debug.Log("win ekrani");
            }
        }
       
    }
    public void HedefObjeDustu()
    {
        DevrilmesiGerekenObjeSayisi--;
        if (ToplamTopSayisi == 0 && DevrilmesiGerekenObjeSayisi == 0)
        {
            Debug.Log("win ekrani");
        }
        else if (ToplamTopSayisi == 0 && DevrilmesiGerekenObjeSayisi > 0)
        {
            Debug.Log("lose ekrani");
        }
    }

}
