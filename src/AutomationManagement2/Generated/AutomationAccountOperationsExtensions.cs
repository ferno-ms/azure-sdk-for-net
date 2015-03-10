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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class AutomationAccountOperationsExtensions
    {
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create or update automation
        /// account.
        /// </param>
        /// <returns>
        /// The response model for the create or update account operation.
        /// </returns>
        public static AutomationAccountCreateOrUpdateResponse CreateOrUpdate(this IAutomationAccountOperations operations, string resourceGroupName, AutomationAccountCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAutomationAccountOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create or update automation
        /// account.
        /// </param>
        /// <returns>
        /// The response model for the create or update account operation.
        /// </returns>
        public static Task<AutomationAccountCreateOrUpdateResponse> CreateOrUpdateAsync(this IAutomationAccountOperations operations, string resourceGroupName, AutomationAccountCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccountName'>
        /// Required. Automation account name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IAutomationAccountOperations operations, string resourceGroupName, string automationAccountName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAutomationAccountOperations)s).DeleteAsync(resourceGroupName, automationAccountName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccountName'>
        /// Required. Automation account name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IAutomationAccountOperations operations, string resourceGroupName, string automationAccountName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccountName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create automation account.
        /// </param>
        /// <returns>
        /// The response model for the create account operation.
        /// </returns>
        public static AutomationAccountUpdateResponse Update(this IAutomationAccountOperations operations, string resourceGroupName, AutomationAccountUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAutomationAccountOperations)s).UpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create an automation account.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IAutomationAccountOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the create automation account.
        /// </param>
        /// <returns>
        /// The response model for the create account operation.
        /// </returns>
        public static Task<AutomationAccountUpdateResponse> UpdateAsync(this IAutomationAccountOperations operations, string resourceGroupName, AutomationAccountUpdateParameters parameters)
        {
            return operations.UpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
    }
}
