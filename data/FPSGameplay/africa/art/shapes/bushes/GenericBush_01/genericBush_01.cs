
singleton TSShapeConstructor(GenericBush_01Dae)
{
   baseShape = "./genericBush_01.dae";
};

function GenericBush_01Dae::onLoad(%this)
{
   %this.addImposter("64", "6", "0", "0", "512", "1", "0");
}
