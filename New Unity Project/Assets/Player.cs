using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    bool move = true;
    public Spawn spawn;

    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        transform.position = pos;
        if (Input.GetKey(KeyCode.W) && move == true)
        {
            pos.z += .01f;
        }
        if (Input.GetKey(KeyCode.S) && move == true)
        {
            pos.z -= .01f;
        }
        if (Input.GetKey(KeyCode.A) && move == true)
        {
            pos.x -= .01f;
        }
        if (Input.GetKey(KeyCode.D) && move == true)
        {
            pos.x += .01f;
        }
        transform.position = pos;
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Collectable")
        {
            spawn.Collectables.RemoveAt(0);
            Destroy(other.gameObject);

        }

        if(other.tag == "Enemy")
        {
            Debug.Log("Enemy");
            move = false;
        }

    }
}
