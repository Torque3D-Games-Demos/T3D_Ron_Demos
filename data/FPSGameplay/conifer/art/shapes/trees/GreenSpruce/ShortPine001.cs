
singleton TSShapeConstructor(ShortPine001DAE)
{
   baseShape = "./ShortPine001.DAE";
   loadLights = "0";
};

function ShortPine001DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
