﻿using System.Collections.Generic;

namespace LibraryMgmt.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}
