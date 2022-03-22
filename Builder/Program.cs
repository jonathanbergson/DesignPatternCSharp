using System;

namespace Builder
{
    class Program
    {
        private static void Main(string[] args)
        {
            var army = new Army();
            SoldierBuilder soldierBuilder;
            Soldier soldier;

            soldierBuilder = new SoldierLightInfantryBuilder();
            army.BuildSoldier(soldierBuilder);
            soldier = soldierBuilder.GetSoldier();
            Console.WriteLine("Soldado com as caracteríticas: {0}, {1}, {2}", soldier.weapon, soldier.transport, soldier.focus);

            soldierBuilder = new SoldierLightInfantryBuilder();
            army.BuildSoldier(soldierBuilder);
            soldier = soldierBuilder.GetSoldier();
            Console.WriteLine("Soldado com as caracteríticas: {0}, {1}, {2}", soldier.weapon, soldier.transport, soldier.focus);

            Console.ReadKey();
        }
    }
}