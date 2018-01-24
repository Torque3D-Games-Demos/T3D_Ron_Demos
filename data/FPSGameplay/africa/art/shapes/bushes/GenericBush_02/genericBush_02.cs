
singleton TSShapeConstructor(GenericBush_02Dae)
{
   baseShape = "./genericBush_02.dae";
};

function GenericBush_02Dae::onLoad(%this)
{
   %this.addImposter("64", "6", "0", "0", "512", "1", "0");
}
