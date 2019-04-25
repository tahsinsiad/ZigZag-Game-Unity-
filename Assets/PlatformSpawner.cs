using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    public GameObject platform;
    public GameObject diamonds;
    Vector3 lastpos;
    float size;
    public bool gameOver;

	// Use this for initialization
	void Start () {
        lastpos = platform.transform.position;
        size = platform.transform.localScale.x;

        for(int i = 0; i< 20; i++)
        {
            SpawnPlatforms();
        }

        
		
	}

    public void PlatformSpawnignStart()
    {
        InvokeRepeating("SpawnPlatforms", .1f, .2f);
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager1.instance.gameOver == true)
        {
            CancelInvoke("SpawnPlatforms");
        }
	}

    void SpawnPlatforms()
    {
        int rand = Random.Range(0, 6);
        if(rand < 3)
        {
            SpawnX();
        }
        else if(rand >= 3)
        {
            SpawnZ();
        }

    }

    void SpawnX()
    {
        Vector3 pos = lastpos;
        pos.x += size;
        lastpos = pos;
        Instantiate(platform, pos, Quaternion.identity);

        int rand = Random.Range(0, 4);
        if(rand < 1)
        {
            Instantiate(diamonds, new Vector3(pos.x,pos.y + 1,pos.z), diamonds.transform.rotation);
        }

    }

    void SpawnZ()
    {
        Vector3 pos = lastpos;
        pos.z += size;
        lastpos = pos;
        Instantiate(platform, pos, Quaternion.identity);
        int rand = Random.Range(0, 4);
        if (rand < 1)
        {
            Instantiate(diamonds, new Vector3(pos.x, pos.y + 1, pos.z), diamonds.transform.rotation);
        }
    }
}
