using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    Rigidbody rb;
    ParticleSystem ps;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        ps = this.GetComponent<ParticleSystem>();
    }

    public void Shoot(Vector3 dirForce)
    {
        this.rb.AddForce(dirForce);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "target")
        {
            this.rb.isKinematic = true;
            this.ps.Play();
        }
    }
}
