using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private Animator _animator;

    public bool isMoving = false;

    public int streakAmount = 0;

    [SerializeField] private GameObject canvasCardChooser;
    private void Start()
    {
        isMoving = false;
        _rb = GetComponent<Rigidbody2D>();
        NewQuestionEvent.Instance.generatingNewQuestion += RestartPos;
        NewQuestionEvent.Instance.generatingNewQuestion += CardChooserCanvasOpen;
    }

    void Update()
    {
        if(isMoving && Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x - 3.75f, 3.5f);
            transform.localScale = new Vector2(-1, 1);
            _animator.SetTrigger("Jump");
        }
        if (isMoving && Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.velocity = new Vector2(_rb.velocity.x + 3.75f, 3.5f);
            transform.localScale = new Vector2(1, 1);
            _animator.SetTrigger("Jump");
        }
    }

    public void RestartPos()
    {
        transform.position = GameObject.Find("PlayerPos").transform.position;
        isMoving = false;
        streakAmount++;
        TextManager.Instance.streakText.SetText("X"+streakAmount.ToString());
    }

    public void CardChooserCanvasOpen()
    {
        if (streakAmount % 4 == 0)
        {
            canvasCardChooser.SetActive(true);
        }
    }

}
