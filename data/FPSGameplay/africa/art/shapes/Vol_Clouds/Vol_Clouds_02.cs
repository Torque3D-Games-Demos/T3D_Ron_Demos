//-----------------------------------------------------------------------------
// Torque
// Copyright 3TD Studios, 2012
// Volumetric Cloud Rotate to View Script
//-----------------------------------------------------------------------------

singleton TSShapeConstructor(Vol_Cloud_02DAE)
{
   baseShape = "./Vol_Clouds_02.DAE";
   loadLights = "0";
};

function Vol_Cloud_02DAE::onLoad(%this)
{
   %this.setMeshType("grouptwo 400", "billboard");
   %this.setObjectNode("grouptwo", "grouptwo400");
   %this.setMeshType("groupthree 400", "billboard");
   %this.setObjectNode("groupthree", "groupthree400");
   %this.setMeshType("groupsix 400", "billboard");
   %this.setObjectNode("groupsix", "groupsix400");
   %this.setMeshType("groupone 400", "billboard");
   %this.setObjectNode("groupone", "groupone400");
   %this.setMeshType("groupfour 400", "billboard");
   %this.setObjectNode("groupfour", "groupfour400");
   %this.setMeshType("groupfive 400", "billboard");
   %this.setObjectNode("groupfive", "groupfive400");
}
