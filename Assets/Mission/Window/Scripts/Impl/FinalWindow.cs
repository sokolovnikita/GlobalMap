using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalWindow : MissionWindowBase
{
    [SerializeField] private TMP_Text _missionName;
    [SerializeField] private Image _missionImage;
    [SerializeField] private TMP_Text _missionDescription;

    [SerializeField] private TMP_Text _playerHeroName;
    [SerializeField] private Image _playerHeroImage;

    [SerializeField] private TMP_Text _enemyHeroName;
    [SerializeField] private Image _enemyHeroImage;

    public void Fill(MissionConfig missionConfig)
    {
        _missionName.text = missionConfig.Name;
        _missionImage.sprite = missionConfig.Image;
        _missionDescription.text = missionConfig.Description;

        _playerHeroName.text = missionConfig.PlayerHero.Name;
        _playerHeroImage.sprite = missionConfig.PlayerHero.Image;

        _enemyHeroName.text = missionConfig.EnemyHero.Name;
        _enemyHeroImage.sprite = missionConfig.EnemyHero.Image;

        Show();
    }
}
