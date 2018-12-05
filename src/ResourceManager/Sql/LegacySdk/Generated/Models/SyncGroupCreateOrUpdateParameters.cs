// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// The parameters of creating or updating sync group.
    /// </summary>
    public partial class SyncGroupCreateOrUpdateParameters
    {
        private SyncGroupCreateOrUpdateProperties _properties;
        
        /// <summary>
        /// Required. Specifies other properties of a sync group.
        /// </summary>
        public SyncGroupCreateOrUpdateProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private string _syncGroupName;
        
        /// <summary>
        /// Required. Specifies the name of a sync group.
        /// </summary>
        public string SyncGroupName
        {
            get { return this._syncGroupName; }
            set { this._syncGroupName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupCreateOrUpdateParameters
        /// class.
        /// </summary>
        public SyncGroupCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the SyncGroupCreateOrUpdateParameters
        /// class with required arguments.
        /// </summary>
        public SyncGroupCreateOrUpdateParameters(string syncGroupName, SyncGroupCreateOrUpdateProperties properties)
            : this()
        {
            if (syncGroupName == null)
            {
                throw new ArgumentNullException("syncGroupName");
            }
            if (properties == null)
            {
                throw new ArgumentNullException("properties");
            }
            this.SyncGroupName = syncGroupName;
            this.Properties = properties;
        }
    }
}
