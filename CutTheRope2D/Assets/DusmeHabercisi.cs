using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmeHabercisi : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("HedefObje"))
        {
            _GameManager.HedefObjeDustu();
        }
        else if (collision.CompareTag("Top"))
        {
            _GameManager.TopDustu();
        }
    }
}
