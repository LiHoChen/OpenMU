﻿// <copyright file="ServerEndpoint.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.DataModel.Configuration
{
    /// <summary>
    /// Defines an endpoint of a server.
    /// </summary>
    public abstract class ServerEndpoint
    {
        /// <summary>
        /// Gets or sets the network port on which the server is listening.
        /// </summary>
        public int NetworkPort { get; set; }

        /// <summary>
        /// Gets or sets the client which is expected to connect.
        /// </summary>
        public virtual GameClientDefinition Client { get; set; }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Client: {this.Client}; Port: {this.NetworkPort}";
        }
    }
}