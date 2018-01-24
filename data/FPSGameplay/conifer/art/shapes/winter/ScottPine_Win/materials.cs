
singleton Material(scrubPine_SoftPineBark)
{
   mapTo = "SoftPineBark";
   diffuseMap[0] = "./Piney.dds";
   normalMap[0] = "./Piney_NRM.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
};

singleton Material(ScottPine_winter_SoftPine2_Winter)
{
   mapTo = "SoftPine2_Winter";
   diffuseMap[0] = "./LushPine_Snow.dds";
   normalMap[0] = "./LushPine_Snow_NRM.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
};
