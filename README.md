# FFXIV-Crafting-Bot

![](http://i.imgur.com/2lqEDOl.png)

# Features 

* Save/load macros
* Loop macros
* Stop looping macros when below a certain CP amount
* Set a custom delay between actions for laggy PCs
* Skip Great Strides and immediately use Byregot's Blessing if an Excellent condition procs


# How to update this bot

* Open Cheatengine and scan for the values in-game. Keep scanning to eliminate invalid results. You want to look for a green-colored pointer (a static pointer, which do not change with game reboots and only change when the game updates). This is the pointer you're looking for, paste it into the code in FinalFantasy.cs.

* You only need to find the pointers for game state, condition, and current step to get this bot to work. The other pointers are part of a 4* crafting bot that has since been rendered obsolete by updates.

* To find game state:
Scan for the value 3 immediately after beginning a craft.
Scan for the value 4 while you're in the craft selection menu.
Scan for values above 9 when in the middle of crafting.

* To find current condition: 
Scan for the values in the CraftingCondition enum (in FinalFantasy.cs)

* Finding the other pointers is just a matter of searching for the value you are looking for in Cheatengine. 

# Happy botting! 
![](http://i.imgur.com/gDezud4.png)
