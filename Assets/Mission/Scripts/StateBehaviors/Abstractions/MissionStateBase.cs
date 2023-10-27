using UnityEngine;

public abstract class MissionStateBase
{
    protected MissionStateMachine.MissionState _state;
    protected MissionBase _mission;

    public MissionStateBase(MissionBase mission)
    {
        _mission = mission;
    }

    public MissionStateMachine.MissionState State { get { return _state; } }

    public virtual void Enter()
    {
    }

    public virtual void Exit() 
    { 
    }

    public virtual void ShowWindow()
    {
    }

    public virtual void Hover(bool isHovered)
    {
    }
}
