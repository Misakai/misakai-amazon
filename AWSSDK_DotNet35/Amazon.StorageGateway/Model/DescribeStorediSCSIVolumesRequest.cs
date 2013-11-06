/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStorediSCSIVolumes operation.
    /// 
    /// </summary>
    public partial class DescribeStorediSCSIVolumesRequest : AmazonWebServiceRequest
    {
        private List<string> volumeARNs = new List<string>();

        /// <summary>
        /// An array of strings where each string represents the Amazon Resource Name (ARN) of a stored volume. All of the specified stored volumes must
        /// from the same gateway. Use <a>ListVolumes</a> to get volume ARNs for a gateway.
        ///  
        /// </summary>
        public List<string> VolumeARNs
        {
            get { return this.volumeARNs; }
            set { this.volumeARNs = value; }
        }

        // Check to see if VolumeARNs property is set
        internal bool IsSetVolumeARNs()
        {
            return this.volumeARNs.Count > 0;
        }

    }
}
    