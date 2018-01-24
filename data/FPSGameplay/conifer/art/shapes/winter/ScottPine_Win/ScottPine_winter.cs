
singleton TSShapeConstructor(ScottPine_winterDAE2)
{
   baseShape = "./ScottPine_winter.DAE";
};

function ScottPine_winterDAE2::onLoad(%this)
{
   %this.addImposter("128", "4", "0", "0", "512", "1", "0");
}
