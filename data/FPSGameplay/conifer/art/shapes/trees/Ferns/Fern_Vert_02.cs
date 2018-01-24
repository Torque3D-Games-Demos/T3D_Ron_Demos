
singleton TSShapeConstructor(Fern_Vert_02DAE)
{
   baseShape = "./Fern_Vert_02.DAE";
   loadLights = "0";
};

function Fern_Vert_02DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
