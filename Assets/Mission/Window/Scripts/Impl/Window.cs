using UnityEngine;

public class Window : MonoBehaviour
{   
    [SerializeField] StartSingleWindow _startSingleWindow;
    [SerializeField] StartDoubleWindow _startDoubleWindow;
    [SerializeField] FinalWindow _finalWindow;

    public void FillSingle(MissionConfig mission)
    {
        _startSingleWindow.Fill(mission);
    }

    public void FillDouble(MissionConfig firstMission, MissionConfig secondMission)
    {
        _startDoubleWindow.Fill(firstMission, secondMission);
    }

    public void FillFinal(MissionConfig mission)
    {
        _finalWindow.Fill(mission);
    }   
}
