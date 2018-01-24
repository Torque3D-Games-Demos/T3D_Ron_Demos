//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

singleton Material( AfricaDecalRoadMaterial )
{
   diffuseMap[0] = "./3td_AfricaRoad_01H.png";
   mapTo = "unmapped_mat";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "./3td_AfricaRoad_01_NRMP.png";
   useAnisotropic[0] = "1";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(AfricaRoadMaterialOther)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "./3td_AfricaRoad_01H.png";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "./3td_AfricaRoad_01_NRMP.png";
   parallaxScale[0] = "0.02";
   useAnisotropic[0] = "1";
   doubleSided = "0";
   translucent = "1";
   alphaTest = "1";
   alphaRef = "40";
   castShadows = "0";
   translucentBlendOp = "None";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";
};
