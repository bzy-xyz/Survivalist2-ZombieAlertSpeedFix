using System;
using System.Collections.Generic;

using UnityEngine;
using HarmonyLib;
using UnityModManagerNet;

namespace ZombieAlertSpeedFix
{
    static class Main
    {
        public static UnityModManager.ModEntry mod;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            harmony.PatchAll();

            mod = modEntry;

            return true;
        }      
    }
    
    [HarmonyPatch(typeof(Character), "PickAIMovementSpeed")]
    static class Character__PickAIMovementSpeed__Patch {
        static float Postfix(float __result, ref Character __instance, MovementType movementType) {
            if (movementType == MovementType.Run && __instance.Zombie && __instance.ShouldLimp()) {
                return Character.ZombieWalkInjuredSpeed;
            }
            return __result;
        }
    }
}
