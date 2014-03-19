using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class obstacleCreator : MonoBehaviour {
	
	/*
	 * Used to fire a projectile from the barrel of the gun
	 */
	static public bool canFire = true;
	
	public GameObject spawnProjectile_1;
	public GameObject spawnProjectile_2;
	public GameObject spawnProjectile_3;
	public GameObject spawnProjectile_4;
	public GameObject spawnProjectile_5;

	private int posFire = 0;
	static public int startProjectileSpeed = 5;
	static public float startWaitTimeForFire = 2.5F;

	public Rigidbody projectilePrefab;
	static public int projectileSpeed = startProjectileSpeed;
	static public float waitTimeForFire = startWaitTimeForFire;
	//public AudioClip shootSFX;

	void Start()
	{
		projectileSpeed = 5;
	}


	void Update () 
	{
		// 	Fire obstacle
		/*if (canFire) 
		{
			initObstacle();
			//audio.PlayOneShot(shootSFX);
			//StartCoroutine(delayGunFire());
		}*/
		if (StartGame.gameStarted && canFire)
		{
			StartCoroutine(initObstacle());
		}
	}

	IEnumerator initObstacle()
	{
		initObstacleProjectile();
		canFire = false;
		yield return new WaitForSeconds(waitTimeForFire);
		canFire = true;

	}
	
	/*
	 * Creates obstacle w/velocity
	 */
	void initObstacleProjectile() 
	{
		int posFire = Random.Range(1, 6);

		if (posFire == 1)
		{
			Rigidbody obstacleProj = Instantiate(projectilePrefab, spawnProjectile_1.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);

			obstacleProj = Instantiate(projectilePrefab, spawnProjectile_4.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		}
		else if(posFire == 2)
		{
			Rigidbody obstacleProj = Instantiate(projectilePrefab, spawnProjectile_2.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);

			obstacleProj = Instantiate(projectilePrefab, spawnProjectile_1.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		}
		else if(posFire == 3)
		{
			Rigidbody obstacleProj = Instantiate(projectilePrefab, spawnProjectile_3.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		}
		else if(posFire == 4)
		{
			Rigidbody obstacleProj = Instantiate(projectilePrefab, spawnProjectile_4.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);

			obstacleProj = Instantiate(projectilePrefab, spawnProjectile_5.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		}
		else if(posFire == 5)
		{
			Rigidbody obstacleProj = Instantiate(projectilePrefab, spawnProjectile_5.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);

			obstacleProj = Instantiate(projectilePrefab, spawnProjectile_2.transform.position, transform.rotation) as Rigidbody;
			obstacleProj.velocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		}
		else
		{
			Debug.Log("Can't fire: " + posFire);
		}
	}
	
	/*
	 * Controls rate of fire
	 */
/*	IEnumerator delayGunFire() 
	{
		canFire = false;
		yield return new WaitForSeconds(fireRate);
		canFire = true;
	}*/
}



