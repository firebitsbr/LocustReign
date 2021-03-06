﻿using UnityEngine;
using System.Collections;

public class ShardDamage : IShard {

    public int damage;

    public override void Execute(Pawn caster, Pawn target)
    {
        target.health.TakeDamage(damage);
    }
}
