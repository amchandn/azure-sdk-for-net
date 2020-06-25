// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IntegrationRuntimeObjectMetadataOperations operations.
    /// </summary>
    public partial interface IIntegrationRuntimeObjectMetadataOperations
    {
        /// <summary>
        /// Get integration runtime object metadata
        /// </summary>
        /// <remarks>
        /// Get object metadata from an integration runtime
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='getMetadataRequest'>
        /// The parameters for getting a SSIS object metadata.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SsisObjectMetadataListResponse>> GetWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string integrationRuntimeName, GetSsisObjectMetadataRequest getMetadataRequest = default(GetSsisObjectMetadataRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Refresh integration runtime object metadata
        /// </summary>
        /// <remarks>
        /// Refresh the object metadata in an integration runtime
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace
        /// </param>
        /// <param name='integrationRuntimeName'>
        /// Integration runtime name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SsisObjectMetadataStatusResponse>> RefreshWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string integrationRuntimeName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}