
singleton TSShapeConstructor(DriPine01DAE)
{
   baseShape = "./DriPine01.DAE";
   loadLights = "0";
};

function DriPine01DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
