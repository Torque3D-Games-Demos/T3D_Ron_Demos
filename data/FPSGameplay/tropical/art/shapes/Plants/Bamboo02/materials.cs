
singleton Material(Bamboo_02__td_Bamboo_02)
{
   mapTo = "_td_Bamboo_02";
   diffuseMap[0] = "./3TD_BambooBark02";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./3TD_BambooBark02_NRM.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(Bamboo_02_YoungBamboo_01)
{
   mapTo = "YoungBamboo_01";
   diffuseMap[0] = "./3TD_YoungBamboo_01";
   specular[0] = "0.972549 0.972549 0.972549 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.827451 0.862745 0.482353 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   specularMap[0] = "./3TD_YoungBamboo_01_SPEC.png";
};
