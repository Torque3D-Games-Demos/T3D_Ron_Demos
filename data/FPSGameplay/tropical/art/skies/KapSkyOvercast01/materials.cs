
singleton Material(KapSkyOvercast)
{
   mapTo = "unmapped_mat";
   cubemap = "KapSkyOvercast01";
   materialTag0 = "KapSkys";
};

singleton Material(KapSkyOvercast1)
{
   mapTo = "unmapped_mat";
   materialTag0 = "KapSkys";
   cubemap = "KapSkyOvercast01";
   useAnisotropic[0] = "1";
   rotPivotOffset[0] = "-0.24 0";
};

new CubemapData(KapSkyOvercast01)
{
   cubeFace[0] = "./CastRight.jpg";
   cubeFace[1] = "./CastLeft.jpg";
   cubeFace[2] = "./CastBack.jpg";
   cubeFace[3] = "./CastFront.jpg";
   cubeFace[4] = "./CastUp.jpg";
   cubeFace[5] = "./CastDown.jpg";
};