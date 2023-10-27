using UnityEngine;

public class PassedMissionState : MissionStateBase
{
    public PassedMissionState(MissionBase mission) : base(mission)
    {
        _state = MissionStateMachine.MissionState.Passed;
    }

    public override void Enter()
    {
        _mission.Show();
    }
}
