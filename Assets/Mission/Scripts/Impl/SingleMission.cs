using UnityEngine;

public class SingleMission : MissionBase
{
    [SerializeField] private MissionConfig _config;

    public override void ShowStartWindow()
    {
        _window.FillSingle(_config);
    }
}
