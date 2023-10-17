using UnityEngine;

public class SingleMission : MissionBase
{
    protected override void InitStrategies()
    {
        _chooseStrategy = new GeneralChooseStrategy();
    }
}
