using UnityEngine;
using System.Collections;

public class FireCommand : Command {

	public override void execute(GameActor actor)
	{
		actor.fireGun();
	}
}
