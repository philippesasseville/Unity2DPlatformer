using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private int idleState = Animator.StringToHash("Base Layer.idle");
	private int runState = Animator.StringToHash("Base Layer.run");
	private int jumpState = Animator.StringToHash("Base Layer.jump");

	private CharacterController2D _controller;
	private Animator _animator;

	void Awake()
	{
		_controller = GetComponent<CharacterController2D>();
	}
}
