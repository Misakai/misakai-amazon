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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDBInstance operation.
    /// Rebooting a DB instance restarts the database engine service. A reboot also applies
    /// to the DB instance any modifications to the associated DB parameter group that were
    /// pending. Rebooting a DB instance results in a momentary outage of the instance, during
    /// which the DB instance status is set to rebooting. If the RDS instance is configured
    /// for MultiAZ, it is possible that the reboot will be conducted through a failover.
    /// An Amazon RDS event is created when the reboot is completed. 
    /// 
    ///  
    /// <para>
    ///  If your DB instance is deployed in multiple Availability Zones, you can force a failover
    /// from one AZ to the other during the reboot. You might force a failover to test the
    /// availability of your DB instance deployment or to restore operations to the original
    /// AZ after a failover occurs. 
    /// </para>
    ///  
    /// <para>
    ///  The time required to reboot is a function of the specific database engine's crash
    /// recovery process. To improve the reboot time, we recommend that you reduce database
    /// activities as much as possible during the reboot process to reduce rollback activity
    /// for in-transit transactions. 
    /// </para>
    /// </summary>
    public partial class RebootDBInstanceRequest : AmazonRDSRequest
    {
        private string _dBInstanceIdentifier;
        private bool? _forceFailover;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RebootDBInstanceRequest() { }

        /// <summary>
        /// Instantiates RebootDBInstanceRequest with the parameterized properties
        /// </summary>
        /// <param name="dbInstanceIdentifier"> The DB instance identifier. This parameter is stored as a lowercase string.  Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        public RebootDBInstanceRequest(string dbInstanceIdentifier)
        {
            _dBInstanceIdentifier = dbInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        ///  The DB instance identifier. This parameter is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First
        /// character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this._dBInstanceIdentifier; }
            set { this._dBInstanceIdentifier = value; }
        }

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this._dBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ForceFailover. 
        /// <para>
        ///  When <code>true</code>, the reboot will be conducted through a MultiAZ failover.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Constraint: You cannot specify <code>true</code> if the instance is not configured
        /// for MultiAZ.
        /// </para>
        /// </summary>
        public bool ForceFailover
        {
            get { return this._forceFailover.GetValueOrDefault(); }
            set { this._forceFailover = value; }
        }

        // Check to see if ForceFailover property is set
        internal bool IsSetForceFailover()
        {
            return this._forceFailover.HasValue; 
        }

    }
}