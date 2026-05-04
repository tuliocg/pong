using UnityEngine;

public class OpponentMovement : MonoBehaviour
{
    private float _speed = 10f;
    private Transform _ball;

    void Awake()
    {
        _ball = FindAnyObjectByType<BallMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ballY = new Vector2(transform.position.x, _ball.position.y);
        //transform.position = Vector2.MoveTowards(transform.position, ballY, _speed * Time.deltaTime);
        transform.position = Vector2.Lerp(transform.position, ballY, _speed * Time.deltaTime);
        Debug.Log(_ball.position.normalized);
        
    }
}
