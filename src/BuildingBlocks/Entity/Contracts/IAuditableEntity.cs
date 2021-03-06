﻿using System;

namespace BuildingBlocks.Contracts.Entities
{
    public interface IAuditableEntity<T> : IBasicEntity<T>, ITimeStampEntity where T : IEquatable<T>, new()
    {
        void PrepareForUpdate(IAuditableEntity<T> incomingObj);

    }
}