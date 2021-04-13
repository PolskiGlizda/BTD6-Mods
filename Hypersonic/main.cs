using MelonLoader;
using Harmony;
using NKHook6;
using Assets.Scripts.Simulation.Towers.Weapons;

namespace Hypersonic
{
    public class main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("Hypersonic is loaded!");
        }
    }

    [HarmonyPatch(typeof(Weapon),"Initialise")]
    public class WeaponInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }
}
