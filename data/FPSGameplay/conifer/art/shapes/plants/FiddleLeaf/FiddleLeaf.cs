
singleton TSShapeConstructor(FiddleLeafDAE)
{
   baseShape = "./FiddleLeaf.DAE";
};

function FiddleLeafDAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
