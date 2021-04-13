using Assets.Scripts.Models;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Simulation.Towers;
using Harmony;
using MelonLoader;
using NKHook6;
using NKHook6_Impl;

namespace AllSuper
{
    public class main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("AllSuper is loaded!");
        }
    }

    [HarmonyPatch(typeof(Tower), "Initialise")]
    public class AllSuper_Patch
    {
        [HarmonyPrefix]
        public static bool Prefix(Tower __instance, ref Model modelToUse)
        {
            modelToUse = TowerUtils.GetTower(TowerType.SuperMonkey, 5, 2, 0);

            return true;
        }
    }
}
