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
new SimGroup(AfricaForestBrushGroup) {
   canSave = "1";
   canSaveDynamicFields = "1";

   new ForestBrush() {
      internalName = "AfricaRiverEnviron";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "genericBush4";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "genericBush4";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
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
         internalName = "stoneGroup_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "stoneGroup_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0.25";
         sinkMax = "0.5";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "acacciaTree_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "acacciaTree_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.5";
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
         internalName = "genericBush_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "genericBush_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.25";
         scaleMax = "0.75";
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
         internalName = "genericBush_03";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "genericBush_03";
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
         internalName = "genericTree_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "genericTree_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.5";
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
         internalName = "africanMahogany_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africanMahogany_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "waterReeds_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "waterReeds_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "genericBush_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "genericBush_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.25";
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
         internalName = "africanMahogany_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africanMahogany_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1.25";
         scaleMax = "2";
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
         internalName = "africaBush_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africaBush_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.01";
         sinkMax = "0.05";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "SavannahPlants";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "AfricaTree_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "AfricaTree_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.5";
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
         internalName = "africanThornBush_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africanThornBush_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.75";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "yellowBush2";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "yellowBush2";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.5";
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
         internalName = "AfricanWheatGrass_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "AfricanWheatGrass_01";
         probability = "100";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "umbreallAcacia_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "umbreallAcacia_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "umbrellaAcaciaFul_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "umbrellaAcaciaFul_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "africanThornbush_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africanThornbush_01";
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
      internalName = "RockFormations";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "africaRock_03";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africaRock_03";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "africaRock_04";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africaRock_04";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1";
         scaleExponent = "1";
         sinkMin = "0.01";
         sinkMax = "0.05";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "africaRock_05";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africaRock_05";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "2";
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
         internalName = "africaRock_06";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "africaRock_06";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.75";
         scaleMax = "1.2";
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
         internalName = "AfricaRock_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "AfricaRock_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "0.5";
         scaleMax = "1.5";
         scaleExponent = "1";
         sinkMin = "0.01";
         sinkMax = "0.05";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "AfricaRock_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "AfricaRock_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1.5";
         scaleMax = "3";
         scaleExponent = "1";
         sinkMin = "0.1";
         sinkMax = "0.4";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
   new ForestBrush() {
      internalName = "Debris";
      canSave = "1";
      canSaveDynamicFields = "1";

      new ForestBrushElement() {
         internalName = "debrisBlock_02";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "debrisBlock_02";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.2";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "StoneAndPlants_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "StoneAndPlants_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
      new ForestBrushElement() {
         internalName = "SticksandStones_01";
         canSave = "1";
         canSaveDynamicFields = "1";
         ForestItemData = "SticksandStones_01";
         probability = "1";
         rotationRange = "360";
         scaleMin = "1";
         scaleMax = "1.25";
         scaleExponent = "1";
         sinkMin = "0";
         sinkMax = "0.3";
         sinkRadius = "1";
         slopeMin = "0";
         slopeMax = "90";
         elevationMin = "-10000";
         elevationMax = "10000";
      };
   };
};
//--- OBJECT WRITE END ---
