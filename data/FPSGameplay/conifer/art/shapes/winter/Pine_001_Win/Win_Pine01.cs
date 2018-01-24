
singleton TSShapeConstructor(Win_Pine01DAE)
{
   baseShape = "./Win_Pine01.DAE";
   adjustFloor = "1";
   loadLights = "0";
};

function Win_Pine01DAE::onLoad(%this)
{
   %this.addImposter("1", "4", "0", "0", "512", "1", "0");
}
