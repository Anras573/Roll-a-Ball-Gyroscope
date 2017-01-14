using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGyroscopeController : MonoBehaviour {

    public float Speed;
    public Text CountText;
    public Text WinText;

    private const string PickUpTag = "Pick Up";

    private Rigidbody _rigidbody;
    private int _count;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _count = 0;
        SetText();
        WinText.text = string.Empty;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.acceleration.x;
        float moveVertical = Input.acceleration.y;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        _rigidbody.AddForce(movement * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PickUpTag))
        {
            other.gameObject.SetActive(false);
            _count++;
            SetText();
        }
    }

    void SetText()
    {
        CountText.text = "Count: " + _count.ToString();
        if (_count == 12)
        {
            WinText.text = "You Win!";
        }
    }
}
