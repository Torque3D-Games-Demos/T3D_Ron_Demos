
singleton TSShapeConstructor(DeadPine_DownDAE)
{
   baseShape = "./DeadPine_Down.DAE";
};

function DeadPine_DownDAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
