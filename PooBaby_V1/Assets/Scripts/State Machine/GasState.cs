using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasState : State {

    public override State Enter(Player owner)
    {
        moveSpeed = 25f;

        return base.Enter(owner);
    }

    public override void Execute()
    {
        base.Execute();

        //Implement
    }
}
