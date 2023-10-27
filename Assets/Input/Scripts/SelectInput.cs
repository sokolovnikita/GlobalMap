using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelectInput : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private InputActions _inputActions;
    private IMission _mission;

    private void Awake()
    {
        _inputActions = new InputActions();
    }  

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Gameplay.Select.performed += Select;
        _inputActions.Gameplay.Hover.performed += Hover;
    }

    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Gameplay.Select.performed -= Select;
        _inputActions.Gameplay.Hover.performed -= Hover;
    }

    private void Select(InputAction.CallbackContext obj)
    {
        Ray ray = DrawRay();
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            hit.transform.gameObject.GetComponent<IMission>()?.ShowWindow();    
    }

    private void Hover(InputAction.CallbackContext obj)
    {
        Ray ray = DrawRay();
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            _mission = hit.transform?.gameObject.GetComponent<IMission>();
            _mission?.Hover(true);
        }
        else
        {
            _mission?.Hover(false);
        }
        
    }

    private Ray DrawRay()
    {
        Vector2 clickPosition = new Vector2(_inputActions.Gameplay.Hover.ReadValue<Vector2>().x,
            _inputActions.Gameplay.Hover.ReadValue<Vector2>().y);
        Vector3 viewPosition = new Vector3(clickPosition.x, clickPosition.y, -1 *
            _camera.transform.position.z);

        Vector3 rayStart = _camera.ScreenToWorldPoint(viewPosition);
        Vector3 rayEnd = new Vector3(rayStart.x, rayStart.y, -200);

        Ray ray = new Ray(rayStart, rayEnd);

        return ray;
    }
}
