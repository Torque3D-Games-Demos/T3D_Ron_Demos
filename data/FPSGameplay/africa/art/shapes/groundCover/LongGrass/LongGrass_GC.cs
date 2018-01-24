
singleton TSShapeConstructor(LongGrass_GCDAE)
{
   baseShape = "./LongGrass_GC.DAE";
   loadLights = "0";
};

function LongGrass_GCDAE::onLoad(%this)
{
   %this.removeImposter();
}
