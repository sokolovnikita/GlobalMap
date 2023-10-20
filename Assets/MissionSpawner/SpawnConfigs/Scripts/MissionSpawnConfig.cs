using UnityEngine;

[CreateAssetMenu(fileName = "New Mission Spawn", menuName = "Mission Spawn", order = 51)]
public class MissionSpawnConfig : ScriptableObject
{
    [SerializeField] private MissionFactory.Type _type;
    [SerializeField] private Vector2 _position;
    [SerializeField] private string _status;

    public MissionFactory.Type Type { get { return _type; } }
    public Vector2 Position { get { return _position; } }
    public string Status { get { return _status; } }
}
