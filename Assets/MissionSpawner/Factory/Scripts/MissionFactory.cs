using UnityEngine;
using Zenject;

public class MissionFactory : MonoBehaviour
{
     [SerializeField] private MissionBase _villagePrefab;
     [SerializeField] private MissionBase _cavePrefab;

    private DiContainer _diContainer;
    private float _zOffset = -0.12f;

    [Inject]
    private void Construct(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    public void Spawn(MissionSpawnConfig config)
    {
        Vector2 position = config.Position;
        switch (config.Type)
        {       
            case Type.Village:
                SpawnMission(_villagePrefab, position);
                break;
            case Type.Cave:
                SpawnMission(_cavePrefab, position);
                break;
        }
    }

    private void SpawnMission(MissionBase missionPrefab, Vector3 position)
    {
        _diContainer.InstantiatePrefab(missionPrefab, new Vector3(position.x, position.y, _zOffset), 
            Quaternion.identity, null);
    }

    public enum Type
    {
        Village,
        Cave
    }
}
