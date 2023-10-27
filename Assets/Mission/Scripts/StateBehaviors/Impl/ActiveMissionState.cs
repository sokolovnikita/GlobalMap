using UnityEngine;

public class ActiveMissionState : MissionStateBase
{
    public ActiveMissionState(MissionBase mission) : base(mission)
    {
        _state = MissionStateMachine.MissionState.Active;
    }

    public override void Enter()
    {
        _mission.Show();
    }

    public override void ShowWindow()
    {
        _mission.ShowStartWindow();
    }

    public override void Hover(bool isHovered)
    {
        _mission.HoverFrame(isHovered);
    }
}
