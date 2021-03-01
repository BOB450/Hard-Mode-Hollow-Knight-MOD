using System;
using Modding;

namespace Hollow_knight_mod1
{
    public class Class1 : Mod
    {
        public Class1() : base("Hard mode By BOB450") { }

        public override void Initialize()
        {
            Log("Inithalizing");
            //ModHooks.Instance.RecordKillForJournalHook += OnKill;
            ModHooks.Instance.TakeHealthHook += OnHealthTaken;

        }

        private int OnHealthTaken(int damage)
        {
            return damage * 2;
        }

       /* private void OnKill(EnemyDeathEffects enemyDeathEffects, string playerDataName, string killedBoolPlayerDataLookupKey, string killCountIntPlayerDataLookupKey, string newDataBoolPlayerDataLookupKey)
        {
            PlayerData.instance.AddToMaxHealth(5);
        }
      */
    }
}
//BOB450