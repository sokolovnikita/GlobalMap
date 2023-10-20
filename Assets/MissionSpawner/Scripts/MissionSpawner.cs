using System.Collections.Generic;
using UnityEngine;

public class MissionSpawner : MonoBehaviour
{
    [SerializeField] private MissionFactory _factory;
    [SerializeField] private List<MissionSpawnConfig> _spawnConfigs;

    private void Start()
    {
        SpawnMissions();
    }

    public void SpawnMissions()
    {
        foreach (MissionSpawnConfig config in _spawnConfigs) 
        {
            _factory.Spawn(config);
        }
    }
}
