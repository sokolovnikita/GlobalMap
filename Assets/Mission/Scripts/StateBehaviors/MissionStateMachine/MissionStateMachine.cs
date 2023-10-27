using UnityEngine;

public class MissionStateMachine
{
    private MissionBase _mission;
    private MissionStateBase _currentState; 

    public MissionStateBase CurrentState { get { return _currentState; } }

    public MissionStateMachine(MissionBase mission, MissionState missionState)
    {
        _mission = mission;
        SetState(missionState);
        _currentState.Enter();
    }

    public void ChangeState(MissionState missionState)
    {
        _currentState.Exit();
        SetState(missionState);
        _currentState.Enter();
    }
    
    private void SetState(MissionState missionState)
    {
        switch (missionState) 
        {
            case MissionState.Active:
                _currentState = new ActiveMissionState(_mission);
                break;
            case MissionState.Blocked:
                _currentState = new BlockedMissionState(_mission);
                break;
            case MissionState.Passed:
                _currentState = new PassedMissionState(_mission);
                break;
            case MissionState.TemporarilyBlocked:
                _currentState = new TemporarilyBlockedMissionState(_mission);
                break;
        }
    }

    public enum MissionState
    {
        Active,
        Blocked,
        Passed,
        TemporarilyBlocked
    }
}
