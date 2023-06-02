
using UnityEngine;

public class FigureMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;

    private void Update()
    {
        var vertical = Input.GetAxis("Vertical");
        var mouseY = Input.GetAxis("Mouse X");

        transform.Rotate(0f, mouseY, 0f);

        var verticalSpeed = vertical * _speed * Time.deltaTime;

        _rigidbody.AddRelativeForce(0f, 0f, verticalSpeed, ForceMode.Impulse);

       
    }
}
