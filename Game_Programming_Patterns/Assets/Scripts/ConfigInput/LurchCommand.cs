using UnityEngine;
using System.Collections;

public class LurchCommand : Command {

	public override void execute(GameActor actor)
	{
		actor.lurchIneffectively();
	}
}
