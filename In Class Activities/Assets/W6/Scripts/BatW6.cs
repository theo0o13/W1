using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] public float _speed;
    [SerializeField] public Transform _player;
    private bool _isChasing = false;

    public void EnableChase()
    {
        _isChasing = true;
    }

    public void DisableChase()
    {
        _isChasing = false;
    }
    
    public void chase()
    {
        float iSpeed = _speed;
        transform.position = Vector3.MoveTowards(transform.position, _player.position, iSpeed * Time.deltaTime);
        
    }
    private void Update()
    {
        if (_isChasing)
        {
            chase();
        }
    }

    
}

