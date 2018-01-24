
singleton TSShapeConstructor(Plant001DAE)
{
   baseShape = "./Plant001.DAE";
   loadLights = "0";
};

function Plant001DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "256", "1", "0");
}
