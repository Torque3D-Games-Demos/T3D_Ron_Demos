// Motion Blur Base Script File
// Added by Ron Kapaun 
// Based on Contributions by GG Community Member: Enel
//------------------------------------------------------

singleton ShaderData( PFX_MotionBlurShader )  
{     
   DXVertexShaderFile   = "shaders/common/postFx/postFxV.hlsl";  //we use the bare-bones postFxV.hlsl
   DXPixelShaderFile    = "shaders/common/postFx/motionBlurP.hlsl";  //new pixel shader
   
   pixVersion = 3.0;  
};  

singleton PostEffect(MotionBlurFX)  
{
   isEnabled = true; //added to enable motion blur on level start

   renderTime = "PFXAfterDiffuse";  

   shader = PFX_MotionBlurShader;  
   stateBlock = PFX_DefaultStateBlock;  
   texture[0] = "$backbuffer";
   texture[1] = "#prepass";
   target = "$backBuffer";
};

function MotionBlurFX::setShaderConsts(%this)
{
   %this.setShaderConst( "$velocityMultiplier", 1000 );
}
