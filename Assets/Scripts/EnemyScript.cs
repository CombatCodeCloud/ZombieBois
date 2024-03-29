﻿using System.Diagnostics;
using UnityEngine;
using UnityEngine.AI;
using Debug = UnityEngine.Debug;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    Transform destination = null;

    NavMeshAgent navMeshAgent;
    public static bool navReady;
    public int enemyHealth = 100;

    void Start ()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent not detected on" + gameObject.name);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }

        if(destination != null && navReady)
        {
            Vector3 targetVector = destination.transform.position;
            navMeshAgent.SetDestination(targetVector);
        }
    }
    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }

}
