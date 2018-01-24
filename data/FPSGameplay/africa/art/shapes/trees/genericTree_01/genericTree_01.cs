
singleton TSShapeConstructor(GenericTree_01Dae)
{
   baseShape = "./genericTree_01.dae";
   loadLights = "0";
};

function GenericTree_01Dae::onLoad(%this)
{
   %this.addImposter("48", "6", "0", "0", "512", "1", "0");
}
