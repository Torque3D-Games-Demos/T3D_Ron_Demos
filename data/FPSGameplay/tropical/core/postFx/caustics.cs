//-----------------------------------------------------------------------------
// Torque 3D
// Copyright (C) GarageGames.com, Inc.
// Original file by: Manoel Neto Adjusted by Ron Kapaun
//-----------------------------------------------------------------------------


singleton GFXStateBlockData( PFX_CausticsStateBlock : PFX_DefaultStateBlock )
{
   blendDefined = true;
   blendEnable = true; 
   blendSrc = GFXBlendOne;
   blendDest = GFXBlendOne;
   
   samplersDefined = true;
   samplerStates[0] = SamplerClampLinear;
   samplerStates[1] = SamplerWrapLinear;
   samplerStates[2] = SamplerWrapLinear;
};

singleton ShaderData( PFX_CausticsShader )
{   
   DXVertexShaderFile 	= "shaders/common/postFx/postFxV.hlsl";
   DXPixelShaderFile 	= "shaders/common/postFx/caustics/causticsP.hlsl";
         
   //OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
   //OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";
      
   samplerNames[0] = "$prepassTex";
   samplerNames[1] = "$causticsTex1";
   samplerNames[2] = "$causticsTex2";
   
   pixVersion = 3.0;
};

singleton PostEffect( CausticsPFX )
{
   requirements = "None";
   isEnabled = true;
   renderTime = "PFXBeforeBin";
   renderBin = "ObjTranslucentBin";      
   //renderPriority = 0.1;
      
   shader = PFX_CausticsShader;
   stateBlock = PFX_CausticsStateBlock;
   texture[0] = "#prepass";
   texture[1] = "textures/caustics_1";
   texture[2] = "textures/caustics_2";
   target = "$backBuffer";
   
};

// this effects the timing of the animation -

$CausticsPFX::refTime = getSimTime();

function CausticsPFX::setShaderConsts(%this)
{
   //echo($Sim::time - %this.timeStart);
   //echo(%this.timeConst);
   %this.setShaderConst( "$refTime", $CausticsPFX::refTime ); 
}

