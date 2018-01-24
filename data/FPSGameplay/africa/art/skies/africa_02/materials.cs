//-----------------------------------------------------------------------------
// Copyright (c) 2012 3TD Studios
//
//-----------------------------------------------------------------------------

singleton CubemapData( AfricaSky_02 )
{
   cubeFace[0] = "./cubemap/africa02_Right";
   cubeFace[1] = "./cubemap/africa02_Left";
   cubeFace[2] = "./cubemap/africa02_Back";
   cubeFace[3] = "./cubemap/africa02_Front";
   cubeFace[4] = "./cubemap/africa02_up";
   cubeFace[5] = "./cubemap/africa02_Down";
};

singleton Material( AfricaSky_02Mat )
{
   cubemap = AfricaSky_02Cubemap;
};
