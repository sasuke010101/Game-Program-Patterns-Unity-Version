using UnityEngine;
using System.Collections;

public class SwapCommand : Command {

	public override void execute(GameActor actor)
	{
		actor.swapWeapon();
	}
}
