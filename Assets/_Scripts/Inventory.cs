//gesick
//proj 2 complete - proj 3 start

using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{

    public List<WeaponBase> weps;
    public List<Renderer> wepsRen;
    private int wepSel;

    public Inventory()
    {
        weps = new List<WeaponBase>();
        wepsRen = new List<Renderer>();
        wepSel = -1;
    }
    public void AddToInventory(WeaponBase w)
    {
        weps.Add(w);
        wepsRen.Add(w.GetComponent<Renderer>());
        wepsRen[wepsRen.Count - 1].enabled = false;
    }

    public WeaponBase SelectWep()
    {
        if (weps.Count > 0)
        {
            if (wepSel != -1)
            {
                wepsRen[wepSel].enabled = false;
            }

            wepSel++;
            if (wepSel >= weps.Count)
                wepSel = 0;

            wepsRen[wepSel].enabled = true;
            return weps[wepSel];
        }
        else
            return null;
    }
    public void Positioning(Transform t)
    {
        for (int q = 0; q < weps.Count; q++)
        {
            weps[q].transform.position = t.position;
            weps[q].transform.rotation = t.rotation;
        }
    }
    public void PowerUp()
    {
        foreach (WeaponBase wb in weps)
        {
            wb.ammoCount += 20;

        }
    }

}                                                                                                                                                                                                                                                        //gesick project

