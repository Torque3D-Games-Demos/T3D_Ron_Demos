
singleton TSShapeConstructor(GenericBush_03Dae)
{
   baseShape = "./genericBush_03.dae";
};

function GenericBush_03Dae::onLoad(%this)
{
   %this.addImposter("64", "6", "0", "0", "512", "1", "0");
}
