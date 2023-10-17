using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
  

    public Dictionary<string, HingeJoint2D> HingeKontrol = new Dictionary<string, HingeJoint2D>(); //MAP YAPISI KULLANALIM

    public void SonZinciriBagla(Rigidbody2D SonZincir, string HingeAdi)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>(); // Topun HingeJointini aldim.
        HingeKontrol.Add(HingeAdi, joint);
        joint.autoConfigureConnectedAnchor = false; //Baglantilari normalde otomatik yapiyor once onu kapatalim. Oyle olsun istemiyorum
        joint.connectedBody = SonZincir; //Topuda son zincire bagliyorum.
        joint.anchor = Vector2.zero; // Sıfırlıyorum.
        joint.connectedAnchor = new Vector2(0f, -.2f); //y si onemli cunku mesafeyi o belirliyo bilerek - veriyorum ki o mesafeyi verebilsin.
    }
}
