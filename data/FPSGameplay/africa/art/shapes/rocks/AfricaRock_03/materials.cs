
singleton Material(africaRock_03_RedRock_01)
{
   mapTo = "RedRock_01";
   diffuseMap[0] = "./3td_RedRock_01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "24";
   translucentBlendOp = "None";
   normalMap[0] = "./3td_RedRock_05_NRM.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(africaRock_03_LR_redRock01)
{
   mapTo = "LR_redRock01";
   diffuseMap[0] = "3td_RedRock_01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(africaRock_03_bk_africarockthreeDIF)
{
   mapTo = "bk_africarockthreeDIF";
   diffuseMap[0] = "./africarockthree256_DIF";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./africarockthree256_NRM.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   materialTag0 = "RoadAndPath";
};
