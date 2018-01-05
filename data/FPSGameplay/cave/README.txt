
Copy this level files inside of folder FPSGamplay/levels

cave/levels/The Cave.mis
cave/levels/The Cave.postfxpreset.cs
cave/levels/The Cave_preview.png
cave/levels/The Cave.forest

Remember to put this lines of code at the top of the [Level_Name].mis file in this order.

// LOAD CAVE DATABLOCKS
exec("data/FPSGameplay/cave/scripts/datablocks/environment.cs");
exec("data/FPSGameplay/cave/scripts/datablocks/managedItemData.cs");
exec("data/FPSGameplay/cave/scripts/datablocks/brushes.cs");
exec("data/FPSGameplay/cave/scripts/datablocks/managedParticleData.cs");
exec("data/FPSGameplay/cave/scripts/datablocks/managedParticleEmitterData.cs");

Level and Art Assets Designed by:
Ronald Kapaun, 3TD Studios
