using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cartooch : MonoBehaviour
{


    public Transform Gun;

    public int y = 0;

    Vector2 direction;

    public GameObject Bullet;

    public float BulletSpeed;

    public Transform ShootPoint;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy1" || col.gameObject.name == "Enemy2")
        {
            y++;
        }
        if (y == 10)
        {
            Destroy(col.gameObject);

        }

        void Start()
        {

        }
       
        
        void Update()
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = mousePos - (Vector2)Gun.position;
            FaceMouse();
            if (Input.GetKeyDown("s"))
            {
                Shoot();
            }
        }
        void FaceMouse()
        {
            Gun.transform.right = direction;
        }
        void Shoot()
        {
            GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
            BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
            Debug.Log("shpoot");
        }

    }
}
