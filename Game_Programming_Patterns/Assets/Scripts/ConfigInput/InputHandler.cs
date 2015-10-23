using UnityEngine;
using System.Collections;

public static class InputHandler{

	private static Command  buttonX_ = new JumpCommand();
	private static Command buttonY_ = new FireCommand();
	private static Command buttonA_ = new SwapCommand();
	private static Command buttonB_ = new LurchCommand();

	public static Command handleInput()
	{
		if(Input.GetKeyDown(KeyCode.X)) return buttonX_;
		else if(Input.GetKeyDown(KeyCode.Y)) return buttonY_;
		else if(Input.GetKeyDown(KeyCode.A)) return buttonA_;
		else if(Input.GetKeyDown(KeyCode.B)) return buttonB_;

		return null;
	}
}

