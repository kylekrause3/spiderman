/* 
 * TODO:
 *      finish inventory system
 *          https://www.youtube.com/watch?v=2WnAOV7nHW0 timestamps in description
 *          make max list size 10 (can only hold 10 items)
 *          make sure inventory is accessible (drop shit and stuff)
 *      scripts for different items, powerups, etc
 *      finish thirdpersoncamera, with crosshair and such from youtube tutorial
 *          https://www.youtube.com/watch?v=537B1kJp9YQ&t=235s
 *      add roll ability (maybe)
 *      shouldn't have multiple physics.check... in thirdpersonmovement.cs
 * 
 * 
 * BUGS:
 *      weird collision with rotated box
 *          this is not because of groundcheck/box collider, i think it's with the things labeled with BUG1 (gravity stuff) in thirdpersonmovement.cs
 *      you can now jump up big ass wall
 * 
 * 
 * OPTIONAL:
 *      You can add lighting to every individual ground item, kinda cute; gonna stick with universal color rn; prob do this with rarity of items in the future; see line 18 of item.cs for a start
 *          https://www.youtube.com/watch?v=2WnAOV7nHW0&t=582s 11:55
 *      Add amount to world items (stack multiple items in one in world)
 *          https://www.youtube.com/watch?v=2WnAOV7nHW0&t=582s 19:50
 *          
 *          
 * TIMELINE (from phone):
 *      Finish up inventory skeleton
 *      Program starting weapons/item
 *      Roll/Dash system probably attached to a character
 *      Make an actual level and see how it goes
 *      UI/Menu/LevelSelect
 *      
 *      
 *      level generation
 */