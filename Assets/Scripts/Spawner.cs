using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoint; 
    [SerializeField] private float _timeSpawnNextWalve; 
    [SerializeField] private GameObject _prefabEnemy;

    private float _time = 0;

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _timeSpawnNextWalve)
        {
            _time = 0;
            int spawnPointNumber = Random.Range(0, _spawnPoint.Length);
            SpawnNextWalve(_prefabEnemy, _spawnPoint[spawnPointNumber].position);
        }
    }
    public void SpawnNextWalve(GameObject enemy,Vector3 spawnPoint)
    {
        Instantiate(_prefabEnemy);
        enemy.transform.position = spawnPoint;
    }
}
