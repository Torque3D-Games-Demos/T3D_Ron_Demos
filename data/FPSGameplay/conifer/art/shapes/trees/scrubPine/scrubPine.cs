
singleton TSShapeConstructor(ScrubPineDAE)
{
   baseShape = "./scrubPine.DAE";
};

function ScrubPineDAE::onLoad(%this)
{
   %this.addImposter("128", "4", "0", "0", "256", "1", "0");
}
