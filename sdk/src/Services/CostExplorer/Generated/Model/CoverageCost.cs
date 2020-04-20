/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// How much it costs to run an instance.
    /// </summary>
    public partial class CoverageCost
    {
        private string _onDemandCost;

        /// <summary>
        /// Gets and sets the property OnDemandCost. 
        /// <para>
        /// How much an On-Demand Instance costs.
        /// </para>
        /// </summary>
        public string OnDemandCost
        {
            get { return this._onDemandCost; }
            set { this._onDemandCost = value; }
        }

        // Check to see if OnDemandCost property is set
        internal bool IsSetOnDemandCost()
        {
            return this._onDemandCost != null;
        }

    }
}