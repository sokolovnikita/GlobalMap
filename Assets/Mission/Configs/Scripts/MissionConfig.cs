using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Mission", menuName = "Mission", order = 51)]
public class MissionConfig : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _image;
    [SerializeField] private string _shortDescription;
    [SerializeField] private string _description;
    [SerializeField] private HeroConfig _playerHero;
    [SerializeField] private HeroConfig _enemyHero;

    public string Name { get { return _name; } }
    public Sprite Image { get { return _image; } }
    public string ShortDescription { get { return _shortDescription; } }
    public string Description { get { return _description; } } 
    public HeroConfig PlayerHero { get { return _playerHero; } }
    public HeroConfig EnemyHero { get { return _enemyHero; } }
}
