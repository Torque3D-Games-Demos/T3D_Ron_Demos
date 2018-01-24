
singleton TSShapeConstructor(ReedMod01DAE)
{
   baseShape = "./ReedMod01.DAE";
};

function ReedMod01DAE::onLoad(%this)
{
   %this.addImposter("64", "4", "0", "0", "512", "1", "0");
}
