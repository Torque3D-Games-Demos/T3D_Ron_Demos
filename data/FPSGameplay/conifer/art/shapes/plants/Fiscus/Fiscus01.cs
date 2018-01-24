
singleton TSShapeConstructor(Fiscus01DAE)
{
   baseShape = "./Fiscus01.DAE";
};

function Fiscus01DAE::onLoad(%this)
{
   %this.addImposter("64", "6", "0", "0", "512", "1", "0");
}
