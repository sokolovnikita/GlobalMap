using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Hero", menuName = "Hero", order = 51)]
public class HeroConfig : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private Sprite _image;

    public string Name { get { return _name; } }
    public Sprite Image { get { return _image; } }
}
