//-----------------------------------------------------------------------------
// Copyright (c) 2012 3TD Studios
//
//-----------------------------------------------------------------------------

singleton CubemapData( AfricaSky_01Cubemap )
{
   cubeFace[0] = "./cubemap/africa01_Right";
   cubeFace[1] = "./cubemap/africa01_Left";
   cubeFace[2] = "./cubemap/africa01_Back";
   cubeFace[3] = "./cubemap/africa01_Front";
   cubeFace[4] = "./cubemap/africa01_up";
   cubeFace[5] = "./cubemap/africa01_Down";
};

singleton Material( AfricaSky_01Mat )
{
   cubemap = AfricaSky_01Cubemap;
   materialTag0 = "Skies";
};
