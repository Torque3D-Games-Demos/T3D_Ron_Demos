//--- scrubPine.DAE MATERIALS BEGIN ---
singleton Material(scrubPine_SoftPine2)
{
	mapTo = "SoftPine2";

	diffuseMap[0] = "./LushPine.dds";
	normalMap[0] = "./LushPine_NRM.dds";

	diffuseColor[0] = "0.996078 0.992157 0.992157 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = "1";

	doubleSided = 1;
	translucent = 0;
	translucentBlendOp = "LerpAlpha";
   useAnisotropic[0] = "1";
   subSurface[0] = "1";
   alphaTest = "1";
   alphaRef = "50";
   pixelSpecular[0] = "0";
   specularMap[0] = "./LushPine_SPEC.dds";
   showFootprints = "0";
   subSurfaceColor[0] = "0.537255 0.619608 0.121569 1";
   subSurfaceRolloff[0] = "1";
};

//--- scrubPine.DAE MATERIALS END ---

