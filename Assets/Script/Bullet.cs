using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // transform.parent = transform.Find("/Mo");
        // transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Time.deltaTime * speed;
        
        if (InsideScreen()){
            transform.Translate(0, dis, 0);
        } else {
            Destroy(this.gameObject);
        }
    }

    bool InsideScreen()
    {
        Vector3 wp = Camera.main.WorldToScreenPoint(transform.position);
        return wp.x <= Screen.width && wp.y <= Screen.height && wp.x >= 0 && wp.y >= 0;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Monster")){
            Destroy(this.gameObject);
        }
    }
}
