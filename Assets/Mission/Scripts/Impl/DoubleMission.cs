using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class DoubleMission : MissionBase
{
    [SerializeField] private MissionConfig _firstMission;
    [SerializeField] private MissionConfig _secondMission;

    public override void ShowStartWindow()
    {
        _window.FillDouble(_firstMission, _secondMission);
    }
}
