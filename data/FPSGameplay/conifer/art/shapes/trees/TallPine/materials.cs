//--- TallPine01.DAE MATERIALS BEGIN ---
singleton Material(TallPine01_TallPineBare)
{
	mapTo = "TallPineBare";

	diffuseMap[0] = "./PineBranch_DIF.dds";
	normalMap[0] = "./PineBranch_NRM.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = 1;
	translucent = "1";
	translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "140";
   useAnisotropic[0] = "1";
};

singleton Material(TallPine01_TallPineNeed)
{
	mapTo = "TallPineNeed";

	diffuseMap[0] = "./pinetree001.dds";
	normalMap[0] = "./pinetree001_NRM.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = "1";

	doubleSided = 1;
	translucent = false;
	translucentBlendOp = "LerpAlpha";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.627451 0.768628 0.0117647 1";
   alphaTest = "1";
   alphaRef = "140";
   subSurfaceRolloff[0] = "0.4";
};

singleton Material(TallPine01_TallPineBark)
{
	mapTo = "TallPineBark";

	diffuseMap[0] = "./SequiaBark_DIF.dds";
	normalMap[0] = "./SequiaBark_NRM.dds";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.45098 0.380392 0.254902 1";
	specularPower[0] = "21";

	doubleSided = "1";
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   showFootprints = "0";
};

//--- TallPine01.DAE MATERIALS END ---


singleton Material(BB_Pine__4___Default)
{
   mapTo = "_4_-_Default";
   diffuseMap[0] = "./billboard_tallpine01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "LerpAlpha";
   diffuseColor[0] = "0.992157 0.996078 0.992157 1";
   detailScale[0] = "1 1";
   emissive[0] = "1";
   doubleSided = "1";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(BB_Pine_BillBoard_Seq)
{
   mapTo = "BillBoard_Seq";
   diffuseMap[0] = "./billboard_tallpine01";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "LerpAlpha";
   doubleSided = "1";
   translucentZWrite = "0";
   alphaTest = "1";
   alphaRef = "147";
   emissive[0] = "0";
   detailScale[0] = "1 1";
   useAnisotropic[0] = "1";
   materialTag0 = "RoadAndPath";
   castShadows = "1";
   subSurfaceColor[0] = "0.2 0.364706 0.0392157 1";
   translucent = "0";
};

singleton Material(DTSSequia_Dead02)
{
   mapTo = "Dead02";
   diffuseMap[0] = "./DeadBranch02.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(DTSSequia_Dead01)
{
   mapTo = "Dead01";
   diffuseMap[0] = "./DeadBranch01.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(Sequia_02_Broken01)
{
   mapTo = "Broken01";
   diffuseMap[0] = "./DeadBranch01a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "25";
};

singleton Material(Sequia_02_Broken02)
{
   mapTo = "Broken02";
   diffuseMap[0] = "./DeadBranch02a.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "25";
   useAnisotropic[0] = "1";
};

singleton Material(Sequia_02_Seq01Branch)
{
   mapTo = "Seq01Branch";
   diffuseMap[0] = "./pinetree001.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./pinetree001_NRM.dds";
   specularMap[0] = "./pinetree001_SPEC.dds";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   subSurfaceColor[0] = "0.827451 0.878431 0.431373 1";
   subSurfaceRolloff[0] = "0.8";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
};

singleton Material(Sequia_02_Seq02Bark)
{
   mapTo = "Seq02Bark";
   diffuseMap[0] = "./SequiaBark_DIF.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "10";
   translucentBlendOp = "None";
   normalMap[0] = "./SequiaBark_NRM.dds";
   doubleSided = "1";
};

