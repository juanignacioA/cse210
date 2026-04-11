/*
    EXCEEDING REQUIREMENTS:
    1. Robust Error Handling: Added validation in GoalManager.RecordEvent() to prevent 
    crashes when the goal list is empty or an invalid index is chosen.
    2. Input Validation: Used int.TryParse() to handle non-numeric inputs in the menus.
    3. Logic Protection: Prevented recording events on already completed SimpleGoals.
    4. Leveling System: Added a dynamic "GetPlayerLevel" method that assigns a 
    rank (Newbie, Apprentice, etc.) based on the total points earned.
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}