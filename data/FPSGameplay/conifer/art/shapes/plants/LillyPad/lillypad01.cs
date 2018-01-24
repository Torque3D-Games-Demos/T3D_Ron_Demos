
singleton TSShapeConstructor(Lillypad01DAE)
{
   baseShape = "./lillypad01.DAE";
};

function Lillypad01DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "6", "0", "512", "1", "0");
}
