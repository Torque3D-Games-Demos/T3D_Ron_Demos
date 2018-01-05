
singleton Material(RockPile_01_ColorEffectR115G115B115_material)
{
   mapTo = "ColorEffectR115G115B115-material";
   diffuseColor[0] = "0.45098 0.45098 0.45098 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(RockPile_01_RockPile01)
{
   mapTo = "RockPile01";
   diffuseMap[0] = "./RockPile_01_Diff_Amb.jpg";
   specularPower[0] = "100";
   translucentBlendOp = "None";
   normalMap[0] = "./RockPile_01_Diff_NRM.png";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};
