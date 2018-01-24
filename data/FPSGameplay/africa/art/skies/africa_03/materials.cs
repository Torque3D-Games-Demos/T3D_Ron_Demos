//-----------------------------------------------------------------------------
// Copyright (c) 2012 3TD Studios
//
//-----------------------------------------------------------------------------

singleton CubemapData( AfricaSky_03 )
{
   cubeFace[0] = "./cubemap/AfricaSky03_RGT";
   cubeFace[1] = "./cubemap/AfricaSky03_LFT";
   cubeFace[2] = "./cubemap/AfricaSky03_BAK";
   cubeFace[3] = "./cubemap/AfricaSky03_FRT";
   cubeFace[4] = "./cubemap/AfricaSky03_up";
   cubeFace[5] = "./cubemap/africa03_Down";
};

singleton Material( AfricaSky_03Mat )
{
   cubemap = AfricaSky_03Cubemap;
};
