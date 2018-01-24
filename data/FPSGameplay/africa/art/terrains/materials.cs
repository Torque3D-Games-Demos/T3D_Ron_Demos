//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------


//-------------------------------------------------------------
//Custom Sound and effects for Terrain Materials
//-------------------------------------------------------------

singleton Material(Gravel)  
{  
   mapTo = "africaDM";  
   customFootstepSound = FootLightSoftSound;
};

//-------------------------------------------------------------
//Terrain materials
//-------------------------------------------------------------

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   diffuseSize = "2048";
   internalName = "africaBase01";
   detailMap = "./AfricaPack/3td_RedDirt_02_Tile-DIF";
   detailDistance = "300";
   parallaxScale = "0.03";
   detailSize = "6";
   normalMap = "./AfricaPack/3td_RedDirt_02_Tile_NRM";
   detailStrength = "0.5";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   detailMap = "./AfricaPack/3td_RedRock_01";
   internalName = "africaRock";
   detailSize = "200";
   detailDistance = "500";
   parallaxScale = "0.03";
   diffuseSize = "2048";
   normalMap = "./AfricaPack/3td_RedRock_02_NRM";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   diffuseSize = "2048";
   detailMap = "./AfricaPack/3td_sand_01_256";
   detailSize = "4";
   parallaxScale = "0.03";
   internalName = "africaPebbles";
   detailDistance = "500";
   normalMap = "./AfricaPack/3td_RedRock_02_NRM";
   detailStrength = "0.5";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   diffuseSize = "2048";
   internalName = "africaGreen";
   detailMap = "./AfricaPack/3td_AfricaGrass_Dry";
   detailStrength = "0.7";
   detailSize = "4";
   detailDistance = "300";
   normalMap = "./AfricaPack/3td_AfricaGrass_Dry_NRM";
   parallaxScale = "0.02";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   diffuseSize = "2048";
   normalMap = "./AfricaPack/3td_RedStones_02_DIF_NRM2";
   detailMap = "./AfricaPack/3td_RedStones_02_DET";
   detailSize = "5";
   detailStrength = "0.5";
   detailDistance = "50";
   internalName = "screePiles";
   parallaxScale = "0.02";
   useSideProjection = "0";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   normalMap = "./AfricaPack/3td_Rock_Side_02_NRM";
   detailMap = "./AfricaPack/3td_Rock_Side_02_DET";
   parallaxScale = "0.03";
   internalName = "RockSide";
   diffuseSize = "2048";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   diffuseSize = "2048";
   normalMap = "./AfricaPack/3td_RockWash_03_NRM";
   detailMap = "./AfricaPack/3td_RockWash_03";
   parallaxScale = "0.05";
   internalName = "RockWash";
   useSideProjection = "0";
   detailSize = "10";
   detailStrength = "0.25";
   detailDistance = "300";
};

new TerrainMaterial()
{
   diffuseMap = "./AfricaPack/africaDM";
   normalMap = "./AfricaPack/3td_Gravel_01_NRM";
   detailMap = "./AfricaPack/3td_Gravel_01";
   parallaxScale = "0.03";
   internalName = "Gravel";
   diffuseSize = "2048";
};

