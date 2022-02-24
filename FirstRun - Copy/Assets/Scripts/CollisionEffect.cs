//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CollisionEffect : MonoBehaviour
{
    public ParticleSystem particle;
    public GameObject Player;
    public MeshRenderer mR;

    // Change color after collision with player
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            //GetComponent<Renderer>().material.color = Player.GetComponent<Renderer>().material.GetColor("red");
            mR.material.color = new Color(1,0,0,1);
            CreateParticles();
            
        }
    }

    void CreateParticles()
    {
        particle.Play();
    }

    
}
