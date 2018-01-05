
singleton Material(JungleBark01_mat)
{
   mapTo = "JungleBark01";
   diffuseMap[0] = "./JungleBark02.dds";
   normalMap[0] = "./JungleBark02_NRM.dds";
   specularPower[0] = "25";
   specularMap[0] = "./JungleBark02_SPEC.dds";
};

singleton Material(BaseLeaf01_mat)
{
   mapTo = "BaseLeaf01";
   diffuseMap[0] = "./largeFiscus.dds";
   normalMap[0] = "./largeFiscus_NRM.dds";
   specularMap[0] = "./largeFiscus_SPEC.dds";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.552941 0.666667 0.254902 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
};

singleton Material(CecropiaTree01_C_Vines02)
{
   mapTo = "C-Vines02";
   diffuseMap[0] = "./Vines02.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   normalMap[0] = "./Vines02_NRM.dds";
};

singleton Material(CecropiaTree01_C_Vines01)
{
   mapTo = "C-Vines01";
   diffuseMap[0] = "./GreenVine02.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.423529 0.521569 0.101961 1";
   subSurfaceRolloff[0] = "0.1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   normalMap[0] = "./GreenVine02_NRM.dds";
   specularMap[0] = "./GreenVine02_SPEC.png";
};

singleton Material(CecropiaTree01_ColorEffectR87G225B198_material)
{
   mapTo = "ColorEffectR87G225B198-material";
   diffuseColor[0] = "0.341177 0.882353 0.776471 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
