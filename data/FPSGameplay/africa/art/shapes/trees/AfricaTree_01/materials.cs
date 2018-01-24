
singleton Material(AfricaTree_01_ColorEffectR8G8B136_material)
{
   mapTo = "ColorEffectR8G8B136-material";
   diffuseColor[0] = "0.0313726 0.0313726 0.533333 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(AfricaTree_01_AfricaTreeBark03)
{
   mapTo = "AfricaTreeBark03";
   diffuseMap[0] = "data/FPSGameplay/africa/art/shapes/trees/AfricaTree_01/3td_Boabab_Bark02";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   parallaxScale[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(AfricaTree_01_AfricaTreeLeaf)
{
   mapTo = "AfricaTreeLeaf";
   diffuseMap[0] = "data/FPSGameplay/africa/art/shapes/trees/AfricaTree_01/3td_AcaciaBranch_03";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
};
