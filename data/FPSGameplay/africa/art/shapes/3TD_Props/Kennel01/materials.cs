
singleton Material(Kennel01_metalPole0)
{
   mapTo = "metalPole0";
   diffuseMap[0] = "./3TD_MetalPoles_01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "24";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(Kennel01_chainlink01)
{
   mapTo = "chainlink01";
   diffuseMap[0] = "./3td_chainLink01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "9";
   translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
};

singleton Material(Kennel01_Corrigate01)
{
   mapTo = "Corrigate01";
   diffuseMap[0] = "./3TD_Corrigate_Rust_01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "6";
   translucentBlendOp = "None";
   normalMap[0] = "./3TD_Corrigate_Rust_01_NRM.png";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaRef = "0";
};

singleton Material(Kennel01_WoodPlank01)
{
   mapTo = "WoodPlank01";
   diffuseMap[0] = "./3td_WoodPlank_02";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(Kennel01__5___Default)
{
   mapTo = "_5_-_Default";
   diffuseColor[0] = "0.588235 0.588235 0.588235 1";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
