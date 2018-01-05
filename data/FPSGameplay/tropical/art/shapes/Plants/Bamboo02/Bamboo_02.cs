
singleton TSShapeConstructor(Bamboo_02Dae)
{
   baseShape = "./Bamboo_02.dae";
};

function Bamboo_02Dae::onLoad(%this)
{
   %this.addImposter("60", "6", "0", "0", "512", "1", "0");
}
