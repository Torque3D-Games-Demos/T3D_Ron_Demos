singleton Material(Pine001_PineNeedles)
{
   mapTo = "PineNeedles";
   diffuseMap[0] = "./pinetree001.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "LerpAlpha";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "160";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "1 0.952941 0 1";
   normalMap[0] = "./pinetree001_NRM.dds";
   subSurfaceRolloff[0] = "0.4";
   specularMap[0] = "./pinetree001_SPEC.dds";
};

singleton Material(Pine001_DeadPineNeedles)
{
   mapTo = "DeadPineNeedles";
   diffuseMap[0] = "./PineBranch_DIF.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "LerpAlpha";
   doubleSided = "1";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "181";
   normalMap[0] = "./PineBranch_NRM.dds";
   useAnisotropic[0] = "1";
};

singleton Material(Pine001_PineBark)
{
   mapTo = "PineBark";
   diffuseMap[0] = "./PineLight_DIF.dds";
   specular[0] = "0.435294 0.360784 0.223529 1";
   specularPower[0] = "1";
   translucentBlendOp = "None";
   normalMap[0] = "./PineLight_NRM.dds";
   doubleSided = "1";
   useAnisotropic[0] = "1";
   showFootprints = "0";
   detailScale[0] = "1 1";
   pixelSpecular[0] = "0";
};

singleton Material(ShortPine001_HighPine01)
{
   mapTo = "HighPine01";
   diffuseMap[0] = "./pinetree001.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./pinetree001_NRM.dds";
   specularMap[0] = "./pinetree001_SPEC.dds";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.772549 0.847059 0.45098 1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   useAnisotropic[0] = "1";
   subSurfaceRolloff[0] = "0.7";
};

singleton Material(ShortPine001_BarePine)
{
   mapTo = "BarePine";
   diffuseMap[0] = "./PineBranch_DIF.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./PineBranch_NRM.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(ShortPine001_PineBark01)
{
   mapTo = "PineBark01";
   diffuseMap[0] = "./PineLight_DIF.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./PineLight_NRM.dds";
};

singleton Material(ShortPine001_ColorEffectR6G135B6_material)
{
   mapTo = "ColorEffectR6G135B6-material";
   diffuseColor[0] = "0.0235294 0.529412 0.0235294 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
