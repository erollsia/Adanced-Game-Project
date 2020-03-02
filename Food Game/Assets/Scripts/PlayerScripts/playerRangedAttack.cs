using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRangedAttack : MonoBehaviour
{
    public float offset;

    public GameObject projectile;
    public Transform shotPoint;

    private float timedShots;
    public float startTimeShots;

    // Update is called once per frame
    private void Update()
    {
        // Weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        //Projectile location
        if(timedShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timedShots = startTimeShots;
            }
        }
        else
        {
            timedShots -= Time.deltaTime;
        }
    }
}
