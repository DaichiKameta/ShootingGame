using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    private GameObject[] enemy;

    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //シーンに1匹もEnemyがいなくなったら
        if(enemy.Length == 0)
        {
            //パネルを表示させる
            panel.SetActive(true);
        }
    }
}
