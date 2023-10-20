using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartDoubleWindow : MissionWindowBase
{
    [SerializeField] private FinalWindow _finalWindow;

    [SerializeField] private TMP_Text _firstMissionName;
    [SerializeField] private Image _firstMissionImage;
    [SerializeField] private TMP_Text _firstMissionDescription;

    [SerializeField] private TMP_Text _secondMissionName;
    [SerializeField] private Image _secondMissionImage;
    [SerializeField] private TMP_Text _secondMissionDescription;

    private MissionConfig _firstMissionConfig;
    private MissionConfig _secondMissionConfig;

    public void Fill(MissionConfig firstMissionConfig, MissionConfig secondMissionConfig)
    {
        _firstMissionConfig = firstMissionConfig;
        _secondMissionConfig = secondMissionConfig;

        _firstMissionName.text = firstMissionConfig.Name;
        _firstMissionImage.sprite = firstMissionConfig.Image;
        _firstMissionDescription.text = firstMissionConfig.Description;

        _secondMissionName.text = secondMissionConfig.Name;
        _secondMissionImage.sprite = secondMissionConfig.Image;
        _secondMissionDescription.text = secondMissionConfig.Description;

        Show();
    }

    public void SelectFisrt()
    {
        Close();
        _finalWindow.Fill(_firstMissionConfig);
    }

    public void SelectSecond()
    {
        Close();
        _finalWindow.Fill(_secondMissionConfig);
    }
}
