var enemyHealth : int = 10;

function DeductPoints (damageAmount: int) {
	enemyHealth -= damageAmount;
}

function Update () { 
	if (enemyHealth <= 0) { 
		Destroy(gameObject);
	}
}