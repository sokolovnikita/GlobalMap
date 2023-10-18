using UnityEngine;
using UnityEngine.InputSystem;

public class ChooseInput : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private InputActions _inputActions;
    
    private void Awake()
    {
        _inputActions = new InputActions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.Choose.performed += Choose;
    }

    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Gameplay.Choose.performed -= Choose;
    }

    private void Choose(InputAction.CallbackContext obj)
    {
        Vector2 clickPosition = new Vector2(_inputActions.Gameplay.Choose.ReadValue<Vector2>().x,
            _inputActions.Gameplay.Choose.ReadValue<Vector2>().y);   
        Vector3 viewPosition = new Vector3(clickPosition.x, clickPosition.y, -1 * 
            _camera.transform.position.z);

        Vector3 rayStart = _camera.ScreenToWorldPoint(viewPosition);
        Vector3 rayEnd = new Vector3(rayStart.x, rayStart.y, -200);

        Ray ray = new Ray(rayStart, rayEnd);
        RaycastHit hit;     

        if (Physics.Raycast(ray, out hit))
            hit.transform.gameObject.GetComponent<MissionBase>()?.Choose();

        Debug.Log(Physics.Raycast(ray, out hit) + " " + hit);
        Debug.DrawRay(rayStart, rayEnd, Color.yellow);
        Debug.Log("Choose " + rayStart + " " + rayEnd);
    }
}
