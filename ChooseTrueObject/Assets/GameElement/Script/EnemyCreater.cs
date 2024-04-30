using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreater : MonoBehaviour
{
   public List<GameObject> creater;
    private void Start()
    {
        InvokeRepeating("CreateEnemy", 3f, 4f);
    }
    void CreateEnemy()
    {
        int random = Random.Range(0, creater.Count);
        
    }
}
