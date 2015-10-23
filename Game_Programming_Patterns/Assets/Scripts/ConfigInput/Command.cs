using UnityEngine;
using System.Collections;

public class Command {
	public virtual void execute(GameActor actor){}
	~Command() {}
}
