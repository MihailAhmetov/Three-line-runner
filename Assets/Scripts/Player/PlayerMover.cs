using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stepSize;

    [SerializeField] private float _rightBorder;
    [SerializeField] private float _leftBorder;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpeed * Time.deltaTime);
    }

    public void MoveLeft()
    {
        if (_targetPosition.x > _leftBorder)
            SetNextPosition(-_stepSize);
    }

    public void MoveRight()
    {
        if (_targetPosition.x < _rightBorder)
            SetNextPosition(_stepSize);
    }

    private void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x + stepSize, _targetPosition.y);
    }
}
