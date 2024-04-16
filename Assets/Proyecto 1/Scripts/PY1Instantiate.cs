using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PY1Instantiate : MonoBehaviour
{
    public GameObject InstantiateGO;

    public float SpawnRate;

    public float NextTimeToRespawn;
   
    private void Update()
    {
        if (Time.time > NextTimeToRespawn)
        {
            Vector3 position = new Vector3();
            position.x = Random.Range(-4.89f,4.89f);
            position.y = 8.63f;
            position.z = -5.56f;
            Instantiate(InstantiateGO, position, Quaternion.identity);
            NextTimeToRespawn = Time.time + SpawnRate;
        }
    }
}
