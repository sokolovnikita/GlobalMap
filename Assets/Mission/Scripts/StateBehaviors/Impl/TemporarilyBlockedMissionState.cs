using UnityEngine;

public class TemporarilyBlockedMissionState : MissionStateBase
{
    public TemporarilyBlockedMissionState(MissionBase mission) : base(mission)
    {
        _state = MissionStateMachine.MissionState.TemporarilyBlocked;
    }

    public override void Enter()
    {
        _mission.Show();
    }
}
