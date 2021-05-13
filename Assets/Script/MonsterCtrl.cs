using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public GameObject monsterPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateMonster", 0.1f, Random.Range(0.5f, 2f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateMonster()
    {
        float x = 8;
        float y = Random.Range(-4, 4);
        GameObject monster = Instantiate(monsterPrefab);
        monster.transform.position = new Vector3(x, y, 0);
    }
}
