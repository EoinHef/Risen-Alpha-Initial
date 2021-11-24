using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform launcher;
    public float fireForce = 500;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fireBullet();
        }
    }
    private void fireBullet()
    {
        var projectileInstance = Instantiate(
            bulletPrefab,
            launcher.position,
            launcher.rotation);

        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * fireForce,ForceMode.Impulse);
        Destroy(projectileInstance.gameObject,3f);
    }
    
}
