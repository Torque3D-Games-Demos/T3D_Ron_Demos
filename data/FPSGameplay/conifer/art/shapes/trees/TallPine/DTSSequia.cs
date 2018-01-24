
singleton TSShapeConstructor(DTSSequiaDAE)
{
   baseShape = "./DTSSequia.DAE";
   loadLights = "0";
};

function DTSSequiaDAE::onLoad(%this)
{
   %this.addImposter("128", "4", "0", "0", "256", "1", "0");
}
