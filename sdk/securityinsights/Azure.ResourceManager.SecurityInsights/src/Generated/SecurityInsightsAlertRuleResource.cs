// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A Class representing a SecurityInsightsAlertRule along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecurityInsightsAlertRuleResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecurityInsightsAlertRuleResource method.
    /// Otherwise you can get one from its parent resource <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> using the GetSecurityInsightsAlertRule method.
    /// </summary>
    public partial class SecurityInsightsAlertRuleResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityInsightsAlertRuleResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="ruleId"> The ruleId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string ruleId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityInsightsAlertRuleAlertRulesClientDiagnostics;
        private readonly AlertRulesRestOperations _securityInsightsAlertRuleAlertRulesRestClient;
        private readonly SecurityInsightsAlertRuleData _data;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsAlertRuleResource"/> class for mocking. </summary>
        protected SecurityInsightsAlertRuleResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecurityInsightsAlertRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityInsightsAlertRuleResource(ArmClient client, SecurityInsightsAlertRuleData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsAlertRuleResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityInsightsAlertRuleResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsAlertRuleAlertRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityInsightsAlertRuleAlertRulesApiVersion);
            _securityInsightsAlertRuleAlertRulesRestClient = new AlertRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsAlertRuleAlertRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SecurityInsights/alertRules";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityInsightsAlertRuleData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SecurityInsightsAlertRuleActionResources in the SecurityInsightsAlertRule. </summary>
        /// <returns> An object representing collection of SecurityInsightsAlertRuleActionResources and their operations over a SecurityInsightsAlertRuleActionResource. </returns>
        public virtual SecurityInsightsAlertRuleActionCollection GetSecurityInsightsAlertRuleActions()
        {
            return GetCachedClient(client => new SecurityInsightsAlertRuleActionCollection(client, Id));
        }

        /// <summary>
        /// Gets the action of alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}/actions/{actionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Actions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionId"> Action ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityInsightsAlertRuleActionResource>> GetSecurityInsightsAlertRuleActionAsync(string actionId, CancellationToken cancellationToken = default)
        {
            return await GetSecurityInsightsAlertRuleActions().GetAsync(actionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the action of alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}/actions/{actionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Actions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="actionId"> Action ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="actionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="actionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityInsightsAlertRuleActionResource> GetSecurityInsightsAlertRuleAction(string actionId, CancellationToken cancellationToken = default)
        {
            return GetSecurityInsightsAlertRuleActions().Get(actionId, cancellationToken);
        }

        /// <summary>
        /// Gets the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityInsightsAlertRuleResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleAlertRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityInsightsAlertRuleResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleAlertRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsAlertRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleAlertRulesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Delete");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleAlertRulesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsAlertRuleResource>> UpdateAsync(WaitUntil waitUntil, SecurityInsightsAlertRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Update");
            scope.Start();
            try
            {
                var response = await _securityInsightsAlertRuleAlertRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsAlertRuleResource>(Response.FromValue(new SecurityInsightsAlertRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the alert rule.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/alertRules/{ruleId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AlertRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The alert rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsAlertRuleResource> Update(WaitUntil waitUntil, SecurityInsightsAlertRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsAlertRuleAlertRulesClientDiagnostics.CreateScope("SecurityInsightsAlertRuleResource.Update");
            scope.Start();
            try
            {
                var response = _securityInsightsAlertRuleAlertRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsAlertRuleResource>(Response.FromValue(new SecurityInsightsAlertRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
