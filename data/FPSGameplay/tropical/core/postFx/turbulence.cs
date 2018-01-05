//-----------------------------------------------------------------------------
// Torque 3D
// Copyright (C) GarageGames.com, Inc.
//Original file by: Manoel Neto Adjusted by Ron Kapaun
//-----------------------------------------------------------------------------

singleton ShaderData( PFX_TurbulenceShader )
{   
   DXVertexShaderFile 	= "shaders/common/postFx/postFxV.hlsl";
   DXPixelShaderFile 	= "shaders/common/postFx/turbulenceP.hlsl";
           
   samplerNames[0] = "$inputTex";
   pixVersion = 3.0;
};

singleton PostEffect( TurbulenceFx )  
{  
   requirements = "None";
   isEnabled = false;    
   allowReflectPass = true;  
         
   renderTime = "PFXAfterDiffuse";  
   renderBin = "ObjTranslucentBin";     
     
   shader = PFX_TurbulenceShader;  
   stateBlock = PFX_myShaderStateBlock;  
   texture[0] = "$backBuffer";  
      
   renderPriority = 0.1;  
 };

function TurbulenceFx::setShaderConsts(%this)
{
   %this.setShaderConst(%this.timeConst, $Sim::time - %this.timeStart); 
}

function UnderwaterFogPostFx::onEnabled( %this )
{
   TurbulenceFx.enable();
   return true;
}

function UnderwaterFogPostFx::onDisabled( %this )
{
   TurbulenceFx.disable();
   return false; // added this to stop turbulence from pausing -RK
}