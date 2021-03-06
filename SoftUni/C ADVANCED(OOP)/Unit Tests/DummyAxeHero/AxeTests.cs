using NUnit.Framework;
using System;



[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeLosingDurabilityAfterAttack()
    {

        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints == 9, "Axe durability doesn't change after attack.");

    }
    [Test]
    public void AxeAttackingWithZeroDurability()
    {

        Axe axe = new Axe(10, 0);
        Dummy dummy = new Dummy(10, 10);

        

        Assert.Throws<InvalidOperationException>(()=> axe.Attack(dummy));

    }
}
