﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CrossSync.Entity
{
  /// <summary>
  /// Versionable entity server side implementation
  /// </summary>
  public abstract class VersionableEntity : CrossSync.Entity.Abstractions.Abstractions.Entity, IVersionableEntity
  {
    /// <summary>
    /// Gets the entity version.
    /// </summary>
    /// <remarks>Auto generated by SQL Server</remarks>
    [Timestamp]
    public byte[] Version { get; set; }

    /// <summary>
    /// Entity updated date used to filter entities which have to be requested by clients
    /// </summary>
    public DateTimeOffset UpdatedAt { get; set; }
  }
}
