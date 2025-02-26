using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEnemy : MonoBehaviour
{
    public GameObject Bullet;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if( time >=3 ){
            MakeEnemies();
            time = 0f;

        }
    }
    
    public void MakeEnemies(){
        GameObject B = Instantiate(Bullet, new Vector3 (Random.Range(-8f, 8f), 6.5f, 0f), Quaternion.identity);
        Destroy(B, 7f);
    }

    


}
