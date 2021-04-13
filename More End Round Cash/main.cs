using Assets.Scripts.Simulation;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Unity.UI_New.InGame;
using Harmony;
using MelonLoader;
using NKHook6;
using NKHook6.Api.Extensions;

namespace More_End_Round_Cash
{
    public class main : MelonMod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            Logger.Log("More_End_Round_Cash is loaded!");
        }
    }

    [HarmonyPatch(typeof(Simulation), "OnRoundEnd")]
    public class SimulationOnRoundEnd_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(int round)
        {
            int Kasa = round*100;
            InGame.instance.addCash(Kasa);
        }
    }
}
