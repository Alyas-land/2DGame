using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    public GameObject NinjsWeapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    public void Movement(){
        if (Input.GetKey(KeyCode.A)){
            transform.position -= new Vector3(10 * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(10 * Time.deltaTime, 0f, 0f);
        }
    }

    public void Shooting(){
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject B = Instantiate(NinjsWeapon, GameObject.Find("position").transform.position, Quaternion.identity);
            B.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000);
            Destroy(B, 5f);
        }
    }
}
