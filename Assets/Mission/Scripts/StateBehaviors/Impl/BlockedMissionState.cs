using UnityEngine;

public class BlockedMissionState : MissionStateBase
{
    public BlockedMissionState(MissionBase mission) : base(mission)
    {
        _state = MissionStateMachine.MissionState.Blocked;
    }

    public override void Enter()
    {
        _mission.Hide();
    }
}
