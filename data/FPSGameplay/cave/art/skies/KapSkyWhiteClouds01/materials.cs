
new CubemapData(ThreeTDSummer)
{
   cubeFace[0] = "./WhiteCloudRight.jpg";
   cubeFace[1] = "./WhiteCloudLeft.jpg";
   cubeFace[2] = "./WhiteCloudBack.jpg";
   cubeFace[3] = "./WhiteCloudFront.jpg";
   cubeFace[4] = "./WhiteCloudUp.jpg";
   cubeFace[5] = "./WhiteCloudDown.jpg";
};

singleton Material(KapSummerSky)
{
   mapTo = "unmapped_mat";
   cubemap = "ThreeTDSummer";
};