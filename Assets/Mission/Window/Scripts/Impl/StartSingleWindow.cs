using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartSingleWindow : MissionWindowBase
{
    [SerializeField] private FinalWindow _finalWindow;

    [SerializeField] private TMP_Text _missionName;
    [SerializeField] private Image _missionImage;
    [SerializeField] private TMP_Text _missionDescription;

    private MissionConfig _mission;

    public void Fill(MissionConfig missionConfig)
    {
        _mission = missionConfig;

        _missionName.text = missionConfig.Name;
        _missionImage.sprite = missionConfig.Image;
        _missionDescription.text = missionConfig.Description;

        Show();
    }

    public void ShowFinal()
    {
        Close();
        _finalWindow.Fill(_mission);
    }
}
