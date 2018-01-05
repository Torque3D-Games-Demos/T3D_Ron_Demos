
singleton Material(Stone01_MossRockRed)
{
   mapTo = "MossRockRed";
   diffuseMap[0] = "./MossRock01.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "25";
   translucentBlendOp = "None";
   normalMap[0] = "./normal_rock1.dds";
   materialTag0 = "RoadAndPath";
   specularMap[0] = "./MossRock01_SPEC.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   diffuseColor[0] = "0.996078 0.996078 0.992157 1";
   detailNormalMap[0] = "./MossRock01_NRM.dds";
};

singleton Material(JungleOverhang)
{
   mapTo = "JungleOverhang";
   diffuseMap[0] = "./MossRock01.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "25";
   translucentBlendOp = "None";
   normalMap[0] = "./normal_rock1.dds";
   specularMap[0] = "./MossRock01_SPEC.png";
   useAnisotropic[0] = "1";
   detailNormalMap[0] = "./MossRock02_NRM.png";
   detailNormalMapStrength[0] = "2";
};

singleton Material(GroupRocks01_MossyStones)
{
   mapTo = "MossyStones";
   diffuseMap[0] = "./MossRock02.jpg";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "25";
   translucentBlendOp = "None";
   normalMap[0] = "./normal_rock1.dds";
   detailNormalMap[0] = "./MossRock02_NRM.png";
   specularMap[0] = "./MossRock02_SPEC.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   detailNormalMapStrength[0] = "2";
};

singleton Material(SquareRock01_SquareRock_T)
{
   mapTo = "SquareRock_T";
   diffuseMap[0] = "./MossRock01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "25";
   translucentBlendOp = "Mul";
   normalMap[0] = "./normal_rock1.dds";
   detailNormalMap[0] = "./MossRock01_NRM.png";
   specularMap[0] = "./MossRock01_SPEC.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaRef = "20";
};

singleton Material(SmallStone01_SmallStone_T)
{
   mapTo = "SmallStone_T";
   diffuseMap[0] = "./MossRock02";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "25";
   translucentBlendOp = "None";
   normalMap[0] = "./normal_rock1.dds";
   detailNormalMap[0] = "./MossRock02_NRM.png";
   specularMap[0] = "./MossRock02_SPEC.png";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(Rock05)
{
   mapTo = "Rock05";
   diffuseMap[0] = "rock01a";
   specular[0] = "0.2 0.2 0.2 1";
   specularPower[0] = "43.2193";
   translucentBlendOp = "None";
};
