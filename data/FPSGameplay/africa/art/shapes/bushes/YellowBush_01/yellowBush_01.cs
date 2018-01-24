
singleton TSShapeConstructor(YellowBush_01Dae)
{
   baseShape = "./yellowBush_01.dae";
};

function YellowBush_01Dae::onLoad(%this)
{
   %this.addImposter("48", "6", "0", "0", "512", "1", "0");
}
