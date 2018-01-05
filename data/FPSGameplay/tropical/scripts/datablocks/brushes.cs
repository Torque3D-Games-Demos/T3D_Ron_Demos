
echo("*** LOAD TROPICAL RAINFOREST DATABLOCKS - brushes.cs ***");

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

// This is the default save location for any ForestBrush(s) created in 
// the Forest Editor.
// This script is executed from ForestEditorPlugin::onWorldEditorStartup().

//--- OBJECT WRITE BEGIN ---
new SimGroup(TropicalBrushGroup) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new ForestBrush() {
      internalName = "ExampleForestBrush";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "Palm03";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "BeachRock_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Palm01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "CiabaTree_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Bamboo_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Bamboo2";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.6";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0.01";
         sinkMax = "0.03";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "BeachGrass2";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "3";
         scaleExponent = "1";
         sinkMin = "0.01";
         sinkMax = "0.03";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "SmallStone01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "0.75";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Stone2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Stone2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "2";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.5";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "TropicFern2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "TropicFern2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "3";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "BeachPalm2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BeachPalm2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "CopalTree01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "CopalTree01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "QueensPalm2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "QueensPalm2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Phila2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Phila2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Bush2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Bush2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "ElephantEar2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "ElephantEar2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Palm02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Palm02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Banana2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "Banana2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "BirdNestPlant01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "BirdNestPlant01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "OceanPlants";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "SeaPlant_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "SeaPlant_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.7";
         scaleMax = "1.2";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "Kelp_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1.5";
         scaleMax = "2.5";
         scaleExponent = "1";
         sinkMin = "0.2";
         sinkMax = "0.4";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
};
//--- OBJECT WRITE END ---
