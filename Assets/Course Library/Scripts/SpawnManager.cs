using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProyectoPrototype3
{
    public class SpamManager : MonoBehaviour
    {
        public GameObject obstaclePrefab;
        private Vector3 spawnPos = new Vector3(25, 0, 0);
        private float StartDelay = 2;
        private float repeatRate = 2;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            InvokeRepeating("SpawnObstacle", StartDelay, repeatRate);
        }

        void spawnObsrecle()
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }

}

