
singleton Material(RockFace_01_RockFace01DifAMB__RockFaceONE300_)
{
   mapTo = "RockFace01DifAMB__RockFaceONE300_";
   diffuseMap[0] = "RockFace_01_Dif";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(RockFace_01_ColorEffectR145G28B177_material)
{
   mapTo = "ColorEffectR145G28B177-material";
   diffuseColor[0] = "0.568627 0.109804 0.694118 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(RockFace_01_orig_RockFace01DifAMB)
{
   mapTo = "orig_RockFace01DifAMB";
   diffuseMap[0] = "RockFace_01_Dif_Amb";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(RockFace_01_RockFace01DifAMB)
{
   mapTo = "RockFace01DifAMB";
   diffuseMap[0] = "./RockFace_01_Dif_Amb.png";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "100";
   translucentBlendOp = "None";
   normalMap[0] = "./RockFace_01_Dif_NRM.png";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};
