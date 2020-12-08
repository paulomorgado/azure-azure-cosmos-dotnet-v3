﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace Microsoft.Azure.Cosmos.Json
{
    /// <summary>
    /// Interface for all TypedBinaryJsonWriter that know how to write typed binary JSON.
    /// </summary>
#if INTERNAL
    public
#else
    internal
#endif
    interface ITypedBinaryJsonWriter : IJsonWriter
    {
        /// <summary>
        /// Writes a pre-blitted binary JSON scope.
        /// </summary>
        /// <param name="scope"></param>
        void Write(JsonWriter.PreblittedBinaryJsonScope scope);

#pragma warning disable SA1310
        /// <summary>
        /// Writes a "{ $t: cosmosBsonType, $v: " snippet.
        /// </summary>
        /// <param name="cosmosBsonTypeByte">Cosmos BSON type.</param>
        void Write_DollarT_BsonType_DollarV(byte cosmosBsonTypeByte);

        /// <summary>
        /// Writes a "{ $t: cosmosBsonType, $v: {" snippet (or "{ $t: cosmosBsonType, $v: [" if array).
        /// </summary>
        /// <param name="isNestedArray">Indicates whether the nested scope should be an array.</param>
        /// <param name="cosmosBsonTypeByte">Cosmos BSON type.</param>
        void Write_DollarT_BsonType_DollarV_NestedScope(bool isNestedArray, byte cosmosBsonTypeByte);
#pragma warning restore SA1310
    }
}