//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------

new TerrainMaterial()
{
   internalName = "coniferGrass1";
   normalMap = "./Example/GrassandStone_NRM";
   diffuseMap = "./Example/GrassandStone";
   detailMap = "./Example/GrassandStone";
   detailSize = "3";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "100";
   detailDistance = "400";
   parallaxScale = "0.02";
};

new TerrainMaterial()
{
   internalName = "dirt_grass2";
   diffuseMap = "./Example/rocks1";
   diffuseSize = "5000";
   normalMap = "./Example/rocks1_NRM";
   detailMap = "./Example/rocks1_d";
   detailSize = "25";
   detailDistance = "400";
   useSideProjection = "1";
   parallaxScale = "0.001";
   enabled = "1";
   isManaged = "1";
   detailBrightness = "1";
};

new TerrainMaterial()
{
   internalName = "ConiferStrata";
   diffuseMap = "./Example/rock01a";
   diffuseSize = "256";
   normalMap = "./Example/rock01_NRM2";
   detailMap = "./Example/rock01";
   detailSize = "15";
   detailDistance = "1000";
   useSideProjection = "0";
   parallaxScale = "0.02";
   enabled = "1";
   isManaged = "1";
   detailBrightness = "1";
   detailStrength = "0.5";
};

new TerrainMaterial()
{
   internalName = "ConiferShoreRock";
   diffuseMap = "./Example/GravelCobble2";
   detailMap = "./Example/GravelCobble2";
   detailDistance = "400";
   diffuseSize = "0.1";
   parallaxScale = "0.02";
   detailSize = "2";
   detailStrength = "1";
   normalMap = "./Example/GravelCobble2_NRM";
};

new TerrainMaterial()
{
   internalName = "ConiferCoastal";
   diffuseMap = "./Example/pebbles1";
   normalMap = "./Example/pebbles1_NRM";
   detailMap = "./Example/pebbles1";
   detailSize = "3";
   detailDistance = "400";
   parallaxScale = "0.02";
};

new TerrainMaterial()
{
   internalName = "ConiferStrata02";
   diffuseMap = "./Example/rock01a";
   normalMap = "./Example/normal_rock1";
   detailMap = "./Example/Rock01";
   diffuseSize = "100";
   detailSize = "15";
   detailDistance = "400";
   useSideProjection = "1";
   parallaxScale = "0.01";
   isManaged = "1";
   enabled = "1";
   detailBrightness = "1";
};

new TerrainMaterial()
{
   internalName = "ConiferSnow01";
   diffuseMap = "./Winter/snowy02";
   normalMap = "./Winter/snowy02A_NRM";
   detailMap = "./Winter/snowy02A_COLOR";
   diffuseSize = "50";
   detailSize = "15";
   detailDistance = "400";
   useSideProjection = "0";
   parallaxScale = "0.02";
   
   detailBrightness = "1";
   isManaged = "1";
   enabled = "1";
};
