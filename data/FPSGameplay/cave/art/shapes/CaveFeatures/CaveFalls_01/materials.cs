
singleton Material(CaveFalls01_waterfallFlow)
{
   mapTo = "waterfallFlow";
   diffuseMap[0] = "./CaveFalls_01/3td_CaveFalls_01";
   specular[0] = "0.996078 0.996078 0.996078 1";
   specularPower[0] = "1";
   translucent = "0";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 -0.1";
   scrollSpeed[0] = "5.765";
   doubleSided = "1";
   translucentBlendOp = "LerpAlpha";
   alphaRef = "208";
   subSurface[0] = "0";
   subSurfaceColor[0] = "0.992157 0.996078 0.996078 1";
   alphaTest = "1";
   normalMap[0] = "./3td_CaveFalls_01_NRM.png";
   diffuseColor[0] = "0.913726 0.968628 0.976471 1";
   subSurfaceRolloff[0] = "0.5";
   glow[0] = "1";
};

singleton Material(CaveFalls01_RockBase02)
{
   mapTo = "RockBase02";
   diffuseMap[0] = "./CaveFalls_01/3TD_RockBase_01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./CaveFalls_01/RockNormal.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};
