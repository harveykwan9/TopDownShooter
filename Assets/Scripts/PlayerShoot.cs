using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public Rigidbody bulletObject;
    public float attackDelay = 5;
    public int bulletSpeed = 20;
    private float nextAttackTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0)) {
            if (attackDelay < nextAttackTime){
                fire();
            } else {
                nextAttackTime = Time.fixedDeltaTime + attackDelay;
            }
        }
        
    }

    void FixedUpdate() {

        

    }

    void fire() {
        Rigidbody newBullet = Instantiate(bulletObject, transform.position, Quaternion.identity) as Rigidbody;
        newBullet.AddForce(transform.forward * bulletSpeed, ForceMode.VelocityChange);
    }
}
