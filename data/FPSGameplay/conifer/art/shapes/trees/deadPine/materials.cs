//--- DeadPine_Down.DAE MATERIALS BEGIN ---

singleton Material(DeadPine_Down_deadwood)
{
	mapTo = "deadwood";

	diffuseMap[0] = "./DeadTree_tile";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

singleton Material(DeadPine_Down_deadpine21)
{
	mapTo = "deadpine21";

	diffuseMap[0] = "./PineBranch_DIF.dds";
	normalMap[0] = "./PineBranch_NRM.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = 1;
	translucent = 0;
	translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "120";
};

//--- DeadPine_Down.DAE MATERIALS END ---


singleton Material(DeadPine_Down_rotpine)
{
   mapTo = "rotpine";
   diffuseMap[0] = "./pine_bark03.dds";
   normalMap[0] = "./pine_bark03_NRM.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
};

singleton Material(DownPine002_downpinemat)
{
   mapTo = "downpinemat";
   diffuseMap[0] = "./DeadTree_tile";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./DeadTree_tile_NRM";
   useAnisotropic[0] = "1";
};
