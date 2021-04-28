using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable<D,G,K>
{
    public void TakeDamage(D damageamount,G damageDealer,K knockBackForce);
}
