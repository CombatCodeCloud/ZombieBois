﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	int enemyHealth = 100;

	// Update is called once per frame
	void Update () 
	{
	if (enemyHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
	void DeductPoints(int damageAmount)
	{
		enemyHealth -= damageAmount;
	}
}
