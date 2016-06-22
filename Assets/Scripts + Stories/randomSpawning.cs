using UnityEngine;
using System.Collections;

public class randomSpawning : MonoBehaviour {

	public GameObject Enemy;
	public Transform[] spawnPoints;
	public float waveTimer;
	public float spawnEnemy;
	public float enemyPerWave;
	public float myScale;
	public int WaveValue = 1;

	void Update()
	{
		waveTimer -= Time.deltaTime;
		if (waveTimer < 0)
		{
			spawnEnemy += enemyPerWave;
			for (float i=0 + spawnEnemy; i > 0; i--)
			{
				Spawn();
			}
			waveTimer = 3.5f;
			WaveManager.wave += WaveValue;
		}
	}
	void Spawn()
	{
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		Enemy.tag = "enemy1";
		Enemy.transform.localScale = new Vector3(3/2, 3/2, 3/2);
	}
}