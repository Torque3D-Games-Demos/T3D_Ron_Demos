
singleton Material(BirdNestPlant01_BirdNestLeaf02)
{
   mapTo = "BirdNestLeaf02";
   diffuseMap[0] = "./birdnest01.dds";
   normalMap[0] = "./birdnest01_NRM.dds";
   specularMap[0] = "./birdnest01_SPEC.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "21";
   translucentBlendOp = "LerpAlpha";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
};

singleton Material(BirdNestPlant01_BirdNestBark01)
{
   mapTo = "BirdNestBark01";
   diffuseMap[0] = "banana_bark";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};
