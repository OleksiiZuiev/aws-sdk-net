/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The configuration for the <c>ANSWER_RECOMMENDATION</c> AI Agent type.
    /// </summary>
    public partial class AnswerRecommendationAIAgentConfiguration
    {
        private string _answerGenerationAIGuardrailId;
        private string _answerGenerationAIPromptId;
        private List<AssociationConfiguration> _associationConfigurations = AWSConfigs.InitializeCollections ? new List<AssociationConfiguration>() : null;
        private string _intentLabelingGenerationAIPromptId;
        private string _queryReformulationAIPromptId;

        /// <summary>
        /// Gets and sets the property AnswerGenerationAIGuardrailId. 
        /// <para>
        /// The AI Guardrail identifier for the Answer Generation Guardrail used by the <c>ANSWER_RECOMMENDATION</c>
        /// AI Agent.
        /// </para>
        /// </summary>
        public string AnswerGenerationAIGuardrailId
        {
            get { return this._answerGenerationAIGuardrailId; }
            set { this._answerGenerationAIGuardrailId = value; }
        }

        // Check to see if AnswerGenerationAIGuardrailId property is set
        internal bool IsSetAnswerGenerationAIGuardrailId()
        {
            return this._answerGenerationAIGuardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property AnswerGenerationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Answer Generation prompt used by the <c>ANSWER_RECOMMENDATION</c>
        /// AI Agent.
        /// </para>
        /// </summary>
        public string AnswerGenerationAIPromptId
        {
            get { return this._answerGenerationAIPromptId; }
            set { this._answerGenerationAIPromptId = value; }
        }

        // Check to see if AnswerGenerationAIPromptId property is set
        internal bool IsSetAnswerGenerationAIPromptId()
        {
            return this._answerGenerationAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationConfigurations. 
        /// <para>
        /// The association configurations for overriding behavior on this AI Agent.
        /// </para>
        /// </summary>
        public List<AssociationConfiguration> AssociationConfigurations
        {
            get { return this._associationConfigurations; }
            set { this._associationConfigurations = value; }
        }

        // Check to see if AssociationConfigurations property is set
        internal bool IsSetAssociationConfigurations()
        {
            return this._associationConfigurations != null && (this._associationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntentLabelingGenerationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Intent Labeling prompt used by the <c>ANSWER_RECOMMENDATION</c>
        /// AI Agent.
        /// </para>
        /// </summary>
        public string IntentLabelingGenerationAIPromptId
        {
            get { return this._intentLabelingGenerationAIPromptId; }
            set { this._intentLabelingGenerationAIPromptId = value; }
        }

        // Check to see if IntentLabelingGenerationAIPromptId property is set
        internal bool IsSetIntentLabelingGenerationAIPromptId()
        {
            return this._intentLabelingGenerationAIPromptId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryReformulationAIPromptId. 
        /// <para>
        /// The AI Prompt identifier for the Query Reformulation prompt used by the <c>ANSWER_RECOMMENDATION</c>
        /// AI Agent.
        /// </para>
        /// </summary>
        public string QueryReformulationAIPromptId
        {
            get { return this._queryReformulationAIPromptId; }
            set { this._queryReformulationAIPromptId = value; }
        }

        // Check to see if QueryReformulationAIPromptId property is set
        internal bool IsSetQueryReformulationAIPromptId()
        {
            return this._queryReformulationAIPromptId != null;
        }

    }
}