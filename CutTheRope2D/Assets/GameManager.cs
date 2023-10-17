using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   

   
    void Update()
    {



        if (Input.GetMouseButton(0)) // sol click alinca
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); //mouse'u takip et


            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Merkez_1")) //tagi merkez_1 olan zincirlere denk gelirsen
                {
                    Destroy(hit.collider.gameObject); //hangisine denk geldiysen onu yok et.
                }
                if (hit.collider.CompareTag("Merkez_2")) //tagi merkez_1 olan zincirlere denk gelirsen
                {
                    Destroy(hit.collider.gameObject); //hangisine denk geldiysen onu yok et.
                }
            }
            
        }
    }
}
