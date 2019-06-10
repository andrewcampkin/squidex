﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

namespace Squidex.Domain.Apps.Entities.Assets
{
    public sealed class AssetCreatedResult
    {
        public IAssetEntity Asset { get; }

        public bool IsDuplicate { get; }

        public AssetCreatedResult(IAssetEntity asset, bool isDuplicate)
        {
            Asset = asset;

            IsDuplicate = isDuplicate;
        }
    }
}
