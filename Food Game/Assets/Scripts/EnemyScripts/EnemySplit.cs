using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySplit : MonoBehaviour
{
    EnemyHealth getHp;
    public GameObject smallChoc;

    float val = 0.63f; //value of x offset
    float choc1; //x offset for 1st piece
    float choc2; //x offset for second piece

    bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        getHp = GetComponent<EnemyHealth>();
        spawned = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        choc1 = transform.position.x + val;
        choc2 = transform.position.x - val;
        getHp.notChoc = false;
        if (getHp.eHealth <= 0 && !spawned)
        {
            Destroy(gameObject);
            Instantiate(smallChoc, transform.position = new Vector3(choc1, transform.position.y, transform.position.z), Quaternion.identity);
            Instantiate(smallChoc, transform.position = new Vector3(choc2, transform.position.y, transform.position.z), Quaternion.identity);
            spawned = true;
        }
    }
}
