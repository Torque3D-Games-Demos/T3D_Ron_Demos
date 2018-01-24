
singleton TSShapeConstructor(AfricaTree_01Dae)
{
   baseShape = "./AfricaTree_01.dae";
};

function AfricaTree_01Dae::onLoad(%this)
{
   %this.addImposter("50", "6", "0", "0", "512", "1", "0");
}
