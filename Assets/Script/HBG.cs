using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HBG : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    Vector3 screenP;
    Vector3 dir;
    Vector3 mouseSP;
    void Start()
    {
        screenP = Camera.main.WorldToScreenPoint(transform.position);
        transform.position = new Vector3(-8, 0, 0);
        // bulletPrefab = transform.Find("BulletPrefab").gameObject;
        transform.eulerAngles = new Vector3(0, 0, -90);
        // dir = new Vector3(0, 0, 0);
        // mouseP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Time Delta: " + Time.deltaTime);
        // float rotE = Time.deltaTime * 10f;
        // transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + rotE);
        // if (Input.GetMouseButtonDown(0)){
        //     Vector3 mouseWP = Input.mousePosition;
        //     Debug.Log("x: " + mouseWP.x.ToString("F3"));
        //     Debug.Log("y: " + mouseWP.y.ToString("F3"));
        //     mouseP = Camera.main.ScreenToWorldPoint(mouseWP);
        //     mouseP.z = 0;
        // }
        // Vector3 dis = mouseP - transform.position;
        // dir = dis.normalized;
        // Debug.Log(dis.magnitude);
        // if (dis.magnitude > 0.1f){
        //     transform.Translate(dir * Time.deltaTime * 10f, Space.Self);
        // }

        Vector3 mouseWP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWP.z = 0;
        Vector3 dir = mouseWP - transform.position;
        transform.up = dir;

        if (Input.GetMouseButtonDown(0)){
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.up = dir;
        }
    }
}
