
singleton Material(DriPine01_DarkPineBark)
{
   mapTo = "DarkPineBark";
   diffuseMap[0] = "./pine_bark03.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   normalMap[0] = "./pine_bark03_NRM.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(DriPine01_DriPine)
{
   mapTo = "DriPine";
   diffuseMap[0] = "./DryPine2.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.596078 0.552941 0.282353 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "180";
   normalMap[0] = "./DryPine2_NRM.dds";
   specularMap[0] = "./DryPine2_SPEC.dds";
   subSurfaceRolloff[0] = "1";
};

singleton Material(DriPine01_DarkDriBare)
{
   mapTo = "DarkDriBare";
   diffuseMap[0] = "./Pinebarebranch01.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./Pinebarebranch01_NRM.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
};
