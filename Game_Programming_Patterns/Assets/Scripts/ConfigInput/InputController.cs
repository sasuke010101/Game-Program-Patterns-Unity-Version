using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {

	public GameActor actor;

	private Command command;

	void Update () {
		command = InputHandler.handleInput();
		if(command != null)
		{
			Debug.Log("command not null");
			command.execute(actor);
		}

	}
}
