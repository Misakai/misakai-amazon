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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CognitoIdentity.Model;

namespace Amazon.CognitoIdentity
{
    /// <summary>
    /// Interface for accessing CognitoIdentity
    ///
    /// Amazon Cognito 
    /// <para>
    /// Amazon Cognito is a web service that delivers scoped temporary credentials to mobile
    /// devices and other untrusted environments. Amazon Cognito uniquely identifies a device
    /// and supplies the user with a consistent identity over the lifetime of an application.
    /// </para>
    ///  
    /// <para>
    /// Using Amazon Cognito, you can enable authentication with one or more third-party identity
    /// providers (Facebook, Google, or Login with Amazon), and you can also choose to support
    /// unauthenticated access from your app. Cognito delivers a unique identifier for each
    /// user and acts as an OpenID token provider trusted by AWS Security Token Service (STS)
    /// to access temporary, limited-privilege AWS credentials.
    /// </para>
    ///  
    /// <para>
    /// To provide end-user credentials, first make an unsigned call to <a>GetId</a>. If the
    /// end user is authenticated with one of the supported identity providers, set the <code>Logins</code>
    /// map with the identity provider token. <code>GetId</code> returns a unique identifier
    /// for the user.
    /// </para>
    ///  
    /// <para>
    /// Next, make an unsigned call to <a>GetOpenIdToken</a>, which returns the OpenID token
    /// necessary to call STS and retrieve AWS credentials. This call expects the same <code>Logins</code>
    /// map as the <code>GetId</code> call, as well as the <code>IdentityID</code> originally
    /// returned by <code>GetId</code>. The token returned by <code>GetOpenIdToken</code>
    /// can be passed to the STS operation <a href="http://docs.aws.amazon.com/STS/latest/APIReference/API_AssumeRoleWithWebIdentity.html">AssumeRoleWithWebIdentity</a>
    /// to retrieve AWS credentials.
    /// </para>
    /// </summary>
    public partial interface IAmazonCognitoIdentity : IDisposable
    {
                
        #region  CreateIdentityPool

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityPool operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateIdentityPoolResponse> CreateIdentityPoolAsync(CreateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIdentityPool

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityPool operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIdentityPoolResponse> DeleteIdentityPoolAsync(DeleteIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIdentityPool

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPool operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeIdentityPoolResponse> DescribeIdentityPoolAsync(DescribeIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetId

        /// <summary>
        /// Initiates the asynchronous execution of the GetId operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetId operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIdResponse> GetIdAsync(GetIdRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOpenIdToken

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdToken operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdToken operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOpenIdTokenResponse> GetOpenIdTokenAsync(GetOpenIdTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetOpenIdTokenForDeveloperIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIdTokenForDeveloperIdentity operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIdTokenForDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetOpenIdTokenForDeveloperIdentityResponse> GetOpenIdTokenForDeveloperIdentityAsync(GetOpenIdTokenForDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentities

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentities operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListIdentitiesResponse> ListIdentitiesAsync(ListIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIdentityPools

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPools operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListIdentityPoolsResponse> ListIdentityPoolsAsync(ListIdentityPoolsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LookupDeveloperIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the LookupDeveloperIdentity operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<LookupDeveloperIdentityResponse> LookupDeveloperIdentityAsync(LookupDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MergeDeveloperIdentities

        /// <summary>
        /// Initiates the asynchronous execution of the MergeDeveloperIdentities operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeDeveloperIdentities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<MergeDeveloperIdentitiesResponse> MergeDeveloperIdentitiesAsync(MergeDeveloperIdentitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnlinkDeveloperIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkDeveloperIdentity operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkDeveloperIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnlinkDeveloperIdentityResponse> UnlinkDeveloperIdentityAsync(UnlinkDeveloperIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UnlinkIdentity

        /// <summary>
        /// Initiates the asynchronous execution of the UnlinkIdentity operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlinkIdentity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UnlinkIdentityResponse> UnlinkIdentityAsync(UnlinkIdentityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIdentityPool

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityPool operation.
        /// <seealso cref="Amazon.CognitoIdentity.IAmazonCognitoIdentity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityPool operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateIdentityPoolResponse> UpdateIdentityPoolAsync(UpdateIdentityPoolRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}