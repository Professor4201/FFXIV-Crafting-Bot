using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GreyMagic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace LongMacro
{
    public class Macro
    {
        public List<Command> macroKeys = new List<Command>();
        public int delay = 3000; //minimum delay between each action
        public int maxLagDelay = 15000; //maximum time to wait for an action to complete before trying to repeat it
        public int currentStep = 0;
        Form1 gui;
        public int exp = 0;
        public bool SkipGreatStrides = false;
        private int SkippedGreatStrides = 0;
        private FinalFantasy game;
        public static int minimumMaxCP = 0;
        

        public Macro(Form1 gui)
        {
            this.gui = gui;
            game = new FinalFantasy();
        }

        public void Run()
        {
            while (true)
            {
                exp = game.getExp();
                currentStep = game.getCurrentStep();

                gui.update(this);

                if (game.getGameState() == 4)
                {
                    if (game.getMaxCP() < minimumMaxCP)
                    {
                        MessageBox.Show("Error, current maximum CP is below the maximum CP limit! (Refresh your food)");
                        return;
                    }

                    SkippedGreatStrides = 0;

                    //currently in crafting menu
                    while (game.getGameState() == 4)
                    {
                        //select item and begin synthesis
                        game.sendKey(Keys.NumPad0);
                    }
                }

                //crafting
                else
                {
                    

                    if (game.getGameState() == 3) //game state after immediately beginning a craft
                    {
                        //send the first command to set the game state to 9(crafting) or 10(Steady Hands 2, Inner Quiet)
                        game.sendKey(macroKeys[0].Key);

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        while (game.getGameState() == 3 && (int)stopwatch.ElapsedMilliseconds < maxLagDelay)
                        {
                            Thread.Sleep(100);
                        }
                    }

                    else if (game.getGameState() >= 9) //9(crafting) or 10(Steady Hands 2, Inner Quiet)
                    {
                        while (game.getDurability() == 0 && game.getGameState() >= 9)
                        {
                            game.sendKey(Keys.NumPad0);
                        }

                        gui.update(this);

                        //send the current command in the macro
                        try
                        {
                            if (SkipGreatStrides && game.getCondition() == (int)FinalFantasy.CraftingCondition.EXCELLENT)
                            {
                                if (macroKeys[currentStep - 1 + SkippedGreatStrides].name == "Great Strides")
                                {
                                    SkippedGreatStrides++; //skip directly to Byregot's Blessing
                                }
                            }
                            game.sendKey(macroKeys[currentStep - 1 + SkippedGreatStrides].Key);
                        }
                        catch
                        {
                            MessageBox.Show("Error at line " + (currentStep + SkippedGreatStrides) + " of macro!");
                            return;
                        }

                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();

                        while (!currentStepChanged() && game.getGameState() >= 9 && (int)stopwatch.ElapsedMilliseconds < maxLagDelay)
                        {
                            Thread.Sleep(100);
                        }
                    }
                }
            }
        }

        public bool currentStepChanged()
        {
            return game.getCurrentStep() > currentStep;
        }
    }
}
