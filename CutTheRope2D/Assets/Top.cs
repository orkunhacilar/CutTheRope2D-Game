using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    public float ZincirIleOlanMesafe = 0.2f;
    public void SonZinciriBagla(Rigidbody2D SonZincir)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>(); // Topun HingeJointini aldim.
        joint.autoConfigureConnectedAnchor = false; //Baglantilari normalde otomatik yapiyor once onu kapatalim. Oyle olsun istemiyorum
        joint.connectedBody = SonZincir; //Topuda son zincire bagliyorum.
        joint.anchor = Vector2.zero; // Sıfırlıyorum.
        joint.connectedAnchor = new Vector2(0f, -ZincirIleOlanMesafe); //y si onemli cunku mesafeyi o belirliyo bilerek - veriyorum ki o mesafeyi verebilsin.
    }
}
