using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 2.0f;

    private GameObject game;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("Game");
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.Translate(-step, 0, 0);

        Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
        if (sp.y < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Bullet")){
            game.SendMessage("AddScore", 1);
            Destroy(this.gameObject);
        }
    }
}
