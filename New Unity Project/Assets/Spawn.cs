using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List<GameObject> Collectables;
    public GameObject[] Eneimes;
    private List<Vector3> Transforms = new List<Vector3>();
    private int repeat = 0;
    void Start()
    {
        Vector3 Player = new Vector3(0f,0.93f, 0f);
        Transforms.Add(Player);
        SpawnEnemy();
        SpawnCollectables();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void remove(int Index)
    {

    }

    void SpawnEnemy()
    {
        while(repeat != Eneimes.Length)
        {
             Vector3 pos = new Vector3(Random.Range(-8, 8), 1, Random.Range(-9, 9));
            if (Transforms.Contains(pos) == false)
            {
                Instantiate(Eneimes[repeat], pos, Quaternion.identity);
                Transforms.Add(pos);
                repeat += 1;
            }
        }
    }

    void SpawnCollectables()
    {
        repeat = 0;
        while (repeat != Collectables.Count)
        {
            Vector3 p = new Vector3(Random.Range(-8, 8), 1, Random.Range(-9, 9));
            if (Transforms.Contains(p) == false)
            {
                Instantiate(Collectables[repeat], p, Quaternion.identity);
                Transforms.Add(p);
                repeat += 1;
            }
        }
    }

}
