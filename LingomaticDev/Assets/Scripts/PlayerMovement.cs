using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _animator;

    public bool isMoving = false;

    public int streakAmount = 0;
    private void Start()
    {
        isMoving = false;
        NewQuestionEvent.Instance.generatingNewQuestion += RestartPos;
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(isMoving && Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x - 3.75f, 3.5f);
        }
        if (isMoving && Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x + 3.75f, 3.5f);
        }
    }

    public void RestartPos()
    {
        transform.position = GameObject.Find("PlayerPos").transform.position;
        isMoving = false;
        streakAmount++;
        TextManager.Instance.streakText.SetText("X"+streakAmount.ToString());
    }

}
