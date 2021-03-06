// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PlannerTaskDetailsRequest.
    /// </summary>
    public partial class PlannerTaskDetailsRequest : BaseRequest, IPlannerTaskDetailsRequest
    {
        /// <summary>
        /// Constructs a new PlannerTaskDetailsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerTaskDetailsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerTaskDetails using POST.
        /// </summary>
        /// <param name="plannerTaskDetailsToCreate">The PlannerTaskDetails to create.</param>
        /// <returns>The created PlannerTaskDetails.</returns>
        public System.Threading.Tasks.Task<PlannerTaskDetails> CreateAsync(PlannerTaskDetails plannerTaskDetailsToCreate)
        {
            return this.CreateAsync(plannerTaskDetailsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified PlannerTaskDetails using POST.
        /// </summary>
        /// <param name="plannerTaskDetailsToCreate">The PlannerTaskDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerTaskDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerTaskDetails> CreateAsync(PlannerTaskDetails plannerTaskDetailsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<PlannerTaskDetails>(plannerTaskDetailsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified PlannerTaskDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified PlannerTaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<PlannerTaskDetails>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PlannerTaskDetails.
        /// </summary>
        /// <returns>The PlannerTaskDetails.</returns>
        public System.Threading.Tasks.Task<PlannerTaskDetails> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerTaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerTaskDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerTaskDetails> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PlannerTaskDetails>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerTaskDetails using PATCH.
        /// </summary>
        /// <param name="plannerTaskDetailsToUpdate">The PlannerTaskDetails to update.</param>
        /// <returns>The updated PlannerTaskDetails.</returns>
        public System.Threading.Tasks.Task<PlannerTaskDetails> UpdateAsync(PlannerTaskDetails plannerTaskDetailsToUpdate)
        {
            return this.UpdateAsync(plannerTaskDetailsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified PlannerTaskDetails using PATCH.
        /// </summary>
        /// <param name="plannerTaskDetailsToUpdate">The PlannerTaskDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated PlannerTaskDetails.</returns>
        public async System.Threading.Tasks.Task<PlannerTaskDetails> UpdateAsync(PlannerTaskDetails plannerTaskDetailsToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PlannerTaskDetails>(plannerTaskDetailsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerTaskDetailsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerTaskDetailsRequest Expand(Expression<Func<PlannerTaskDetails, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerTaskDetailsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerTaskDetailsRequest Select(Expression<Func<PlannerTaskDetails, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="plannerTaskDetailsToInitialize">The <see cref="PlannerTaskDetails"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerTaskDetails plannerTaskDetailsToInitialize)
        {

        }
    }
}
