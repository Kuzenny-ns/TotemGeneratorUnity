using System;
using System.Collections.Generic;
using entities;
using enums;
using UnityEngine;

[Serializable]
public class TotemSpear
{
    public TipMaterialEnum TipMaterial;
    public ElementEnum Element;
    public ColorEntity ShaftColor;
    public float Range;
    public float Damage;

    public TotemSpear(TipMaterialEnum aTip, ElementEnum aElement, ColorEntity aShaftColor, float aRange, float aDamage) {
        TipMaterial = aTip;
        Element = aElement;
        ShaftColor = aShaftColor;
        Range = aRange;
        Damage = aDamage;
    }

    override public string ToString() {
        return $"Tip:{TipMaterial},Element:{Element},ShaftColor:{ShaftColor},Range:{Range},Damage:{Damage}";
    }
}