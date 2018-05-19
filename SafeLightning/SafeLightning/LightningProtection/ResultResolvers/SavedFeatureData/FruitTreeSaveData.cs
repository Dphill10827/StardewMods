﻿using Microsoft.Xna.Framework;
using StardewValley.TerrainFeatures;

namespace SafeLightning.LightningProtection.ResultResolvers.SavedFeatureData
{
    /// <summary>
    ///     Save the number of fruits on the <see cref="FruitTree" /> before it is modified.
    /// </summary>
    internal class FruitTreeSaveData : BaseFeatureSaveData
    {
        public int FruitsOnTree;

        public FruitTreeSaveData(Vector2 featurePosition, FruitTree feature) : base(featurePosition, feature)
        {
            this.FruitsOnTree = feature.fruitsOnTree.Value;
        }
    }
}