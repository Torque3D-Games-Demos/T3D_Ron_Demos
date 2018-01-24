
singleton Material(lillypad01_Lpad01)
{
   mapTo = "Lpad01";
   diffuseMap[0] = "./lilipads01";
   normalMap[0] = "./lilipads01_NRM.png";
   specularMap[0] = "./lilipads01_SPEC.png";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "134";
};

singleton Material(lillypad01_LpadStem)
{
   mapTo = "LpadStem";
   diffuseMap[0] = "./lilystem";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
   useAnisotropic[0] = "1";
};
