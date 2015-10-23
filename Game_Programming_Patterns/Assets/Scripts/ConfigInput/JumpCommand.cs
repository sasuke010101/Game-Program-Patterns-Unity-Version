using UnityEngine;
using System.Collections;

public class JumpCommand : Command {

	public override void execute(GameActor actor)
	{
		actor.jump();
	}
}
