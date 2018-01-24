
singleton TSShapeConstructor(DeadStandingPine01DAE)
{
   baseShape = "./DeadStandingPine01.DAE";
};

function DeadStandingPine01DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
